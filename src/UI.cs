
using UnityEngine.UI;
using UnityEngine;
using UnityModManagerNet;
using System.IO;
using TMPro;

namespace UnknownIndustries
{
    internal class UI
    {
        public static Texture2D arrowUp;
        public static Texture2D arrowDown;
        public static Texture2D enable;
        public static Texture2D disable;
        public static Texture2D apply;
        public static Button CreateButton(Transform parent, Vector3 position, Vector2 size, Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot, Texture2D texture, string text) //, UnityEngine.Events.UnityAction method
        {
            //UnityModManager.Logger.Log("Created Button at" + parent.position.x+" "+ parent.position.y+" " + parent.position.z);
            GameObject buttonGameObject = CreateUIGameObject(parent, position, size, anchorMin, anchorMax, pivot);

            Button button = buttonGameObject.AddComponent<Button>();

            CreateRawImage(buttonGameObject.transform, new Vector3(0, 0, 0), size, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), texture);
            CreateText(buttonGameObject.transform, new Vector3(size.x, -10, 0), size, new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), text,Color.black);

            //button.GetComponent<Button>().onClick.AddListener(method);
            return button;
        }
        public static RawImage CreateRawImage(Transform parent, Vector3 position, Vector2 size, Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot,Texture2D texture) //, UnityEngine.Events.UnityAction method
        {
           // UnityModManager.Logger.Log("Created RawImage");
            GameObject imageGameObject = CreateUIGameObject(parent, position, size, anchorMin, anchorMax, pivot);

            RawImage rawImage = imageGameObject.AddComponent<RawImage>();

            //imageComponent.color = Color.white;
            rawImage.texture = texture;
            //button.GetComponent<Button>().onClick.AddListener(method);
            return rawImage;
        }
        public static TextMeshProUGUI CreateText(Transform parent, Vector3 position, Vector2 size, Vector2 anchorMin, Vector2 anchorMax, Vector2 pivot, string text,Color color) //, UnityEngine.Events.UnityAction method
        {
           // UnityModManager.Logger.Log("Created Text");
            GameObject textGameObject = CreateUIGameObject(parent, position, size, anchorMin, anchorMax, pivot);

            TextMeshProUGUI textMeshProUGUI = textGameObject.AddComponent<TextMeshProUGUI>();

            textMeshProUGUI.text = text;
            textMeshProUGUI.color = color;

            return textMeshProUGUI;
        }
        public static GameObject CreateUIGameObject(Transform parent, Vector3 position, Vector2 size, Vector2 anchorMin, Vector2 anchorMax,Vector2 pivot) //, UnityEngine.Events.UnityAction method
        {
           // UnityModManager.Logger.Log("Created Text");
            GameObject gameObject = new GameObject();

            gameObject.transform.parent = parent;

            RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
            rectTransform.anchorMin = anchorMin;
            rectTransform.anchorMax = anchorMax;
            rectTransform.pivot = pivot;

            rectTransform.localPosition = position;
            rectTransform.sizeDelta = size;
            return gameObject;
        }
        public static Texture2D LoadPNG(string filePath)
        {

            string modFolder = Path.Combine(Application.dataPath, "Mods/");
            //UnityModManager.Logger.Log("Load "+ Path.Combine(modFolder, filePath));
            Texture2D tex = null;
            byte[] fileData;

            if (File.Exists(Path.Combine(modFolder, filePath)))
            {
                fileData = File.ReadAllBytes(Path.Combine(modFolder, filePath));
                tex = new Texture2D(2, 2);
                tex.LoadImage(fileData); //..this will auto-resize the texture dimensions.
            }
            return tex;
        }
    }
}
