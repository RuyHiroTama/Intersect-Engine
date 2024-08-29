using Intersect.Client.Core;
using Intersect.Client.Core.Controls;
using Intersect.Client.Core.Sounds;
using Intersect.Client.Framework.Entities;
using Intersect.Client.Framework.Graphics;
using Intersect.Client.General;
using Intersect.Client.Interface.Game.MiniEvent;
using Intersect.Client.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps;
using Intersect.Logging;
using Intersect.Utilities;
using MapAttribute = Intersect.GameObjects.Maps.MapAttribute;
namespace Intersect.Client.Entities.Events;
public partial class FishEventClient
{

    #region FuncVars
    private Player? player;
    private long lastUpdateTime;//Время последнего обновления для deltaTime
    private float deltaTime;//Дельта времени
    private bool isPressed = false;//Зажатие кнопки
    private FishEventUI? eventUI;
    private int timerFishingRod = 1000;
    private long timeFishingRod;
    private ItemBase? currentFishingRod { get; set; }
    private Sound[]? sounds;
    private FishBase? fish;
    #endregion

    #region EventVars

    private int stage { get; set; } = 0;

    private float currentValue = 0; //Текущий прогресс в ловли рыбы
    //С какого значения начинается рыбалка
    //Более дерзкая рыба уменьшает это значение
    //Более качественная удочка увеличивает это значение
    private float beginValue = 0.5f;


    //Диапазон, в котором игрок удерживает удочку
    private float currentRangeSize;
    private float targetRangeSize;
    private float currentMoveSpeed;

    private int timeChangeSpeed;
    private int timeChangeRangeSize;

    private long lastUpdateTimeRangeSize;
    private long lastUpdateTimeSpeed;
    //Текущая позиция диапазона
    private float currentFishPosition;

    private float playerPosition = 0;
    private float playerStrength = 0.15f;
    private float hookSize = 0.15f;


    private int[]? mapPosition { get; set; }
    private Direction? playerDirection { get; set; }
    private void ResetData()
    {
        currentValue = 0;
        beginValue = 0.5f;
        currentRangeSize = 0;
        targetRangeSize = 0;
        currentMoveSpeed = 0;

        timeChangeSpeed = 0;
        timeChangeRangeSize = 0;

        lastUpdateTimeRangeSize = 0;
        lastUpdateTimeSpeed = 0;
        currentFishPosition = 0;

        playerPosition = 0;
        isPullingRod = 0;
    }

    private void SetData()
    {
        currentFishPosition = fish.position / 100f;
        currentMoveSpeed = fish.speedMove / 100f;
        timeChangeSpeed = fish.timeChangeSpeed;
        timeChangeRangeSize = fish.timeChangeRangeSize;
        currentRangeSize = fish.rangeSize / 100f;
        targetRangeSize = fish.rangeSize / 100f;
    }

    #endregion

    
    public FishEventClient()
    {
        if (Interface.Interface.GameUi == null) return;
        if (eventUI == null)
            eventUI = new FishEventUI();
        player = Globals.Me;
        sounds = new Sound[10];
    }

    bool isDebaging = true;
    bool isFishing = false;//Если игрок ловит рыбу
    bool isFishingForAnimation = false;//Если игрок ловит рыбу
    bool isFishingEvent = false;//Если игрок в ивенте ловли
    
    #region Stage 0 Игрок закидывает удочку.


