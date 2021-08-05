using CSVRMP_Client.Scripts;
using HarmonyLib;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CSVRMP_Client.Helpers
{
    [HarmonyPatch(typeof(ProductPart), "Start")]
    class ProductPartPatch
    {
        public static void Postfix(ProductPart __instance)
        {
            var script = __instance.gameObject.AddComponent<NetworkSync>();
            script.generateID();
        }
    }
}
