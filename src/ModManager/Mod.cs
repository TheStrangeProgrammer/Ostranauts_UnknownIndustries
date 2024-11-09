using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UnknownIndustries.ModManager
{
    internal class Mod
    {
        public Button moveUp;
        public Button moveDown;
        public Button enable;
        public Button disable;
        public TextMeshProUGUI status;

        public GUIModRow guiModRow;
        public string folder;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                guiModRow.txtName.text = value;
            }
        }
        private bool _enabled;
        public bool Enabled {
            get { return _enabled; }
            set
            {
                _enabled = value;
                if (value == true)
                {
                    status.text = "enabled";
                }
                else {
                    status.text = "disabled";
                }
                
            }
        }
        public Mod(string folder,string name, bool enabled,GUIModRow guiModRow) {
            this.folder = folder;
            this.guiModRow = guiModRow;
            this.guiModRow.Status = GUIModRow.ModStatus.Loaded;
            moveUp = UI.CreateButton(guiModRow.transform, new Vector3(0, 0, 0), new Vector2(40, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), UI.arrowUp, "");
            moveUp.onClick.AddListener(delegate { ModManager.MoveUp(this); } );
            moveDown = UI.CreateButton(guiModRow.transform, new Vector3(70, 0, 0), new Vector2(40, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), UI.arrowDown, "");
            moveDown.onClick.AddListener(delegate { ModManager.MoveDown(this); });
            enable = UI.CreateButton(guiModRow.transform, new Vector3(140, 0, 0), new Vector2(40, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), UI.enable, "");
            enable.onClick.AddListener(delegate { ModManager.Enable(this); });
            disable = UI.CreateButton(guiModRow.transform, new Vector3(210, 0, 0), new Vector2(40, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), UI.disable, "");
            disable.onClick.AddListener(delegate { ModManager.Disable(this); });
            status = UI.CreateText(guiModRow.transform, new Vector3(380, 0, 0), new Vector2(80, 40), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(0.5f, 0.5f), "",Color.white);


            Name = name;
            Enabled = enabled;
        }
    }
}
