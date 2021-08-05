using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVRMP_Client.Constants
{
    /*
     * 
     * This will later be populated with objects that we KNOW should not get tracked.
     * 
     */
    public class DoNotTrack
    {
        public static List<string> trackBlocklist = new List<string> {
            "EventManager",
            ""
        };
    }
}
