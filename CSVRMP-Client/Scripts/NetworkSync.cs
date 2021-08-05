using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CSVRMP_Client.Scripts
{
    class NetworkSync : MonoBehaviour
    {
        public string ID = "";

        void Start()
        {
            MelonLogger.Msg(gameObject.name + " has had ID Script attached");
        }

        public void generateID()
        {
            ID = Guid.NewGuid().ToString();
            MelonLogger.Msg("Generated ID: " + ID + " for " + gameObject.name);
        }

        public string getID()
        {
            return ID;
        }
    }
}
