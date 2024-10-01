using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static GUIHelmet;
using static UnityEngine.UI.CanvasScaler;
using UnityEngine;
using HarmonyLib;

namespace UnknownIndustries.Patches
{
    internal class PatchGUIHelmet
    {
       /* static bool init = false;
        [HarmonyPatch(typeof(GUIHelmet), "Init")]
        static class Patch_GUIHelmet_Init
        {
            static void Postfix() {
                init = true;
            }
        }
        [HarmonyPatch(typeof(GUIHelmet), "UpdateUI")]
        static class Patch_GUIHelmet_UpdateUI
        {
            static bool Prefix(GUIHelmet __instance, CondOwner coRoomIn, CondOwner coRoomOut)
            {
                if (coRoomIn == null || !coRoomIn.HasCond("IsHuman"))
                {
                    __instance.Style = HelmetStyle.None;
                    __instance.Visible = false;
                    return true;
                }

                if (coRoomOut == null)
                {
                    return true;
                }
                if (!init)
                {
                    __instance.Init();
                }
                __instance.Visible = true;
                List<CondOwner> list = new List<CondOwner>();
                bool flag = true;
                bool flag2 = false;
                bool flag3 = false;
                if (coRoomIn.HasCond("IsEVAHUD"))
                {
                    list = coRoomIn.compSlots.GetCOs("shirt_out", bAllowLocked: false, ctEVA);
                    if (list.Count > 0)
                    {
                        CondOwner condOwner = list[0];
                        flag2 = true;
                        __instance.Style = HelmetStyle.Powered;
                        if (flag2)
                        {
                            list = condOwner.GetICOs(bAllowLocked: false);
                            bool flag4 = false;
                            foreach (CondOwner item in list)
                            {
                                if (!flag4 && __instance.ctEVABottle.Triggered(item))
                                {
                                    double num = item.GetCondAmount("StatGasMolO2") / item.GetCondAmount("StatRef") * 100.0;
                                    __instance.txtO2.text = num.ToString("n2") + "%";
                                    flag = false;
                                    if (num != fO2Last)
                                    {
                                        __instance.asO2Beep.Play();
                                        __instance.fO2Last = num;
                                    }
                                    flag4 = true;
                                }
                                else if (__instance.ctEVABatt.Triggered(item))
                                {
                                    Powered component = item.GetComponent<Powered>();
                                    double num2 = item.GetCondAmount("StatPowerMax");
                                    if (component != null)
                                    {
                                        num2 = component.PowerStoredMax;
                                    }
                                    if (num2 == 0.0)
                                    {
                                        num2 = 1.0;
                                    }
                                    double num3 = item.GetCondAmount("StatPower") / num2 * 100.0;
                                    __instance.txtBatt.text = num3.ToString("n2") + "%";
                                }
                            }
                        }
                    }
                    else
                    {
                        __instance.Style = HelmetStyle.Unpowered;
                    }
                }
                else if (coRoomIn.HasCond("IsPSHUD"))
                {
                    flag3 = true;
                    __instance.Style = HelmetStyle.Powered;
                }
                __instance.HUDOn = flag2;
                __instance.GaugeOn = flag3;
                bool flag5 = (int)Time.realtimeSinceStartup % 2 == 0;
                if (flag3)
                {
                    __instance.UpdatePSGauge(coRoomIn);
                }
                else if (flag2)
                {
                    if (flag)
                    {
                        __instance.txtO2.text = "ERROR";
                    }
                    __instance.ghO2Int.Value = coRoomIn.GetCondAmount("StatGasPpO2");
                    __instance.ghO2Ext.Value = coRoomOut.GetCondAmount("StatGasPpO2");
                    __instance.ghPressInt.Value = coRoomIn.GetCondAmount("StatGasPressure");
                    __instance.ghPressExt.Value = coRoomOut.GetCondAmount("StatGasPressure");
                    __instance.ghTempInt.Value = coRoomIn.GetCondAmount("StatGasTemp");
                    __instance.ghTempExt.Value = coRoomOut.GetCondAmount("StatGasTemp");
                    __instance.ghPressExt.DangerLow = ghPressInt.Value - fPressureDiffMax;
                    __instance.ghPressExt.DangerHigh = ghPressInt.Value + fPressureDiffMax;
                }
                return true;
            }

        }*/
    }
}
