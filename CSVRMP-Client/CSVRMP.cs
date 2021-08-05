using MelonLoader;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSVRMP_Client.Scripts;

namespace CSVRMP_Client
{
    public class CSVRMP : MelonMod
    {
        /*
         * 
         * We do all of our initial setup here so it doesn't lag in-kithen, only when still in the loading scenes.
         * 
         */
        public override void OnApplicationStart()
        {
            MelonLogger.Warning("Game might lag for a bit, pushing patches and adding NetworkSync");
            NetworkSync.Awake();
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            //MelonLogger.Msg("Setting up GameObject tracking for " +sceneName);
            //Helpers.GameObjectTracking.AddScriptToAllObjects();
        }
    }
}
