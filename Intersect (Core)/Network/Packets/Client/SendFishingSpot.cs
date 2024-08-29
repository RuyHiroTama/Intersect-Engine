using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Client;

//Пакет клиента на ожидание рыбы и запроса на начало рыбалки
[MessagePackObject]
public class SendFishingSpot : IntersectPacket
{
    public SendFishingSpot()
    {
    }

    public SendFishingSpot(Guid fishingSpotID)
    {
        FishingSpotID = fishingSpotID;
    }

    [Key(0)]
    public Guid FishingSpotID { get; set; }
}
