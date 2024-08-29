using MessagePack;
using System;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public partial class FishingPacket : AbstractTimedPacket
    {
        //Parameterless Constructor for MessagePack
        public FishingPacket()
        {

        }

        public FishingPacket(Guid target, bool isFishing, int stage, bool isPressed)
        {
            Target = target;
            IsFishing = isFishing;
            Stage = stage;
            IsPressed = isPressed;
        }

        [Key(3)]
        public Guid Target { get; set; }
        [Key(4)]
        public bool IsFishing { get; set; }
        [Key(5)]
        public int Stage { get; set; }
        [Key(6)]
        public bool IsPressed { get; set; }

    }

}