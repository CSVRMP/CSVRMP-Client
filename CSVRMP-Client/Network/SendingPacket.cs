using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVRMP_Client.Network
{
    public class SendingPacket
    {
        public Enums.PacketType packetType { get; set; }
        public List<string> parameters { get; set; }
    }
}
