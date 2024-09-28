using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;

namespace UnknownIndustries.Patches
{
    internal class PatchCrewSim
    {
        static GameObject objToSpawn;
        static Text textComponent;
        static CondOwner player;
        [HarmonyPatch(typeof(CrewSim), "StartNewGame")]
        static class Patch_CrewSim_StartNewGame
        {
            static void Postfix()
            {
                //UnityModManager.Logger.Log("Patched CrewSim StartNewGame");
                //CanvasManager.instance.goCanvasQuit.transform.Find("GUIQuit/btnSave").GetComponent<CanvasGroup>().alpha = 1f;
                ////CanvasGroup test = CrewSim.CanvasManager.goCanvasGUI.transform.Find("pnlInterface").GetComponent<CanvasGroup>();
                //objToSpawn = new GameObject("PositionUI");
                //textComponent = objToSpawn.AddComponent<Text>();
                

                //objToSpawn.transform.SetParent(CrewSim.CanvasManager.goCanvasQuit.transform,false);
                //objToSpawn.transform.position = new Vector3(40,0,0);
                //objToSpawn.transform.localScale = new Vector2(1,1);
                //textComponent.color = Color.white;
                //textComponent.text = "test";
                //textComponent.raycastTarget = false;
                //player = CrewSim.coPlayer;
            }
        }
        [HarmonyPatch(typeof(CrewSim), "DoLoadGame")]
        static class Patch_CrewSim_DoLoadGame
        {
            static void Postfix()
            {
                //UnityModManager.Logger.Log("Patched CrewSim DoLoadGame");

                //textComponent = objToSpawn.AddComponent<Text>();
                //objToSpawn.transform.SetParent(CrewSim.CanvasManager.goCanvasQuit.transform,false);
                //objToSpawn.transform.position = new Vector3(40, 0, 0);
                //objToSpawn.transform.localScale = new Vector2(1, 1);
                //textComponent.color = Color.white;
                //textComponent.text = "test";
                //textComponent.raycastTarget = false;
                //player = CrewSim.coPlayer;

            }
        }
        [HarmonyPatch(typeof(CrewSim), "LateUpdate")]
        static class Patch_CrewSim_LateUpdate
        {
            static void Postfix()
            {
                //if (player != null && textComponent!= null) {
                //    textComponent.text = player.tfVector2Position.ToString();
                //}

                //UnityModManager.Logger.Log("Patched CrewSim LateUpdate");


            }
        }
    }
}
