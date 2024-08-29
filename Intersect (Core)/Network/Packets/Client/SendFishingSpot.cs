using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Client;

//����� ������� �� �������� ���� � ������� �� ������ �������
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
