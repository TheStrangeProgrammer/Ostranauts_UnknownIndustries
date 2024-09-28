using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnknownIndustries
{
    [Serializable]
    public class ShipOverride
    {
        public string strName { get; set; }
        public string strTargetShip { get; set; }

        public string strRegID { get; set; }

        public int nCurrentWaypoint { get; set; }

        public float fTimeEngaged { get; set; }

        public float fWearManeuver { get; set; }

        public float fWearAccrued { get; set; }

        public string[] aDocked { get; set; }

        public string[] aProxCurrent { get; set; }

        public string[] aProxIgnores { get; set; }

        public string[] aTrackCurrent { get; set; }

        public string[] aTrackIgnores { get; set; }

        public string[] aFactions { get; set; }

        public float[] aWPTimes { get; set; }

        public JsonCondOwnerSave[] aCOs { get; set; }

        public JsonCondOwnerSave shipCO { get; set; }

        public JsonItem[] aItems { get; set; }

        public JsonItem[] aCrew { get; set; }

        public JsonItem[] aShallowPSpecs { get; set; }

        public JsonPlaceholder[] aPlaceholders { get; set; }

        public Vector2 vShipPos { get; set; }

        public JsonShipSitu objSS { get; set; }

        public JsonShipSitu[] aWPs { get; set; }

        public JsonRoom[] aRooms { get; set; }

        public JsonZone[] aZones { get; set; }

        public float[][] aBGXs { get; set; }

        public float[][] aBGYs { get; set; }

        public string[] aBGNames { get; set; }

        public Ship.Damage DMGStatus { get; set; }

        public double fLastVisit { get; set; }

        public double fFirstVisit { get; set; }

        public double fAIDockingExpire { get; set; }

        public double fAIPauseTimer { get; set; }

        public bool bPrefill { get; set; }

        public bool bBreakInUsed { get; set; }

        public bool bNoCollisions { get; set; }

        public double dLastScanTime { get; set; }

        public string strScanTargetID { get; set; }

        public string strStationKeepingTargetID { get; set; }

        public JsonShipSitu objSituScanTarget { get; set; }

        public string strUndockID { get; set; }

        public bool bLocalAuthority { get; set; }

        public bool bAIShip { get; set; }

        public string strLaw { get; set; }

        public string strParallax { get; set; }

        public string make { get; set; }

        public string model { get; set; }

        public string year { get; set; }

        public string origin { get; set; }

        public string description { get; set; }

        public string designation { get; set; }

        public string publicName { get; set; }

        public string dimensions { get; set; }

        public string[] aRating { get; set; }

        public Dictionary<string, string> aMarketConfigs { get; set; }

        public double fShallowMass { get; set; }

        public double fShallowRCSRemass { get; set; }

        public double fShallowRCSRemassMax { get; set; }

        public double fShallowFusionRemain { get; set; }

        public double fFusionThrustMax { get; set; }

        public double fFusionPelletMax { get; set; }

        public double fLastQuotedPrice { get; set; }

        public double fEpochNextGrav { get; set; }

        public float fBreakInMultiplier { get; set; }

        public float nRCSCount { get; set; }

        public float fShallowRotorStrength { get; set; }

        public int nRCSDistroCount { get; set; }

        public float fAeroCoefficient { get; set; }

        public int nDockCount { get; set; }

        public bool bFusionTorch { get; set; }

        public string strXPDR { get; set; }

        public bool bXPDRAntenna { get; set; }

        public bool bShipHidden { get; set; }

        public bool bIsUnderConstruction { get; set; }

        public int nO2PumpCount { get; set; }

        public JsonCommData commData { get; set; }

        public Ship.TypeClassification ShipType { get; set; }

        public int nConstructionProgress { get; set; }

        public int nInitConstructionProgress { get; set; }

        public JsonShipConstructionTemplate[] aConstructionTemplates { get; set; }

        public string strTemplateName { get; set; }

    }
}
