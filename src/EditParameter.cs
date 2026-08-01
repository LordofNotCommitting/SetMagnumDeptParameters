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
        static int Set_NewsDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_Cooldown", ModConfigGeneral.Set_NewsDept_Cooldown_Array[0]);
        static int Set_NewsDept_RewardPointPF = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_RewardPointPF", ModConfigGeneral.Set_NewsDept_RewardPointPF_Array[0]);
        static int Set_NewsDept_RepBonus = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_NewsDept_RepBonus", ModConfigGeneral.Set_NewsDept_RepBonus_Array[0]);

        // Navigation - scanner
        static int Set_HWSDept_ScanRange = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ScanRange", ModConfigGeneral.Set_HWSDept_ScanRange_Array[0]);
        static int Set_HWSDept_EnemyPointPF = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_EnemyPointPF", ModConfigGeneral.Set_HWSDept_EnemyPointPF_Array[0]);
        static int Set_HWSDept_ItemPointPM = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ItemPointPM", ModConfigGeneral.Set_HWSDept_ItemPointPM_Array[0]);
        static int Set_HWSDept_ItemLevel = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_HWSDept_ItemLevel", ModConfigGeneral.Set_HWSDept_ItemLevel_Array[0]);

        // Navigation - proxy company
        static int Set_PRCODept_ProdSpeed_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PRCODept_ProdSpeed_Perc", ModConfigGeneral.Set_PRCODept_ProdSpeed_Perc_Array[0]);
        static int Set_PRCODept_MissMult_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PRCODept_MissMult_Perc", ModConfigGeneral.Set_PRCODept_MissMult_Perc_Array[0]);

        // Engineering - Weaponry
        static int Set_WPSTDept_CostReduce = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_CostReduce", ModConfigGeneral.Set_WPSTDept_CostReduce_Array[0]);
        static int Set_WPSTDept_ProjSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_ProjSlot", ModConfigGeneral.Set_WPSTDept_ProjSlot_Array[0]);
        static int Set_WPSTDept_UpgradeCap_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_WPSTDept_UpgradeCap_Perc", ModConfigGeneral.Set_WPSTDept_UpgradeCap_Perc_Array[0]);

        // Engineering - Arsenal
        static int Set_ARMSTDept_CostReduce = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_CostReduce", ModConfigGeneral.Set_ARMSTDept_CostReduce_Array[0]);
        static int Set_ARMSTDept_ProjSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_ProjSlot", ModConfigGeneral.Set_ARMSTDept_ProjSlot_Array[0]);
        static int Set_ARMSTDept_UpgradeCap_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_ARMSTDept_UpgradeCap_Perc", ModConfigGeneral.Set_ARMSTDept_UpgradeCap_Perc_Array[0]);

        // Engineering - Augmetics
        static int Set_AGSTDept_ImpGainOnAmp_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_AGSTDept_ImpGainOnAmp_Perc", ModConfigGeneral.Set_AGSTDept_ImpGainOnAmp_Perc_Array[0]);

        // Research - Classes
        static int Set_MEMDFDept_ClassSlot = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MEMDFDept_ClassSlot", ModConfigGeneral.Set_MEMDFDept_ClassSlot_Array[0]);
        // Research - Pacts
        static int Set_MORANLDept_PactUpgrade_Power = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MORANLDept_PactUpgrade_Power", ModConfigGeneral.Set_MORANLDept_PactUpgrade_Power_Array[0]);
        static int Set_MORANLDept_PactUpgrade_Stability = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MORANLDept_PactUpgrade_Stability", ModConfigGeneral.Set_MORANLDept_PactUpgrade_Stability_Array[0]);
        static int Set_MORANLDept_Quasi_Drop_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MORANLDept_Quasi_Drop_Perc", ModConfigGeneral.Set_MORANLDept_Quasi_Drop_Perc_Array[0]);
        static int Set_MORANLDept_Pact_Discount_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MORANLDept_Pact_Discount_Perc", ModConfigGeneral.Set_MORANLDept_Pact_Discount_Perc_Array[0]);
        static int Set_MORANLDept_Pact_Recovery = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_MORANLDept_Pact_Recovery", ModConfigGeneral.Set_MORANLDept_Pact_Recovery_Array[0]);
        
        // Research - Travel
        static int Set_BRENGDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_Cooldown_Two", ModConfigGeneral.Set_BRENGDept_Cooldown_Two_Array[0]);
        static int Set_BRENGDept_TimeLimit = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_TimeLimit_Two", ModConfigGeneral.Set_BRENGDept_TimeLimit_Two_Array[0]);
        static int Set_BRENGDept_DescentPortalDistance = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_DescentPortalDistance_Two", ModConfigGeneral.Set_BRENGDept_DescentPortalDistance_Two_Array[0]);
        static int Set_BRENGDept_DescentStartFloor = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_BRENGDept_DescentStartFloor_Two", ModConfigGeneral.Set_BRENGDept_DescentStartFloor_Two_Array[0]);

        // Hanger - Capsule
        static int Set_AUCAPDept_Cooldown = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_AUCAPDept_Cooldown", ModConfigGeneral.Set_AUCAPDept_Cooldown_Array[0]);
        //row val to be processed elsewhere
        // Hanger - Shuttle
        static int Set_CGSHSTDept_RowValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_CGSHSTDept_RowValue", ModConfigGeneral.Set_CGSHSTDept_RowValue_Array[0]);
        // Hanger - Trade
        static int Set_TRDSHDept_Shuttle_Cargo_Rows = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Shuttle_Cargo_Rows", ModConfigGeneral.Set_TRDSHDept_Shuttle_Cargo_Rows_Array[0]);
        static int Set_TRDSHDept_Shuttle_Move_Speed = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Shuttle_Move_Speed", ModConfigGeneral.Set_TRDSHDept_Shuttle_Move_Speed_Array[0]);
        static int Set_TRDSHDept_Reputation_Value_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Reputation_Value_Perc", ModConfigGeneral.Set_TRDSHDept_Reputation_Value_Perc_Array[0]);
        static int Set_TRDSHDept_Unsupported_Items_Value_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Unsupported_Items_Value_Perc", ModConfigGeneral.Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[0]);
        static int Set_TRDSHDept_Value_Of_Shuttle_Items_Perc = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_TRDSHDept_Value_Of_Shuttle_Items_Perc", ModConfigGeneral.Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[0]);



        // Cloning - Genome
        // No improvements to be made.
        // Cloning - Training
        // No improvements to be made.
        // Cloning - Capacitor
        // No improvements to be made.


        // Supply - Conveyer
        // No improvements to be made.
        // Supply - Scavengers
        static int Set_PUBGDept_ResourcesValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_ResourcesValue", ModConfigGeneral.Set_PUBGDept_ResourcesValue_Array[0]);
        static int Set_PUBGDept_FoodMedsValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_FoodMedsValue", ModConfigGeneral.Set_PUBGDept_FoodMedsValue_Array[0]);
        static int Set_PUBGDept_AmmoGrenadesValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_AmmoGrenadesValue", ModConfigGeneral.Set_PUBGDept_AmmoGrenadesValue_Array[0]);
        static int Set_PUBGDept_ArmorWeaponsValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_ArmorWeaponsValue", ModConfigGeneral.Set_PUBGDept_ArmorWeaponsValue_Array[0]);
        // Supply - Recycling
        static int Set_STCONDept_DisaSpeed = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_DisaSpeed", ModConfigGeneral.Set_STCONDept_DisaSpeed_Array[0]);
        static int Set_STCONDept_MoreComps = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_MoreComps", ModConfigGeneral.Set_STCONDept_MoreComps_Array[0]);
        static int Set_STCONDept_AdditMDComp = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_STCONDept_AdditMDComp", ModConfigGeneral.Set_STCONDept_AdditMDComp_Array[0]);

        public static void EnforceValueCap() {
            //final solution to prevent version change from screwing up variable to really high valSet_NewsDept_Cooldown = Math.Min(Set_NewsDept_Cooldown, ModConfigGeneral.Set_NewsDept_Cooldown_Array[2]);
            Set_NewsDept_RewardPointPF = Math.Min(Set_NewsDept_RewardPointPF, ModConfigGeneral.Set_NewsDept_RewardPointPF_Array[2]);
            Set_NewsDept_RepBonus = Math.Min(Set_NewsDept_RepBonus, ModConfigGeneral.Set_NewsDept_RepBonus_Array[2]);

            Set_HWSDept_ScanRange = Math.Min(Set_HWSDept_ScanRange, ModConfigGeneral.Set_HWSDept_ScanRange_Array[2]);
            Set_HWSDept_EnemyPointPF = Math.Min(Set_HWSDept_EnemyPointPF, ModConfigGeneral.Set_HWSDept_EnemyPointPF_Array[2]);
            Set_HWSDept_ItemPointPM = Math.Min(Set_HWSDept_ItemPointPM, ModConfigGeneral.Set_HWSDept_ItemPointPM_Array[2]);
            Set_HWSDept_ItemLevel = Math.Min(Set_HWSDept_ItemLevel, ModConfigGeneral.Set_HWSDept_ItemLevel_Array[2]);

            Set_PRCODept_ProdSpeed_Perc = Math.Min(Set_PRCODept_ProdSpeed_Perc, ModConfigGeneral.Set_PRCODept_ProdSpeed_Perc_Array[2]);
            Set_PRCODept_MissMult_Perc = Math.Min(Set_PRCODept_MissMult_Perc, ModConfigGeneral.Set_PRCODept_MissMult_Perc_Array[2]);

            Set_PRCODept_ProdSpeed_Perc = Math.Min(Set_PRCODept_ProdSpeed_Perc, ModConfigGeneral.Set_PRCODept_ProdSpeed_Perc_Array[2]);
            Set_PRCODept_MissMult_Perc = Math.Min(Set_PRCODept_MissMult_Perc, ModConfigGeneral.Set_PRCODept_MissMult_Perc_Array[2]);


            Set_WPSTDept_CostReduce = Math.Min(Set_WPSTDept_CostReduce, ModConfigGeneral.Set_WPSTDept_CostReduce_Array[2]);
            Set_WPSTDept_ProjSlot = Math.Min(Set_WPSTDept_ProjSlot, ModConfigGeneral.Set_WPSTDept_ProjSlot_Array[2]);
            Set_WPSTDept_UpgradeCap_Perc = Math.Min(Set_WPSTDept_UpgradeCap_Perc, ModConfigGeneral.Set_WPSTDept_UpgradeCap_Perc_Array[2]);

            Set_ARMSTDept_CostReduce = Math.Min(Set_ARMSTDept_CostReduce, ModConfigGeneral.Set_ARMSTDept_CostReduce_Array[2]);
            Set_ARMSTDept_ProjSlot = Math.Min(Set_ARMSTDept_ProjSlot, ModConfigGeneral.Set_ARMSTDept_ProjSlot_Array[2]);
            Set_ARMSTDept_UpgradeCap_Perc = Math.Min(Set_ARMSTDept_UpgradeCap_Perc, ModConfigGeneral.Set_ARMSTDept_UpgradeCap_Perc_Array[2]);

            Set_AGSTDept_ImpGainOnAmp_Perc = Math.Min(Set_AGSTDept_ImpGainOnAmp_Perc, ModConfigGeneral.Set_AGSTDept_ImpGainOnAmp_Perc_Array[2]);

            Set_MORANLDept_PactUpgrade_Power = Math.Min(Set_MORANLDept_PactUpgrade_Power, ModConfigGeneral.Set_MORANLDept_PactUpgrade_Power_Array[2]);
            Set_MORANLDept_PactUpgrade_Stability = Math.Min(Set_MORANLDept_PactUpgrade_Stability, ModConfigGeneral.Set_MORANLDept_PactUpgrade_Stability_Array[2]);
            Set_MORANLDept_Quasi_Drop_Perc = Math.Min(Set_MORANLDept_Quasi_Drop_Perc, ModConfigGeneral.Set_MORANLDept_Quasi_Drop_Perc_Array[2]);
            Set_MORANLDept_Pact_Discount_Perc = Math.Min(Set_MORANLDept_Pact_Discount_Perc, ModConfigGeneral.Set_MORANLDept_Pact_Discount_Perc_Array[2]);
            Set_MORANLDept_Pact_Recovery = Math.Min(Set_MORANLDept_Pact_Recovery, ModConfigGeneral.Set_MORANLDept_Pact_Recovery_Array[2]);



            Set_MEMDFDept_ClassSlot = Math.Min(Set_MEMDFDept_ClassSlot, ModConfigGeneral.Set_MEMDFDept_ClassSlot_Array[2]);
            Set_BRENGDept_Cooldown = Math.Min(Set_BRENGDept_Cooldown, ModConfigGeneral.Set_BRENGDept_Cooldown_Two_Array[2]);
            Set_BRENGDept_TimeLimit = Math.Min(Set_BRENGDept_TimeLimit, ModConfigGeneral.Set_BRENGDept_TimeLimit_Two_Array[2]);
            Set_BRENGDept_DescentPortalDistance = Math.Min(Set_BRENGDept_DescentPortalDistance, ModConfigGeneral.Set_BRENGDept_DescentPortalDistance_Two_Array[2]);
            Set_BRENGDept_DescentStartFloor = Math.Min(Set_BRENGDept_DescentStartFloor, ModConfigGeneral.Set_BRENGDept_DescentStartFloor_Two_Array[2]);
            Set_AUCAPDept_Cooldown = Math.Min(Set_AUCAPDept_Cooldown, ModConfigGeneral.Set_AUCAPDept_Cooldown_Array[2]);
            Set_CGSHSTDept_RowValue = Math.Min(Set_CGSHSTDept_RowValue, ModConfigGeneral.Set_CGSHSTDept_RowValue_Array[2]);
            //Set_TRDSHDept_Cooldown = Math.Min(Set_TRDSHDept_Cooldown, ModConfigGeneral.Set_TRDSHDept_Cooldown_Array[2]);
            //Set_TRDSHDept_TravelSpeed = Math.Min(Set_TRDSHDept_TravelSpeed, ModConfigGeneral.Set_TRDSHDept_TravelSpeed_Array[2]);
            Set_TRDSHDept_Shuttle_Cargo_Rows = Math.Min(Set_TRDSHDept_Shuttle_Cargo_Rows, ModConfigGeneral.Set_TRDSHDept_Shuttle_Cargo_Rows_Array[2]);
            Set_TRDSHDept_Shuttle_Move_Speed = Math.Min(Set_TRDSHDept_Shuttle_Move_Speed, ModConfigGeneral.Set_TRDSHDept_Shuttle_Move_Speed_Array[2]);
            Set_TRDSHDept_Reputation_Value_Perc = Math.Min(Set_TRDSHDept_Reputation_Value_Perc, ModConfigGeneral.Set_TRDSHDept_Reputation_Value_Perc_Array[2]);
            Set_TRDSHDept_Unsupported_Items_Value_Perc = Math.Min(Set_TRDSHDept_Unsupported_Items_Value_Perc, ModConfigGeneral.Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[2]);
            Set_TRDSHDept_Value_Of_Shuttle_Items_Perc = Math.Min(Set_TRDSHDept_Value_Of_Shuttle_Items_Perc, ModConfigGeneral.Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[2]);




            Set_PUBGDept_ResourcesValue = Math.Min(Set_PUBGDept_ResourcesValue, ModConfigGeneral.Set_PUBGDept_ResourcesValue_Array[2]);
            Set_PUBGDept_FoodMedsValue = Math.Min(Set_PUBGDept_FoodMedsValue, ModConfigGeneral.Set_PUBGDept_FoodMedsValue_Array[2]);
            Set_PUBGDept_AmmoGrenadesValue = Math.Min(Set_PUBGDept_AmmoGrenadesValue, ModConfigGeneral.Set_PUBGDept_AmmoGrenadesValue_Array[2]);
            Set_PUBGDept_ArmorWeaponsValue = Math.Min(Set_PUBGDept_ArmorWeaponsValue, ModConfigGeneral.Set_PUBGDept_ArmorWeaponsValue_Array[2]);
            Set_STCONDept_DisaSpeed = Math.Min(Set_STCONDept_DisaSpeed, ModConfigGeneral.Set_STCONDept_DisaSpeed_Array[2]);
            Set_STCONDept_MoreComps = Math.Min(Set_STCONDept_MoreComps, ModConfigGeneral.Set_STCONDept_MoreComps_Array[2]);
            Set_STCONDept_AdditMDComp = Math.Min(Set_STCONDept_AdditMDComp, ModConfigGeneral.Set_STCONDept_AdditMDComp_Array[2]);

        }

        public static void Postfix(MagnumParameter spaceshipParameter, MagnumProgression __instance, ref float __result)
        {
            EnforceValueCap();


            float Set_PRCODept_ProdSpeed = ((float)Set_PRCODept_ProdSpeed_Perc) / 100f;
            float Set_PRCODept_MissMult = ((float)Set_PRCODept_MissMult_Perc) / 100f;
            //Plugin.Logger.Log("Set_PRCODept_ProdSpeed:" + Set_PRCODept_ProdSpeed);
            //Plugin.Logger.Log("Set_PRCODept_MissMult:" + Set_PRCODept_MissMult);


            float Set_WPSTDept_UpgradeCap = ((float)Set_WPSTDept_UpgradeCap_Perc) / 100f;
            float Set_ARMSTDept_UpgradeCap = ((float)Set_ARMSTDept_UpgradeCap_Perc) / 100f;
            float Set_AGSTDept_ImpGainOnAmp = ((float)Set_AGSTDept_ImpGainOnAmp_Perc) / 100f;

            float Set_MORANLDept_Quasi_Drop = ((float)Set_MORANLDept_Quasi_Drop_Perc) / 100f;
            float Set_MORANLDept_Pact_Discount = ((float)Set_MORANLDept_Pact_Discount_Perc) / 100f;


            float Set_TRDSHDept_Reputation_Value = ((float)Set_TRDSHDept_Reputation_Value_Perc) / 100f;
            float Set_TRDSHDept_Unsupported_Items_Value = ((float)Set_TRDSHDept_Unsupported_Items_Value_Perc) / 100f;
            float Set_TRDSHDept_Value_Of_Shuttle_Items = ((float)Set_TRDSHDept_Value_Of_Shuttle_Items_Perc) / 100f;


            float temp_result = 0f;
            Data.MagnumDefaultValues.TryGetValue(spaceshipParameter, out temp_result);

            bool set_val = false;
            float set_value = 1f;

            bool chosen_value = false;
            //Plugin.Logger.Log("AAAAAAAAAAA" + spaceshipParameter.ToString());

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
                // Research - Pacts
                case MagnumParameter.MORANLUpgradePower:
                    {
                        set_value = Set_MORANLDept_PactUpgrade_Power;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.MORANLUpgradeStability:
                    {
                        set_value = Set_MORANLDept_PactUpgrade_Stability;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.MORANLQuasiDrop:
                    {
                        set_value = Set_MORANLDept_Quasi_Drop;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.MORANLPactDiscount:
                    {
                        //for some reason. this value is positive on stat
                        set_value = -Set_MORANLDept_Pact_Discount;
                        set_val = true;
                        chosen_value = true;
                        break;
                    }
                case MagnumParameter.MORANLPactRecovery:
                    {
                        //for some reason. this value is positive on stat
                        set_value = -Set_MORANLDept_Pact_Recovery;
                        set_val = true;
                        break;
                    }
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
                case MagnumParameter.TRDSHCargoRows:
                    {
                        set_value = Set_TRDSHDept_Shuttle_Cargo_Rows;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.TRDSHShuttleMoveSpeed:
                    {
                        set_value = Set_TRDSHDept_Shuttle_Move_Speed;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.TRDSHReputationCoefBonus:
                    {
                        set_value = Set_TRDSHDept_Reputation_Value;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.TRDSHUnsupportedSellValuePercent:
                    {
                        set_value = Set_TRDSHDept_Unsupported_Items_Value;
                        set_val = true;
                        break;
                    }
                case MagnumParameter.TRDSHValueOfShuttleItems:
                    {
                        set_value = Set_TRDSHDept_Value_Of_Shuttle_Items;
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
