using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Client;

[MessagePackObject]
public class SendSuccessFishing: IntersectPacket
{
    public SendSuccessFishing()
    {
    }
}