    public bool TryFishing()
    {
        if (isFishingEvent)
        {
            if (isDebaging)
                Log.Info("На текущий момент на крючке рыба.");
            return true;//true потому, что рыбалка выполняется, а значит удары не должны отправится на сервер
        }
        if (!IsFishingRod())
        {
            if (isDebaging)
                Log.Info("Это не удочка.");
            return false;
        }
        if (Timing.Global.Milliseconds < timeFishingRod)
        {
            if (isDebaging)
            {
                float reqsec = (int)timerFishingRod / 1000f;
                float cursec = (int)(timeFishingRod - Timing.Global.Milliseconds) / 1000f;
                Log.Info($"Таймер еще не прошёл. {cursec.ToString("0.0sec.")} < {reqsec.ToString("0.0sec.")}");
            }
            return false;
        }

        MapAttribute mapAttribute;
        mapAttribute = GetAttribute(Enums.MapAttribute.FishingSpot);
        if (mapAttribute != null)
        {
            MapFishingSpotAttribute attribute = (MapFishingSpotAttribute)mapAttribute;

            Guid fishingSpotID = attribute.FishingSpotType;
            FishingSpotBase spot = FishingSpotBase.Get(fishingSpotID);

            if (isDebaging)
                Log.Info("Удочка успешно кастанулась.");

            if (stage == 0)
            {
                PacketSender.SendFishingSpot(fishingSpotID);
            }
            else
            {
                Freeze(timerFishingRod, true);
                PacketSender.SendCanselFishing();
                isFishing = false;
                stage = 0;
                if (isDebaging)
                    Log.Info("Удочку забрали.");
            }
            timeFishingRod = Timing.Global.Milliseconds + timerFishingRod;

        }
        else
        {
            if (isDebaging)
                Log.Info("Атрибут не найден.");
            return false;
        }

        return true;
    } 

    public void FishingRodCastHundler(bool isSuccess)
    {
        if (isSuccess)
        {
            if (stage == 0)
            {
                mapPosition = new int[] { player.X, player.Y };
                playerDirection = player.Dir;
                stage = 1;
                isFishing = true;
                isFishingForAnimation = true;
                Freeze(timerFishingRod);
                if (isDebaging)
                    Log.Info("Удочку закинули.");
            }
        }
    }

