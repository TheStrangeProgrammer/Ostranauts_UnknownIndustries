using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityModManagerNet;

namespace UnknownIndustries.Patches
{
    internal class PatchInitShip
    {
        /*[HarmonyPatch(typeof(Ship), "InitShip")]
        static class Patch_Ship_InitShip
        {
            static void Postfix(Ship __instance)
            {

                //UnityModManager.Logger.Log("Patched Ship InitShip");
                foreach (CondOwner co in __instance.GetCOs(null, bSubObjects: true, bAllowDocked: false, bAllowLocked: true))
                {
                    if (co.HasCond("IsSocialItem") && co.HasCond("StatInstallProgressMax"))
                    {
                        //UnityModManager.Logger.Log("Destroying " + co.strName);
                        __instance.BGItemRemove(co.Item);
                        __instance.RemoveCO(co);
 
                    }
                }

            }
        }*/

    }
}
