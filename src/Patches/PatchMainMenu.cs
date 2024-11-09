using HarmonyLib;
using Ostranauts.Core;
namespace UnknownIndustries.Patches
{
    internal class PatchMainMenu
    {
        [HarmonyPatch(typeof(MainMenu), "Start")]
       static class Patch_MainMenu_Start
        {
           static void Postfix()
           {
                UnknownIndustries.ModManager.ModManager.Init();
            }
       }

    }
}
