using System.Reflection;

using HarmonyLib;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityModManagerNet;
using LitJson;
using Ostranauts.Tools;
using System.Text;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace UnknownIndustries
{
    public static class Main
    {
        public static bool enabled;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony("com.ostranauts.kubouch.mod_example");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            modEntry.OnToggle = OnToggle;

            return true;
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            enabled = value;

            return true;
        }
        
    }
}
