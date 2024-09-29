using HarmonyLib;
using Ostranauts.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityModManagerNet;

namespace UnknownIndustries.Patches
{
    internal class PatchCondOwner
    {
        [HarmonyPatch(typeof(CondOwner), "DropCO")]
        static class Patch_CondOwner_DropCO
        {
            static bool Prefix(CondOwner objCO, bool bAllowLocked, Ship objShipRef = null, float xOffset = 0f, float yOffset = 0f, bool dropInContainersLast = true, Func<int[], int[]> sortingProvider = null)
            {
                UnityModManager.Logger.Log("Dropping "+ objCO.strName +" "+ bAllowLocked.ToString());
                if (objCO.HasCond("IsSocialItem") && objCO.HasCond("StatInstallProgressMax"))
                {
                    Debug.LogWarning("Prevented " + objCO.strName);
                    return true;
                }
                Debug.LogWarning("Skipped " + objCO.strName);
                return false;
            }
        }
        /*[HarmonyPatch(typeof(CondOwner), "DropCO")]
        static class Patch_CondOwner_DropCO
        {
            static bool Prefix(CondOwner objCO, bool bAllowLocked, Ship objShipRef = null, float xOffset = 0f, float yOffset = 0f, bool dropInContainersLast = true, Func<int[], int[]> sortingProvider = null)
            {
                if (objCO.HasCond("IsSocialItem") && objCO.HasCond("StatInstallProgressMax")) {
                    Debug.LogWarning("Prevented " + objCO.strName);
                    return true;
                }
                Debug.LogWarning("Skipped " + objCO.strName);
                return false;

            }
        }*/
    }
}
