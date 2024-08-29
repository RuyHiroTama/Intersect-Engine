using MessagePack;

namespace Intersect.Network.Packets.Server
{
    //Пакет отправки начала ивента рыбалки с случайной рыбой клиенту
    [MessagePackObject]
    public partial class SendClientFish : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public SendClientFish()
        {
        }

        public SendClientFish(Guid fishID)
        {
            FishID = fishID;
        }


        [Key(0)]
        public Guid FishID { get; set; }
    }

}