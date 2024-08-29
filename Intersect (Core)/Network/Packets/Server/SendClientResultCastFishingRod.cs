using MessagePack;

namespace Intersect.Network.Packets.Server
{
    //Пакет отправки успеха начала рыбалки
    [MessagePackObject]
    public partial class SendClientResultCastFishingRod : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public SendClientResultCastFishingRod()
        {
        }

        public SendClientResultCastFishingRod(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }


        [Key(0)]
        public bool IsSuccess { get; set; }
    }

}