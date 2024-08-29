using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Crafting;
using Intersect.Logging;
using Intersect.Network.Packets.Server;
using Intersect.Server.General;
using Intersect.Server.Maps;
using Intersect.Server.Migrations.Sqlite.Game;
using Intersect.Server.Networking;
using Intersect.Utilities;
using MathNet.Numerics.Distributions;

namespace Intersect.Server.Entities.Events
{
    public class FishEventServer
    {
        #region Vars

        private Player player;

        private int[] fishingPosition;
        private Direction fishingDirection;
        private Guid fishingSpotID;
        private long timerWaitFish;
        private Guid currentFishID;
        private int stage = 0;
        #endregion

        public FishEventServer(Player player)
        {
            this.player = player;
        }

        #region Stage 0 � грок забрасывает удочку или возвращает её

        public void ServerCastFishingRod(Guid fishingSpotID)//Удочку игрок закинул
        {
            FishingSpotBase spot = FishingSpotBase.Get(fishingSpotID);
            if (spot != null && Conditions.MeetsConditionLists(spot.FishingRequirements, player, null))
            {
                this.fishingPosition = new int[] { player.X, player.Y };
                this.fishingDirection = player.Dir;
                this.fishingSpotID = fishingSpotID;
                this.stage = 1;
                Random random = new Random();
                int timer = random.Next(spot.FishingTimeMin, spot.FishingTimeMax);
                this.timerWaitFish = Timing.Global.MillisecondsUtc + timer;
                PacketSender.SendClientResultCastFishingRod(player, true);
            }
            else PacketSender.SendClientResultCastFishingRod(player, false);
        }

        public void ServerReturnFishingRod()//Удочку игрок вернул
        {
            this.stage = 0;
            this.fishingSpotID = Guid.Empty;
            timerWaitFish = 0;
        }

        #endregion

        #region Stage 1 Спустя время игроку отправляется случайная рыба

        private bool WaitingCatchFish()//Ждём рыбу
        {
            //if (stage != 1) return false;

            if (player.X != fishingPosition[0] || player.Y != fishingPosition[1] || fishingDirection != player.Dir)
            {
                //Отправить отмену или не стоит.
                this.stage = 0;
                this.fishingSpotID = Guid.Empty;
                timerWaitFish = 0;
                return false;
            }

            if (Timing.Global.MillisecondsUtc >= timerWaitFish)
                return true;
            else return false;
        }

        private Guid GetRandomFish()//Даём рыбу
        {
            FishingSpotBase fishingSpot = FishingSpotBase.Get(fishingSpotID);
            Guid result = Guid.Empty;
            List<Guid> fishes = new List<Guid>();

            //Сортируем рыбку по возрастанию на редкость
            Guid[] fishesSort = fishingSpot.SortingFishByRarity(FishingSpotBase.SortByType.INCREASING).ToArray();
            //Проверяем рыбу на соблюдение требований пожарной безопасности
            foreach (Guid fishGuid in fishesSort)
            {
                FishBase fish = FishBase.Get(fishGuid);
                if ((fish != null && Conditions.MeetsConditionLists(fish.FishingRequirements, player, null)))
                {
                    fishes.Add(fishGuid);
                }
            }
            if (fishes.Count == 0) return result;

            Random randomFish = new Random();
            for (int i = 0; i < fishes.Count; i++)
            {
                if (i == fishes.Count - 1)
                    result = fishes[fishes.Count - 1];
                else
                {
                    int randomChange = randomFish.Next(1, 101);
                    if (randomChange <= FishBase.Get(fishes[i]).chance)
                    {
                        result = fishes[i];
                        break;
                    }
                }

            }
            return result;
        }

        #endregion

        private long PacketTime;
        private bool isFishingVisual;
        private int stageVisual;
        private bool isPressed;
        private bool oldFishingVisual;
        private int oldStageVisual;
        private bool oldPressed;
        public void UpdateVisual(bool isFishingVisual, int stageVisual, bool isPressed)
        {
            this.isFishingVisual = isFishingVisual;
            this.stageVisual = stageVisual;
            this.isPressed = isPressed;
            //Console.Write($"Обновление игрока {player.Name}\n");
        }

        public void FishingUpdate()
        {
            if (Timing.Global.Milliseconds > PacketTime)
            {
                if (isFishingVisual != oldFishingVisual ||
                    stageVisual != oldStageVisual ||
                    isPressed != oldPressed)
                {
                    PacketSender.SendEntityFishing(player, isFishingVisual, stageVisual, isPressed);
                    oldFishingVisual = isFishingVisual;
                    oldStageVisual = stageVisual;
                    oldPressed = isPressed;
                }
                PacketTime = Timing.Global.Milliseconds + 100;
            }

            switch (stage)
            {
                case 1:
                    if (WaitingCatchFish())
                    {
                        currentFishID = GetRandomFish();
                        if (currentFishID != Guid.Empty)
                        {
                            PacketSender.SendClientFish(player, currentFishID);
                            stage = 2;
                        }
                        else
                        {
                            timerWaitFish = Timing.Global.MillisecondsUtc + (1000 * 60 * 60 * 24);
                        }
                    }
                    break;
            }

        }

        #region Stage 3 Результат рыбалки

        public void FishingSuccess()
        {
            FishBase fish = FishBase.Get(currentFishID);

            if (!player.TryGiveItem(fish.ItemId, 1))
            {
                if (MapController.TryGetInstanceFromMap(player.MapId, player.MapInstanceId, out var instance))
                {
                    Database.Item item = new Database.Item(fish.ItemId, 1);
                    instance.SpawnItem(player.X, player.Y, item, 1, player.Id);
                }
            }

            if (fish.Event != default)
            {
                player.EnqueueStartCommonEvent(fish.Event);
            }

            //Console.Write($"{player.Name} поймал на удочку {FishBase.Get(currentFishID).Name}.\n");
            this.stage = 0;
            this.fishingSpotID = Guid.Empty;
            timerWaitFish = 0;
            currentFishID = Guid.Empty;

        }

        public void FishingFailed()
        {
            string[] strings =
            {
                "Сорвалась..", "Блин..", "Неудача.."
            };
            Random randInstance = new Random();
            int rand = randInstance.Next(0, strings.Length);
            PacketSender.SendChatBubble(player.Id, player.MapInstanceId, (int)EntityType.GlobalEntity, strings[rand], player.MapId);
            this.stage = 0;
            this.fishingSpotID = Guid.Empty;
            timerWaitFish = 0;
            currentFishID = Guid.Empty;
            //Console.Write($"{player.Name} не поймал рыбу.\n");
        }

        #endregion


    }
}
