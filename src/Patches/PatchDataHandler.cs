using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;

namespace UnknownIndustries.Patches
{
    public static class PatchDataHandler
    {
        public static Dictionary<string, ShipOverride> dictOverrideShips = new Dictionary<string, ShipOverride>();
        public static Dictionary<string, LootOverride> dictOverrideLoot = new Dictionary<string, LootOverride>();
        [HarmonyPatch(typeof(DataHandler), "LoadMod")]
        static class Patch_DataHandler_LoadMod
        {
            static void Postfix(object[] __args)
            {
                //UnityModManager.Logger.Log("Patching custom_ships_data");
                JsonLoader.LoadJson((string)__args[0] + "data/custom_ships_data/", (string[])__args[1], (JsonModInfo)__args[2], dictOverrideShips);

                foreach (KeyValuePair<string, ShipOverride> pair in dictOverrideShips)
                {
                    //UnityModManager.Logger.Log("Patching " + pair.Value.strTargetLoot);
                    foreach (JsonItem item in pair.Value.aItems) {
                        item.strID = Guid.NewGuid().ToString();
                    }

                    List<JsonItem> aItems = new List<JsonItem>();
                    aItems.AddRange(DataHandler.dictShips[pair.Value.strTargetShip].aItems);
                    aItems.AddRange(pair.Value.aItems);

                    //UnityModManager.Logger.Log("Patched "+ pair.Value.strTargetLoot);
                    //foreach (string loot in aLoots)
                    //{
                    //    UnityModManager.Logger.Log(loot);
                    //}

                    DataHandler.dictShips[pair.Value.strTargetShip].aItems = aItems.ToArray();

                    //UnityModManager.Logger.Log("Output " + pair.Value.strTargetLoot);
                    //foreach (string loot in DataHandler.dictLoot[pair.Value.strTargetLoot].aLoots) {
                    //    UnityModManager.Logger.Log(loot);
                    //}
                }
                //UnityModManager.Logger.Log("Patching custom_loot_data");
                JsonLoader.LoadJson((string)__args[0] + "data/custom_loot_data/", (string[])__args[1], (JsonModInfo)__args[2], dictOverrideLoot);

                foreach (KeyValuePair<string, LootOverride> pair in dictOverrideLoot)
                {
                    //UnityModManager.Logger.Log("Patching " + pair.Value.strTargetLoot);

                    List<string> aLoots = new List<string>();
                    aLoots.AddRange(DataHandler.dictLoot[pair.Value.strTargetLoot].aLoots);
                    aLoots.AddRange(pair.Value.aLoots);

                    List<string> aCOs = new List<string>();
                    aCOs.AddRange(DataHandler.dictLoot[pair.Value.strTargetLoot].aCOs);
                    aLoots.AddRange(pair.Value.aCOs);

                    //UnityModManager.Logger.Log("Patched "+ pair.Value.strTargetLoot);
                    //foreach (string loot in aLoots)
                    //{
                    //    UnityModManager.Logger.Log(loot);
                    //}

                    DataHandler.dictLoot[pair.Value.strTargetLoot].aLoots = aLoots.ToArray();
                    DataHandler.dictLoot[pair.Value.strTargetLoot].aCOs = aCOs.ToArray();

                    //UnityModManager.Logger.Log("Output " + pair.Value.strTargetLoot);
                    //foreach (string loot in DataHandler.dictLoot[pair.Value.strTargetLoot].aLoots) {
                    //    UnityModManager.Logger.Log(loot);
                    //}
                }

            }
        }
    }
}
