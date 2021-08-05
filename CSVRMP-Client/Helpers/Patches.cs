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
    [HarmonyPatch(typeof(UnityEngine.Object), "Instantiate", new Type[] { typeof(UnityEngine.GameObject) })]
    class ProductPartPatch
    {
        public static void Prefix(GameObject original)
        {
            MelonLogger.Msg(original.name);
        }
    }
}
