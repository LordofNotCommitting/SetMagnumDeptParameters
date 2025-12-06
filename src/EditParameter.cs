using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SetMagnumDeptParameters
{
    [HarmonyPatch(typeof(MagnumProgression), nameof(MagnumProgression.ModifyWithParameter))]
    public static class EditParameter
    {

        // Navigation - monitoring
        static int Set_NewsDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_Cooldown", 30);
        static int Set_NewsDept_RewardPointPF = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_RewardPointPF", 0);
        static int Set_NewsDept_RepBonus = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_RepBonus", 0);

        // Navigation - scanner
        static int Set_HWSDept_ScanRange = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ScanRange", 1);
        static int Set_HWSDept_EnemyPointPF = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_EnemyPointPF", 0);
        static int Set_HWSDept_ItemPointPM = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ItemPointPM", 0);
        static int Set_HWSDept_ItemLevel = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ItemLevel", 0);

        // Navigation - proxy company
        static int Set_PRCODept_ProdSpeed_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PRCODept_ProdSpeed_Perc", 100);
        static int Set_PRCODept_MissMult_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PRCODept_MissMult_Perc", 100);
        static float Set_PRCODept_ProdSpeed = ((float)Set_PRCODept_ProdSpeed_Perc) / 100f;
        static float Set_PRCODept_MissMult = ((float)Set_PRCODept_MissMult_Perc) / 100f;

        // Engineering - Weaponry
        static int Set_WPSTDept_CostReduce = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_CostReduce", 0);
        static int Set_WPSTDept_ProjSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_ProjSlot", 1);
        static int Set_WPSTDept_UpgradeCap_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_UpgradeCap_Perc", 0);
        static float Set_WPSTDept_UpgradeCap = ((float)Set_WPSTDept_UpgradeCap_Perc) / 100f;

        // Engineering - Arsenal
        static int Set_ARMSTDept_CostReduce = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_CostReduce", 0);
        static int Set_ARMSTDept_ProjSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_ProjSlot", 1);
        static int Set_ARMSTDept_UpgradeCap_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_UpgradeCap_Perc", 0);
        static float Set_ARMSTDept_UpgradeCap = ((float)Set_ARMSTDept_UpgradeCap_Perc) / 100f;

        // Engineering - Augmetics
        static int Set_AGSTDept_ImpGainOnAmp_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_AGSTDept_ImpGainOnAmp_Perc", 15);
        static float Set_AGSTDept_ImpGainOnAmp = ((float)Set_AGSTDept_ImpGainOnAmp_Perc) / 100f;

        // Research - Classes
        static int Set_MEMDFDept_ClassSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MEMDFDept_ClassSlot", 1);
        // Research - Pacts
        // coming soon, I hope.
        // Research - Travel
        static int Set_BRENGDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_Cooldown", 336);
        static int Set_BRENGDept_TimeLimit = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_TimeLimit", 600);
        static int Set_BRENGDept_DescentPortalDistance = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_DescentPortalDistance", 32);
        static int Set_BRENGDept_DescentStartFloor = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_DescentStartFloor", 1);

        // Hanger - Capsule
        static int Set_AUCAPDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_AUCAPDept_Cooldown", 24);
        //row val to be processed elsewhere
        // Hanger - Shuttle
        static int Set_CGSHSTDept_RowValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_CGSHSTDept_RowValue", 1);
        // Hanger - Trade
        static int Set_TRDSHDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Cooldown", 24);
        static int Set_TRDSHDept_TravelSpeed = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_TravelSpeed", 96);

        // Cloning - Genome
        // No improvements to be made.
        // Cloning - Training
        // No improvements to be made.
        // Cloning - Capacitor
        // No improvements to be made.


        // Supply - Conveyer
        // No improvements to be made.
        // Supply - Scavengers
        static int Set_PUBGDept_ResourcesValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_ResourcesValue", 1);
        static int Set_PUBGDept_FoodMedsValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_FoodMedsValue", 1);
        static int Set_PUBGDept_AmmoGrenadesValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_AmmoGrenadesValue", 1);
        static int Set_PUBGDept_ArmorWeaponsValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_ArmorWeaponsValue", 1);
        // Supply - Recycling
        static int Set_STCONDept_DisaSpeed = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_DisaSpeed", 24);
        static int Set_STCONDept_MoreComps = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_MoreComps", 0);
        static int Set_STCONDept_AdditMDComp = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_AdditMDComp", 0);



        public static void Postfix(MagnumParameter spaceshipParameter, MagnumProgression __instance, ref float __result)
        {

            float temp_result = 0f;
            Data.MagnumDefaultValues.TryGetValue(spaceshipParameter, out temp_result);

            bool set_val = false;
            float set_value = 1f;

            bool chosen_value = false;


            switch (spaceshipParameter) {
                // Navigation - monitoring
                case MagnumParameter.NDCooldownTimeReduce:
                    {
                        set_value = Set_NewsDept_Cooldown;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.NDRewardPointPerFloor:
                    {
                        set_value = Set_NewsDept_RewardPointPF;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.NDReputationBonus:
                    {
                        set_value = Set_NewsDept_RepBonus;
                        set_val = true;
                        break;
                    }
                // Navigation - scanner
                case MagnumParameter.HWSCScanFloorBonus:
                    {
                        set_value = Set_HWSDept_ScanRange;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.HWSCEnemyFloorBonus:
                    {
                        set_value = Set_HWSDept_EnemyPointPF;
                        set_val = true;
                        chosen_value = true;
                        break;
                    }
                case MagnumParameter.HWSCItemDropScanFloorBonus:
                    {
                        set_value = Set_HWSDept_ItemPointPM;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.HWSCItemLevelDropBonus:
                    {
                        set_value = Set_HWSDept_ItemLevel;
                        set_val = true;
                        break;
                    }
                // Navigation - proxy company
                case MagnumParameter.PRCOStationProduceSpeedPercent:
                    {
                        set_value = Set_PRCODept_ProdSpeed;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.PRCOPostMissionBonusMult:
                    {
                        set_value = Set_PRCODept_MissMult;
                        set_val = true;
                        break;
                    }
                // Engineering - Weaponry
                case MagnumParameter.WPSTUpgradeWeaponCostReduce:
                    {
                        set_value = Set_WPSTDept_CostReduce;
                        set_val = true;
                        chosen_value = true;
                        break;
                    }
                case MagnumParameter.WPSTUpgradeMoreWeapon:
                    {
                        set_value = Set_WPSTDept_ProjSlot;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.WPSTMaxLevelLimit:
                    {
                        set_value = Set_WPSTDept_UpgradeCap;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.ARMSTUpgradeArmorCostReduce:
                    {
                        set_value = Set_ARMSTDept_CostReduce;
                        set_val = true;
                        chosen_value = true;
                        break;
                    }
                // Engineering - Arsenal
                case MagnumParameter.ARMSTUpgradeMoreArmors:
                    {
                        set_value = Set_ARMSTDept_ProjSlot;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.ARMSTMaxLevelLimit:
                    {
                        set_value = Set_ARMSTDept_UpgradeCap;
                        set_val = true;
                        break;
                    }
                // Engineering - Augmetics
                case MagnumParameter.AGSTImplantGainChanceOnAmp:
                    {
                        set_value = Set_AGSTDept_ImpGainOnAmp;
                        set_val = true;
                        break;
                    }
                // Research - Classes
                case MagnumParameter.MEMDFfClassesToModify:
                    {
                        set_value = Set_MEMDFDept_ClassSlot;
                        set_val = true;
                        break;
                    }
                // Research - Pacts (if they existed)
                // Research - Travel
                case MagnumParameter.BRENGCooldownDuration:
                    {
                        set_value = Set_BRENGDept_Cooldown;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.BRENGTimeLimit:
                    {
                        set_value = Set_BRENGDept_TimeLimit;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.BRENGPortalRadius:
                    {
                        set_value = Set_BRENGDept_DescentPortalDistance;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.BRENGStartStage:
                    {
                        set_value = Set_BRENGDept_DescentStartFloor;
                        set_val = true;
                        break;
                    }
                // Hanger - Capsule
                case MagnumParameter.AUCAPCapsuleRestoreSpeed:
                    {
                        set_value = Set_AUCAPDept_Cooldown;
                        set_val = true;
                        break;
                    }
                // Hanger - Shuttle
                case MagnumParameter.CGSHSTShuttleInventorySize:
                    {
                        set_value = Set_CGSHSTDept_RowValue;
                        set_val = true;
                        break;
                    }
                // Hanger - Trade
                case MagnumParameter.TRDSHShuttleRestoreSpeed:
                    {
                        set_value = Set_TRDSHDept_Cooldown;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.TRDSHShuttleMoveSpeed:
                    {
                        set_value = Set_TRDSHDept_TravelSpeed;
                        set_val = true;
                        break;
                    }
                // Supply - Scavengers
                case MagnumParameter.PUBGBonusResources:
                    {
                        set_value = Set_PUBGDept_ResourcesValue;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.PUBGBonusFoodMeds:
                    {
                        set_value = Set_PUBGDept_FoodMedsValue;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.PUBGBonusAmmoGrenades:
                    {
                        set_value = Set_PUBGDept_AmmoGrenadesValue;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.PUBGBonusArmorWeapons:
                    {
                        set_value = Set_PUBGDept_ArmorWeaponsValue;
                        set_val = true;
                        break;
                    }
                // Supply - Recycling
                case MagnumParameter.STCONDisassemblyItemsSpeed:
                    {
                        set_value = Set_STCONDept_DisaSpeed;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.STCONMoreCompsOnDisassembly:
                    {
                        set_value = Set_STCONDept_MoreComps;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.STCONAdditMDCompOnDisassembly:
                    {
                        set_value = Set_STCONDept_AdditMDComp;
                        set_val = true;
                        break;
                    }
                // fallback option
                default:
                    {
                        set_val = false;
                        break;
                    }
            }
            if (set_val) {
                temp_result = set_value;
            }


            
            // get upgrades
            foreach (string id in __instance._purchasedPerks)
            {
                MagnumPerkRecord record = Data.MagnumPerks.GetRecord(id, true);
                if (record != null)
                {
                    List<MagnumParameterModifier> modifiers = record.Modifiers;
                    for (int i = 0; i < modifiers.Count; i++)
                    {
                        temp_result += modifiers[i].ModifyParameter(spaceshipParameter, temp_result);
                    }
                }
            }

            //for debugging
            //Plugin.Logger.Log("val overridden status " + set_val + ", current value at " + temp_result + " for value " + spaceshipParameter.ToString());


            //if default is above 0 but effect push it to negative, set to 1
            if (set_val && set_value > 0 && temp_result < 0) {
                temp_result = 1;
            } 
            //otherwise. if default value is equal or below 0 and final product is not suppose to be a negative value but right now they are. set to 0
            else if (set_val && set_value <= 0 && temp_result < 0 && !chosen_value) {
                temp_result = 0;
            }


            __result = temp_result;

        }
    }
}
