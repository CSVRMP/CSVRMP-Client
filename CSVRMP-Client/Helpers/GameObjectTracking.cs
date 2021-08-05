using CSVRMP_Client.Scripts;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CSVRMP_Client.Helpers
{
    public class GameObjectTracking
    {
        public static void AddScriptToAllObjects()
        {
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
            foreach (GameObject go in allObjects)
            { 
                if (go.activeInHierarchy) { 
                    var script = go.AddComponent<NetworkSync>();
                    script.generateID();
                }
            }
        }
    }
}
