using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityModManagerNet;

namespace UnknownIndustries
{
    public static class JsonLoader
    {
        public static void LoadJson<TJson>(string strFolderPath, string[] aIgnorePatterns, JsonModInfo jmi, Dictionary<string, TJson> dict) {
            //UnityModManager.Logger.Log("Finding Folder "+ strFolderPath);
            if (!Directory.Exists(strFolderPath))
            {
                return;
            }
            string[] files = Directory.GetFiles(strFolderPath, "*.json", SearchOption.AllDirectories);
            string[] array = files;
            //UnityModManager.Logger.Log("Parsing String");
            foreach (string strIn in array)
            {
                string text = DataHandler.PathSanitize(strIn);
                bool flag = false;
                if (aIgnorePatterns != null)
                {
                    foreach (string value in aIgnorePatterns)
                    {
                        if (text.IndexOf(value) >= 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    Debug.LogWarning("Ignore Pattern match: " + text + "; Skipping...");
                }
                else
                {
                    DataHandler.JsonToData(text, dict);
                }
            }
        }
    }
}
