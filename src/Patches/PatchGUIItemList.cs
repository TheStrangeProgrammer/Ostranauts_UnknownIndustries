using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnknownIndustries.Patches
{
    internal class PatchGUIItemList
    {

        static Plane plane = new Plane(Vector3.forward, 0);
        [HarmonyPatch(typeof(GUIItemList), "Update")]
        static class Patch_GUIItemList_Update
        {
            static void Postfix(GUIItemList __instance)
            {
                bool flag = EventSystem.current.IsPointerOverGameObject();
                if ((CrewSim.CanvasManager.State == CanvasManager.GUIState.NORMAL || CrewSim.CanvasManager.State == CanvasManager.GUIState.SHIPEDIT) && !flag) {
                    if (CrewSim.shipCurrentLoaded == null)
                    {
                        return;
                    }
                    float distance;
                    Ray ray = CrewSim.objInstance.ActiveCam.ScreenPointToRay(Input.mousePosition);
                    if (plane.Raycast(ray, out distance))
                    {
                        __instance.txt_itemList.text += ray.GetPoint(distance);
                    }
                }
                
                
            }
        }
    }
}
