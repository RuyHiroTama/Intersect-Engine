using MessagePack;

namespace Intersect.Network.Packets.Client;

[MessagePackObject]
public class SteamDataPacket: IntersectPacket
{
    //Parameterless Constructor for MessagePack
    public SteamDataPacket()
    {
    }
    
    public SteamDataPacket(ulong steamId)
    {
        SteamId = steamId;
    }
    
    [Key(0)] public ulong SteamId { get; set; }
}