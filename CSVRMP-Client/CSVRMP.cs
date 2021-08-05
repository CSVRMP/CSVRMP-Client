using MelonLoader;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVRMP_Client
{
    public class CSVRMP : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Warning("Game might lag for a bit, pushing patches");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            //MelonLogger.Msg("Setting up GameObject tracking for " +sceneName);
            //Helpers.GameObjectTracking.AddScriptToAllObjects();
        }
    }
}
