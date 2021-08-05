using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVRMP_Client.Network
{
    public static class Enums
    {
        public enum PacketType {
            REGISTERPRODUCTPART = 0,
            POSITION = 1,
            KNIFECUT = 2,
            MIXCUT = 3
        }
    }
}