    #region Функции
    private bool IsFishingRod()
    {
        if (Options.WeaponIndex > -1 && Options.WeaponIndex < player.Equipment.Length)
        {
            if (player.MyEquipment[Options.WeaponIndex] < Options.MaxInvItems)
            {
                var itemId = Guid.Empty;
                var slot = player.MyEquipment[Options.WeaponIndex];
                if (slot > -1)
                    itemId = player.Inventory[slot].ItemId;

                var item = ItemBase.Get(itemId);

                if (item != null)
                {
                    List<string> tools = [.. Options.ToolTypes.ToArray()];
                    int toolID = -1;
                    toolID = tools.FindIndex(x => x == "Fishing Rod");
                    if (toolID == -1)
                        toolID = tools.FindIndex(x => x == "FishingRod");
                    if (toolID == -1)
                        toolID = tools.FindIndex(x => x == "fishing Rod");
                    if (toolID == -1)
                        toolID = tools.FindIndex(x => x == "fishingRod");
                    if (toolID == -1)
                        toolID = tools.FindIndex(x => x == "Удочка"); 
                    if (toolID == -1)
                        toolID = tools.FindIndex(x => x == "удочка");

                    if (item.Tool == toolID && toolID != -1)
                    {
                        currentFishingRod = item;
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        else return false;
    }

    private Direction GetDirection(int _x, int _y)
    {
        switch (_x)
        {
            case 0:
                switch (_y)
                {
                    case 0:
                        return Direction.None;
                    case -1:
                        return Direction.Up;
                    case 1:
                        return Direction.Down;
                    default: return Direction.None;
                }
            case 1:
                switch (_y)
                {
                    case 0:
                        return Direction.Right;
                    case -1:
                        return Direction.UpRight;
                    case 1:
                        return Direction.DownRight;
                    default: return Direction.Right;
                }
            case -1:
                switch (_y)
                {
                    case 0:
                        return Direction.Left;
                    case -1:
                        return Direction.UpLeft;
                    case 1:
                        return Direction.DownLeft;
                    default: return Direction.Left;
                }
            default: return Direction.None;
        }
    }

    public class Vector2Int
    {
        private int m_X;
        private int m_Y;

        public int X
        {
            get { return m_X; }

            set { m_X = value; }
        }
        public int Y
        {
            get { return m_Y; }

            set { m_Y = value; }
        }

        public Vector2Int()
        {

        }

        public Vector2Int(int X, int Y)
        {
            this.m_X = X;
            this.m_Y = Y;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    default:
                        throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
                }
            }

            set
            {
                switch (index)
                {
                    case 0: X = value; break;
                    case 1: Y = value; break;
                    default:
                        throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
                }
            }
        }

        public static Vector2Int operator -(Vector2Int v)
        {
            return new Vector2Int(-v.X, -v.Y);
        }
        public static Vector2Int operator -(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.X - b.X, a.Y - b.Y);
        }
    }

    private MapAttribute GetAttribute(Enums.MapAttribute requireType)
    {
        if (Maps.MapInstance.Get(player.MapId) == null) return null;
        if ((player.X < Options.MapWidth && player.X >= 0) && (player.Y < Options.MapHeight && player.Y >= 0))
        {
            
            MapAttribute result = null;
            int radarRadius = 3;//значения 3\5\7
            for (int radarX = player.X - (radarRadius-2); radarX < player.X + 2; radarX++)
                for (int radarY = player.Y - 1; radarY < player.Y + 2; radarY++)
                {
                    Maps.MapInstance mapInstance = Maps.MapInstance.Get(player.MapId);
                    if (radarX >= Options.MapWidth || radarX < 0 || radarY >= Options.MapHeight || radarY < 0)
                        continue;
                    MapAttribute attribute = Maps.MapInstance.Get(player.MapId).Attributes[radarX, radarY];
                    if (attribute == null || attribute.Type != requireType) continue;
                    Vector2Int playerPos = new Vector2Int(player.X, player.Y);
                    Vector2Int attributePos = new Vector2Int(radarX, radarY);
                    Vector2Int direction = attributePos - playerPos;
                    Direction requiredDirection = GetDirection(direction.X, direction.Y);

                    if (requiredDirection == player.Dir)
                    {
                        result = attribute;
                        break;
                    }
                }
            return result;
        }
        else return null;
    }
    #endregion

    #endregion

    #region Stage 1 Рыба поймана на крючок. 

    public void TheFishWasCaught(Guid fishID)
    {
        if (!isFishing) return;
        ResetData();
        fish = FishBase.Get(fishID);
        SetData();

        eventUI.Show();

        lastUpdateTime = Timing.Global.MillisecondsUtc;
        lastUpdateTimeSpeed = Timing.Global.MillisecondsUtc + fish.timeChangeSpeed;
        lastUpdateTimeRangeSize = Timing.Global.MillisecondsUtc + fish.timeChangeRangeSize;

        stage = 2;
        //Проверяем силу рыбы, не сорвалась-ли она раньше, чем игрок может среагировать на это
        currentValue = beginValue - fish.pushStrength / 100f;
        if (currentValue <= 0)
        {
            FishingFailed();
            return;
        }
    }

    #endregion

    public void Update()
    {
        LoadSounds();
        FreezenUpdate();
        SoundUpdate();
        UpdateAnimation();

        switch (stage)
        {
            case 1:
                if (Controls.KeyDown(Control.MoveDown)||
                    Controls.KeyDown(Control.MoveLeft)||
                    Controls.KeyDown(Control.MoveRight)||
                    Controls.KeyDown(Control.MoveUp)||
                    Controls.KeyDown(Control.TurnAround))
                {
                    Freeze(timerFishingRod, true) ;
                    stage = 0;
                }
                break;
            case 2:
                if (eventUI == null) return;
                Globals.InFishing = true;
                isFishingEvent = true;
                deltaTime = (Timing.Global.MillisecondsUtc - lastUpdateTime) / 1000f;
                lastUpdateTime = Timing.Global.MillisecondsUtc;

                FishMove(deltaTime);
                PlayerPressKey(deltaTime);
                Progress(deltaTime);
                eventUI.RangeMoveResize(currentFishPosition, currentRangeSize);
                eventUI.PlayerForceMoved(playerPosition, hookSize);
                eventUI.Progress(currentValue);
                break;
            case 3:
                if (Timing.Global.MillisecondsUtc >= timerResultUI)
                {
                    HideResultUI();
                }
                break;
        }
    }

    #region Stage 2 Борьба с рыбой

    private void FishMove(float _deltaTime)
    {
        if (fish == null) return;
        currentFishPosition += currentMoveSpeed * _deltaTime;
        currentFishPosition = Math.Clamp(currentFishPosition, 0f + (currentRangeSize / 2f), 1f - (currentRangeSize / 2f));

        float leftRange = currentFishPosition - (currentRangeSize / 2f);
        float rightRange = currentFishPosition + (currentRangeSize / 2f);

        if (leftRange == 0f || rightRange == 1f)
            currentMoveSpeed = currentMoveSpeed * -1f;

        //Смена скорости, а иногда и направления по окончанию таймера
        if (Timing.Global.MillisecondsUtc > lastUpdateTimeSpeed)
        {
            currentMoveSpeed = ChaosRange(fish.speedMove / 100f, 0, fish.coeffUnpredictability, 1, 2) * Math.Sign(currentMoveSpeed);
            int rand = RandomRange(1, 201);
            if (rand < fish.coeffUnpredictability)
                currentMoveSpeed *= -1f;
            timeChangeSpeed = (int)ChaosRange(fish.timeChangeSpeed, 0, fish.coeffUnpredictability);
            lastUpdateTimeSpeed = Timing.Global.MillisecondsUtc + timeChangeSpeed;
        }
        //Смена целевого размера диапазона по окончанию таймера
        if (Timing.Global.MillisecondsUtc > lastUpdateTimeRangeSize)
        {
            targetRangeSize = ChaosRange(fish.rangeSize / 100f, 0, fish.coeffUnpredictability);
            timeChangeRangeSize = (int)ChaosRange(fish.timeChangeRangeSize, 0, fish.coeffUnpredictability);
            lastUpdateTimeRangeSize = Timing.Global.MillisecondsUtc + timeChangeRangeSize;
        }
        //Подгонка текущего диапазона к целевому
        if (currentRangeSize != targetRangeSize)
        {
            int sign = Math.Sign(targetRangeSize - currentRangeSize);
            currentRangeSize += fish.speedChangeRangeSize / 100f * _deltaTime * sign;
            if (Math.Abs(targetRangeSize - currentRangeSize) < 0.01f) currentRangeSize = targetRangeSize;
        }
        currentFishPosition = Math.Clamp(currentFishPosition, 0f + (currentRangeSize / 2f), 1f - (currentRangeSize / 2f));

    }


    private float isPullingRod = 0;
    private void PlayerPressKey(float _deltaTime)
    {
        if (fish == null) return;
        float volumePressEMultiple = 10;
        if (Controls.KeyDown(Control.AttackInteract))
        {
            if (!isPressed)
            {
                isPullingRod += playerStrength * volumePressEMultiple;
                playerPosition += playerStrength;
                isPressed = true;
            }
        }
        else
        {
            isPressed = false;
        }
        playerPosition -= fish.weight / 100f * _deltaTime;
        isPullingRod -= fish.weight / 100f * _deltaTime * (volumePressEMultiple *0.5f);
        playerPosition = Math.Clamp(playerPosition, 0f + (hookSize / 2f), 1f - (hookSize / 2f));
        isPullingRod = Math.Clamp(isPullingRod, 0f,1f);
        IsFishingRodPressed = isPullingRod > 0.2f ? true : false;

    }

    private void Progress(float _deltaTime)
    {
        if (fish == null) return;
        //Если крючок в диапазоне рыбы
        if (isHookInFish())
        {
            currentValue += playerStrength * _deltaTime;
            currentValue = Math.Clamp(currentValue, 0, 1);
        }
        else
        {
            currentValue -= (fish.strength / 100f) * _deltaTime;
            currentValue = Math.Clamp(currentValue, 0, 1);
        }
        bool isHookInFish()
        {
            float leftHook = playerPosition - hookSize / 2f;
            float rightHook = playerPosition + hookSize / 2f;
            float leftFish = currentFishPosition - currentRangeSize / 2f;
            float rightFish = currentFishPosition + currentRangeSize / 2f;

            if (leftFish < rightHook && rightHook < rightFish)
                return true;
            else if (leftFish < leftHook && leftHook < rightFish)
                return true;
            else return false;
        }

        if (currentValue == 0f)
            FishingFailed();
        if (currentValue == 1f)
            FishingSuccess();
    }

    float ChaosRange(float defaultValue, int min, int max, int sign = 0, int multiply = 1)
    {
        Random random = new Random();
        int scale = random.Next(min, max);
        sign = MathF.Sign(sign);
        float result = 0;
        switch (sign)
        {
            case 1:
                result = scale / 100f;
                break;
            case -1:
                result = -scale / 100f;
                break;
            default:
                int res = random.Next(1, 101);
                if (res > 50) result = scale / 100f;
                else result = -scale / 100f;
                break;
        }
        if (scale == 0) result = 0;
        return defaultValue + defaultValue * (result * multiply);
    }

    int RandomRange(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    #endregion

    #region Stage 3 Отправка результата ивента
    
    private long timerResultUI = 0;
    
    private void FishingFailed()
    {
        stage = 3;
        isFishingEvent = false;
        PacketSender.SendFailedFishing();
        timeFishingRod = Timing.Global.Milliseconds + timerFishingRod;
        if (eventUI != null) 
            eventUI.HideBars();
        timerResultUI = Timing.Global.MillisecondsUtc + timerFishingRod;
        isSuccess = false;
    }
    private void FishingSuccess()
    {
        stage = 3;
        isFishingEvent = false;
        PacketSender.SendSuccessFishing();
        timeFishingRod = Timing.Global.Milliseconds + timerFishingRod;
        if (eventUI != null && fish != null)
        {
            eventUI.RedrawIcon(ItemBase.Get(fish.ItemId));
            eventUI.HideBars();
            eventUI.ShowSuccess();
        }
        timerResultUI = Timing.Global.MillisecondsUtc + timerFishingRod;
        isSuccess = true;
    }

    private void HideResultUI()
    {
        if (eventUI == null) return;
        stage = 0;
        timerResultUI = 0;
        eventUI.HideFailed();
        eventUI.HideSuccess();
        eventUI.Hide();
        isFishingForAnimation = false;
        Globals.InFishing = false;
    }

    #endregion

    #region Звуки

    List<SoundData> soundsData = new List<SoundData>();

    public class SoundData
    {
        public string name ="";
        public int index =0;
        public SoundData(string name, int index)
        {
            this.name = name;
            this.index = index;
        }
    }

    private bool isSoundLoaded = false;
    private bool isSuccess = false;//Для звука
    private void LoadSounds()//Зарузить списки звуков
    {
        if (isSoundLoaded) return;
        LoadSoundList("fishingUse");       
        LoadSoundList("isFish");
        LoadSoundList("fishingFightOnLoad");
        LoadSoundList("fishingFightOffLoad");
        LoadSoundList("fishingFailed");
        LoadSoundList("fishingSuccess");
        isSoundLoaded = true;
    }

    private void LoadSoundList(string _name)//Поиск циклом файлов с названием _name(номер)
    {  
        for (int i = 0; i < 10; i++)
        {
            string row = $"{_name}_{i}";
            Sound? audioInstance = Audio.AddGameSound(row, false);
            if (audioInstance != null && audioInstance.Loaded)
            {
                soundsData.Add(new SoundData(_name, i));
                audioInstance.Volume = 0;
                audioInstance.Stop();
                audioInstance = null;
            }
        }
    }
    private Sound GetRandomSound(string _name, bool loop)//Получить случайное название файла по имени
    {
        Random randomSound = new Random();

        List<SoundData> find = soundsData.FindAll(x => x.name == _name);

        if (find.Count > 0)
        {
            int random = randomSound.Next(0, find.Count);
            string row = $"{find[random].name}_{find[random].index}";
            //Log.Debug(row);
            Sound result = Audio.AddGameSound(row, loop);
            return result;
        }
        else return null;
    }
    private void PlaySound(int index)//Играть звук по индексу действия
    {
        if (sounds == null) return;
        if (sounds[index] != null) return;
        switch (index)
        {
            case 0:
                sounds[index] = GetRandomSound("fishingUse", false);
                break;
            case 1:
                sounds[1] = GetRandomSound("fishingFightOnLoad", true);
                break;
            case 2:
                sounds[2] = GetRandomSound("isFish", false);
                break;
            case 3:
                sounds[3] = GetRandomSound("fishingFightOffLoad", true);
                break;
            case 4://Не помню за что отвечает 4й номер, но он нигде не встречается.
                sounds[4] = GetRandomSound("fishingUse", false);
                break;
            case 5:
                sounds[5] = GetRandomSound("fishingFailed", false);
                break;
            case 6:
                sounds[6] = GetRandomSound("fishingSuccess", false);
                break;
            default:
                break;
        }
    }
    private void StopSound(int index)//Остановить звук
    {
        if (sounds == null) return;
        if (sounds[index] == null) return;
        sounds[index].Stop();
        sounds[index] = null;
    }
    private void StopAllSounds()//Остановить все звуки
    {
        if (sounds == null) return;
        for (int soundID=0;soundID<sounds.Length;soundID++)
        {
            if (sounds[soundID] == null) continue;
            sounds[soundID].Stop();
            sounds[soundID] = null;
        }
    } 
    private void SoundUpdate()
    {
        if (player == null) return;
        switch (stage)
        {
            case 0:
                if (oldStageForSound == 1)
                {
                    StopAllSounds();
                    oldStageForSound = 0;
                    PlaySound(5);
                }
                else if(oldStageForSound == 3)
                {
                    StopAllSounds();
                    oldStageForSound = 0;
                }
                break;
            case 1:
                if (oldStageForSound == 0)
                {
                    oldStageForSound = stage;
                    PlaySound(0); 
                }
                break;
            case 2:
                if (oldStageForSound == 1)
                {
                    oldStageForSound = stage;
                    StopAllSounds();
                    PlaySound(2);
                }
                else if (oldStageForSound == 2)
                {
                    if (player.IsFishingRodPressed)
                    {
                        StopSound(3);
                        PlaySound(1);
                    }
                    else
                    {
                        PlaySound(3);
                        StopSound(1);
                    }

                }
                break;
            case 3:
                if (oldStageForSound == 2)
                {
                    oldStageForSound = stage;
                    StopAllSounds();
                    if (isSuccess)
                    {
                        PlaySound(6);
                    }
                    else PlaySound(5);
                }
                break;
        }
    }

    #endregion

    #region Заморозка
    private bool isFreezen = false;
    private bool isFreezenQuit = false;
    private long timeUnFreeze;
    void FreezenUpdate()
    {
        if (!isFreezen || timeUnFreeze > Timing.Global.Milliseconds) return;
        if (isFreezenQuit)
        {
            isFishingForAnimation = false;
        }
        Globals.InFishing = false;
        isFreezen = false;
        isFreezenQuit = false;
    }

    void Freeze(int timerFreeze, bool isFreezenQuit = false)
    {
        timeUnFreeze = Timing.Global.Milliseconds + timerFreeze;
        Globals.InFishing = true;
        isFreezen = true;
        this.isFreezenQuit = isFreezenQuit;
    }

    #endregion

    #region Пакет анимации

    private int oldStageForSound =0;
    private int oldStageForAnimation =0;
    private bool oldStatusFishing = false;
    private bool oldPressed = false;
    private bool IsFishingRodPressed = false;

    private void UpdateAnimation()
    {
        if (player == null) return;

        player.isFishing = isFishingForAnimation;
        player.FishingStage = stage;
        player.IsFishingRodPressed = IsFishingRodPressed;

        if (isFishingForAnimation != oldStatusFishing || 
            stage != oldStageForAnimation || 
            IsFishingRodPressed != oldPressed)
        {
            /*Log.Info($"\nstatus: {isFishingForAnimation}!={oldStatusFishing}\n" +
                $"stage: {stage}!={oldStageForAnimation}\n" +
                $"rodPressed: {IsFishingRodPressed}!={oldPressed}");*/
            PacketSender.SendFishing(player.Id, isFishingForAnimation, stage, IsFishingRodPressed);
            oldStageForAnimation = stage;
            oldStatusFishing = isFishingForAnimation;
            oldPressed = IsFishingRodPressed;
        }
    }

    #endregion
}
