
using LitJson;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityModManagerNet;


namespace UnknownIndustries.ModManager
{
    internal class ModManager
    {
        static string modFolder;
        static string loadOrderJson;
        public static Button apply;

        public static List<Mod> mods;

        public static GameObject modListPanel;
        public static GUIModRow modRowPrefab;
        public static void Init() {
            mods = new List<Mod>();
            modFolder = Path.Combine(Application.dataPath, "Mods" );
            loadOrderJson = Path.Combine(modFolder, "loading_order.json");
            modListPanel = GameObject.Find("pnlFiles/pnlList/Viewport/pnlListContent");
            modRowPrefab = Resources.Load<GameObject>("prefabModRow").GetComponent<GUIModRow>();
            Transform filesPanel= GameObject.Find("pnlFiles").transform;
            for (int i = 0; i < filesPanel.childCount; i++) {
                GameObject.Destroy(filesPanel.GetChild(i));
            }
            apply = UI.CreateButton(filesPanel, new Vector3(280, -50, 0), new Vector2(80, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Texture2D(48, 48), "Apply");
            LoadMods();
            
        }
        public static void MoveUp(Mod mod)
        {
            int index = mods.FindIndex(a => a.folder == mod.folder);

        }
        public static void MoveDown(Mod mod)
        {

        }
        public static void Enable(Mod mod)
        {

        }
        public static void Disable(Mod mod)
        {

        }
        public static void Apply() {
            UpdateJson();
            DataHandler.Init();
        }
        public static void LoadMods() {

            //UnityModManager.Logger.Log("Loading mods at "+ modFolder);
            mods.Add(new Mod("core", "core", true, UnityEngine.Object.Instantiate(modRowPrefab, modListPanel.transform)));
            string[] modDirectories = Directory.GetDirectories(modFolder);
            foreach (string modDirectory in modDirectories) {
                string modInfo = Path.Combine(modDirectory, "mod_info.json");
                if (File.Exists(modInfo)){
                    string jsonString = File.ReadAllText(modInfo);
                    JsonReader reader = new JsonReader(jsonString);
                    JsonData data = JsonMapper.ToObject(reader);
                    foreach (JsonData elem in data) {
                        string modName = (string)elem["strName"];
                        mods.Add(new Mod(new DirectoryInfo(modDirectory).Name, modName, false, UnityEngine.Object.Instantiate(modRowPrefab, modListPanel.transform)));
                    }
                    
                }
            }
            
            //foreach (KeyValuePair<string, Mod> mod in mods) {
            //    UnityModManager.Logger.Log(mod.Key);
            //}
            LoadModOrder();
        }
        
        public static void LoadModOrder() {
            string jsonString = File.ReadAllText(loadOrderJson);
            JsonReader reader = new JsonReader(jsonString);
            JsonData data = JsonMapper.ToObject(reader);
            foreach (JsonData elem in data)
            {
                foreach (JsonData modDirectory in elem["aLoadOrder"])
                {
                    foreach (Mod mod in mods) {
                        if (mod.folder == (string)modDirectory) {
                            mod.Enabled = true;
                        }
                    }
                    
                }
            }

        }

        public static void UpdateJson() {

            string modString = "[\r\n  {\r\n    \"strName\" : \"Mod Loading Order\",\r\n    \"aLoadOrder\" : [";
            
            foreach (Mod mod in mods) {
                if (mod.Enabled == true) {
                    modString += "\""+mod.folder+"\"";
                }
            }
            modString += "]\r\n  }\r\n]";
            if (File.Exists(loadOrderJson))
            {
                string[] lines = new string[1];
                lines[0] = modString;
                File.WriteAllLines(loadOrderJson, lines);
            }
            else {
                StreamWriter streamWriter = File.CreateText(loadOrderJson);
                streamWriter.WriteLine(modString);
                streamWriter.Close();
            }
            
        }

        
    }
}
