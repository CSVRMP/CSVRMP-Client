using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CSVRMP_Client.Scripts
{
    public class NetworkSync
    {
        public static void Awake()
        {
            MelonLogger.Msg("Starting NetworkSync script.");
        }

        public static void SendUDP(Network.SendingPacket data)
        {
            MelonLogger.Msg("We *would* send a packet with the following data here: " + JsonUtility.ToJson(data));
        }
    }
}
