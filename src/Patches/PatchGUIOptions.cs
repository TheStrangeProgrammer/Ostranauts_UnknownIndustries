using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnknownIndustries.Patches
{
    internal class PatchGUIOptions
    {
        [HarmonyPatch(typeof(GUIOptions), "Init")]
        static class Patch_GUIOptions_Init
        {
            static void Postfix(GUIOptions __instance)
            {

                
            }
        }
    }
}
