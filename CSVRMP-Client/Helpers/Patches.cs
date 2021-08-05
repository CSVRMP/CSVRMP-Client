using CSVRMP_Client.Network;
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
    /*
     * 
     * Found this to be the most reliable way to detect new parts...
     * 
     */
    [HarmonyPatch(typeof(ProductPart), "Start")]
    class ProductPartStartPatch
    {
        public static void Postfix(ProductPart __instance)
        {
            MelonLogger.Msg("ProductPart " + __instance.gameObject.GetComponentInChildren<ProductPart>().GlobalId + " of type " + Localization.Get(__instance.gameObject.GetComponentInChildren<ProductPart>()) + " has been \"Started\"");
        }


        /*
         * 
         * Detect when the ProductPart recieves a cut from a knife.
         * 
         */
        [HarmonyPatch(typeof(ProductPart), "KnifeCut")]
        class ProductPartKnifeCutPatch
        {
            public static void Postfix(ProductPart __instance, Vector4 planeInLocalSpace, bool destroySource = false)
            {
                MelonLogger.Msg("Detected a KnifeCut on ProductPart " + __instance.GlobalId + " on plane " + planeInLocalSpace.ToString());

                SendingPacket sendingPacket = new SendingPacket();
                sendingPacket.packetType = Enums.PacketType.KNIFECUT;
                sendingPacket.parameters.Add(planeInLocalSpace.ToString());
                sendingPacket.parameters.Add(destroySource.ToString());

                NetworkSync.SendUDP(sendingPacket);
            }
        }

        /*
         * 
         * Detect when the ProductPart gets blended in the blender.
         * 
         */
        [HarmonyPatch(typeof(ProductPart), "MixCut")]
        class ProductPartmixCutPatch
        {
            public static void Postfix(ProductPart __instance, Vector3 cutPosition, Vector3 cutNormal)
            {
                MelonLogger.Msg("Detected a MixCut on ProductPart " + __instance.GlobalId + " on planes " + cutPosition.ToString() + " AND " + cutNormal.ToString());

                SendingPacket sendingPacket = new SendingPacket();
                sendingPacket.packetType = Enums.PacketType.MIXCUT;
                sendingPacket.parameters.Add(cutPosition.ToString());
                sendingPacket.parameters.Add(cutNormal.ToString());

                NetworkSync.SendUDP(sendingPacket);
            }
        }
    }
}