using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnknownIndustries.Patches
{
    internal class PatchGUIModRow
    {
        [HarmonyPatch(typeof(GUIModRow), "Awake")]
        static class Patch_GUIModRow_Awake
        {

            static void Postfix(GUIModRow __instance)
            {
               
            }
            
        }
    }
}
