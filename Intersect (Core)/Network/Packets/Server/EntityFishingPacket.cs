using System;

using Intersect.Enums;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public partial class EntityFishingPacket : AbstractTimedPacket
    {
        //Parameterless Constructor for MessagePack
        public EntityFishingPacket()
        {
        }

        public EntityFishingPacket(Guid id, EntityType type, Guid mapId, bool isFishing, int stage, bool isPressed)
        {
            Id = id;
            Type = type;
            MapId = mapId;
            IsFishing = isFishing;
            Stage = stage;
            IsPressed = isPressed;
        }

        [Key(3)]
        public Guid Id { get; set; }

        [Key(4)]
        public EntityType Type { get; set; }

        [Key(5)]
        public Guid MapId { get; set; }

        [Key(6)]
        public bool IsFishing { get; set; }

        [Key(7)]
        public int Stage { get; set; }
        
        [Key(8)]
        public bool IsPressed { get; set; }


    }

}
