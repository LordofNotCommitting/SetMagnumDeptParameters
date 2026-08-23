using MGSC;
using ModConfigMenu.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SetMagnumDeptParameters
{
    // Token: 0x02000006 RID: 6
    public class ModConfigGeneral
    {


        // ====== combined ======
        // default, min, max value respectively
        public static int[] Set_NewsDept_Cooldown_Array = new int[] { 504, 1, 504 };
        public static int[] Set_NewsDept_RewardPointPF_Array = new int[] { 0, 0, 1000 };
        public static int[] Set_NewsDept_RepBonus_Array = new int[] { 0, 0, 100 };

        public static int[] Set_HWSDept_ScanRange_Array = new int[] { 1, 1, 10 };
        public static int[] Set_HWSDept_EnemyPointPF_Array = new int[] { 0, -3000, 0 };
        public static int[] Set_HWSDept_ItemPointPM_Array = new int[] { 0, 0, 2000 };
        public static int[] Set_HWSDept_ItemLevel_Array = new int[] { 0, 0, 10 };

        public static int[] Set_PRCODept_ProdSpeed_Perc_Array = new int[] { 100, 0, 1000 };
        public static int[] Set_PRCODept_MissMult_Perc_Array = new int[] { 100, 0, 1000 };

        public static int[] Set_WPSTDept_CostReduce_Array = new int[] { 0, -600, 0 };
        public static int[] Set_WPSTDept_ProjSlot_Array = new int[] { 2, 2, 30 };
        public static int[] Set_WPSTDept_UpgradeCap_Perc_Array = new int[] { 0, 0, 3900 };

        public static int[] Set_ARMSTDept_CostReduce_Array = new int[] { 0, -600, 0 };
        public static int[] Set_ARMSTDept_ProjSlot_Array = new int[] { 4, 4, 30 };
        public static int[] Set_ARMSTDept_UpgradeCap_Perc_Array = new int[] { 0, 0, 3900 };

        public static int[] Set_AGSTDept_ImpGainOnAmp_Perc_Array = new int[] { 5, 5, 100 };

        public static int[] Set_MEMDFDept_ClassSlot_Array = new int[] { 2, 2, 20 };


        public static int[] Set_MORANLDept_PactUpgrade_Power_Array = new int[] { 0, 0, 2000 };
        public static int[] Set_MORANLDept_PactUpgrade_Stability_Array = new int[] { 0, 0, 400 };
        public static int[] Set_MORANLDept_Quasi_Drop_Perc_Array = new int[] { 0, 0, 100 };
        public static int[] Set_MORANLDept_Pact_Discount_Perc_Array = new int[] { 0, -100, 0 };
        public static int[] Set_MORANLDept_Pact_Recovery_Array = new int[] { 0, -1200, 0 };


        public static int[] Set_BRENGDept_Cooldown_Two_Array = new int[] { 336, 1, 336 };
        public static int[] Set_BRENGDept_TimeLimit_Two_Array = new int[] { 400, 400, 6000 };
        public static int[] Set_BRENGDept_DescentPortalDistance_Two_Array = new int[] { 32, 1, 32 };
        public static int[] Set_BRENGDept_DescentStartFloor_Two_Array = new int[] { 1, 1, 40 };

        public static int[] Set_AUCAPDept_Cooldown_Array = new int[] { 168, 1, 168 };
        public static int[] Set_AUCAPDept_Custom_RowValue_Array = new int[] { 1, 1, 40 };
        public static int[] Set_CGSHSTDept_RowValue_Array = new int[] { 1, 1, 40 };

        public static int[] Set_PUBGDept_ResourcesValue_Array = new int[] { 1, -2, 10 };
        public static int[] Set_PUBGDept_FoodMedsValue_Array = new int[] { 2, -2, 10 };
        public static int[] Set_PUBGDept_AmmoGrenadesValue_Array = new int[] { 2, -2, 10 };
        public static int[] Set_PUBGDept_ArmorWeaponsValue_Array = new int[] { 1, -2, 10 };
        public static int[] Set_PUBGDept_Fridge_Store_Custom_RowValue_Array = new int[] { 4, 4, 400 };

        public static int[] Set_STCONDept_DisaSpeed_Array = new int[] { 72, 1, 72 };
        public static int[] Set_STCONDept_MoreComps_Array = new int[] { 0, -2, 20 };
        public static int[] Set_STCONDept_AdditMDComp_Array = new int[] { 0, -2, 10 };


        public static int[] Set_TRDSHDept_Shuttle_Cargo_Rows_Array = new int[] { 4, 4, 600 };
        public static int[] Set_TRDSHDept_Shuttle_Move_Speed_Array = new int[] { 344, 1, 344 };
        public static int[] Set_TRDSHDept_Reputation_Value_Perc_Array = new int[] { 1, 1, 100 };
        public static int[] Set_TRDSHDept_Unsupported_Items_Value_Perc_Array = new int[] { 20, 20, 80 };
        public static int[] Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array = new int[] { 0, 0, 500 };




        public static int[] Set_GNEDDept_CostReduce_Array = new int[] { 0, -600, 0 };
        

        public ModConfigGeneral(string ModName, string ConfigPath)
        {

            this.ModName = ModName;
            this.ModData = new ModConfigData(ConfigPath);
            this.ModData.AddConfigHeader("General Settings", "general");
            this.ModData.AddConfigValue("general", "about_final", "<color=#f51b1b>The game must be restarted after setting then saving this config to take effect.</color>\n\n");

            this.ModData.AddConfigValue("general", "about_final2", "The stat here are <color=#f51b1b>before other sub-dept bonus</color> are being applied to.\n\n");

            this.ModData.AddConfigHeader("Navigation", "Navigation");
            // Navigation - monitoring
            this.ModData.AddConfigValue("Navigation", "about_ND", "[ <color=#FFFEC1>Navigation - Monitoring</color> ]\n");

            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_Cooldown", Set_NewsDept_Cooldown_Array[0], Set_NewsDept_Cooldown_Array[1], Set_NewsDept_Cooldown_Array[2], "Set Monitoring CD", "Monitoring - Set Monitoring Cooldown. \nDefault value:" + Set_NewsDept_Cooldown_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RewardPointPF", Set_NewsDept_RewardPointPF_Array[0], Set_NewsDept_RewardPointPF_Array[1], Set_NewsDept_RewardPointPF_Array[2], "Set Monitoring Reward pt per floor", "Monitoring - Set Monitoring Reward point per floor. \nDefault value:" + Set_NewsDept_RewardPointPF_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RepBonus", Set_NewsDept_RepBonus_Array[0], Set_NewsDept_RepBonus_Array[1], Set_NewsDept_RepBonus_Array[2], "Set Monitoring Rep Bonus", "Monitoring - Set Monitoring Rep Bonus. \nDefault value:" + Set_NewsDept_RepBonus_Array[0]);
            // Navigation - scanner
            this.ModData.AddConfigValue("Navigation", "about_HWS", "[ <color=#FFFEC1>Navigation - Scanner</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ScanRange", Set_HWSDept_ScanRange_Array[0], Set_HWSDept_ScanRange_Array[1], Set_HWSDept_ScanRange_Array[2], "Set Scanner Range", "Scanner - Set range of scanner. \nDefault value:" + Set_HWSDept_ScanRange_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_EnemyPointPF", Set_HWSDept_EnemyPointPF_Array[0], Set_HWSDept_EnemyPointPF_Array[1], Set_HWSDept_EnemyPointPF_Array[2], "Set Enemy Point", "Scanner - Set Enemy Point per floor subtraction point. \nDefault value:" + Set_HWSDept_EnemyPointPF_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemPointPM", Set_HWSDept_ItemPointPM_Array[0], Set_HWSDept_ItemPointPM_Array[1], Set_HWSDept_ItemPointPM_Array[2], "Set Items Point Per Mission", "Scanner - Set Item Point Per Mission. \nDefault value:" + Set_HWSDept_ItemPointPM_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemLevel", Set_HWSDept_ItemLevel_Array[0], Set_HWSDept_ItemLevel_Array[1], Set_HWSDept_ItemLevel_Array[2], "Set Items Level", "Scanner - Set Additional Item level on Mission. \nDefault value:" + Set_HWSDept_ItemLevel_Array[0]);
            // Navigation - proxy company
            this.ModData.AddConfigValue("Navigation", "about_PRCO", "[ <color=#FFFEC1>Navigation - Proxy Company</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_ProdSpeed_Perc", Set_PRCODept_ProdSpeed_Perc_Array[0], Set_PRCODept_ProdSpeed_Perc_Array[1], Set_PRCODept_ProdSpeed_Perc_Array[2], "Set Proxy Production Speed %", "Proxy Company - Set Production Speed Multiplier %. \nDefault value:" + Set_PRCODept_ProdSpeed_Perc_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_MissMult_Perc", Set_PRCODept_MissMult_Perc_Array[0], Set_PRCODept_MissMult_Perc_Array[1], Set_PRCODept_MissMult_Perc_Array[2], "Set Proxy Mission Mult %", "Proxy Company - Set Mission Result Multiplier %. \nDefault value:" + Set_PRCODept_MissMult_Perc_Array[0]);

            this.ModData.AddConfigHeader("Engineering", "Engineering");
            // Engineering - Weaponry
            this.ModData.AddConfigValue("Engineering", "about_WPST", "[ <color=#FFFEC1>Engineering - Weaponry</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_CostReduce", Set_WPSTDept_CostReduce_Array[0], Set_WPSTDept_CostReduce_Array[1], Set_WPSTDept_CostReduce_Array[2], "Set Cost Reduction", "Weaponry - Set Cost Reduction. \nDefault value:" + Set_WPSTDept_CostReduce_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_ProjSlot", Set_WPSTDept_ProjSlot_Array[0], Set_WPSTDept_ProjSlot_Array[1], Set_WPSTDept_ProjSlot_Array[2], "Set Project Slot", "Weaponry - Set Project Slot #. \nDefault value:" + Set_WPSTDept_ProjSlot_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_UpgradeCap_Perc", Set_WPSTDept_UpgradeCap_Perc_Array[0], Set_WPSTDept_UpgradeCap_Perc_Array[1], Set_WPSTDept_UpgradeCap_Perc_Array[2], "Set Project Upgrade Cap %", "Weaponry - Set Project Upgrade Cap Multiplier %. \nDefault value:" + Set_WPSTDept_UpgradeCap_Perc_Array[0]);
            // Engineering - Arsenal
            this.ModData.AddConfigValue("Engineering", "about_ARMST", "[ <color=#FFFEC1>Engineering - Arsenal</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_CostReduce", Set_ARMSTDept_CostReduce_Array[0], Set_ARMSTDept_CostReduce_Array[1], Set_ARMSTDept_CostReduce_Array[2], "Set Cost Reduction", "Arsenal - Set Cost Reduction. \nDefault value:" + Set_ARMSTDept_CostReduce_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_ProjSlot", Set_ARMSTDept_ProjSlot_Array[0], Set_ARMSTDept_ProjSlot_Array[1], Set_ARMSTDept_ProjSlot_Array[2], "Set Project Slot", "Arsenal - Set Project Slot #. \nDefault value:" + Set_ARMSTDept_ProjSlot_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_UpgradeCap_Perc", Set_ARMSTDept_UpgradeCap_Perc_Array[0], Set_ARMSTDept_UpgradeCap_Perc_Array[1], Set_ARMSTDept_UpgradeCap_Perc_Array[2], "Set Project Upgrade Cap %", "Arsenal - Set Project Upgrade Cap Multiplier %. \nDefault value:" + Set_ARMSTDept_UpgradeCap_Perc_Array[0]);
            // Engineering - Augmetics
            this.ModData.AddConfigValue("Engineering", "about_AGST", "[ <color=#FFFEC1>Engineering - Augmetics</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_AGSTDept_ImpGainOnAmp_Perc", Set_AGSTDept_ImpGainOnAmp_Perc_Array[0], Set_AGSTDept_ImpGainOnAmp_Perc_Array[1], Set_AGSTDept_ImpGainOnAmp_Perc_Array[2], "Set Implant Gain on Amp %", "Augmetics - Set Implant Gain on Amp Percentage. \nDefault value:" + Set_AGSTDept_ImpGainOnAmp_Perc_Array[0]);


            this.ModData.AddConfigHeader("Research", "Research");
            // Research - Classes
            this.ModData.AddConfigValue("Research", "about_MEMDF", "[ <color=#FFFEC1>Research - Classes</color> ]\n");
            this.ModData.AddConfigValue("Research", "Set_MEMDFDept_ClassSlot", Set_MEMDFDept_ClassSlot_Array[0], Set_MEMDFDept_ClassSlot_Array[1], Set_MEMDFDept_ClassSlot_Array[2], "Set Project Slot", "Classes - Set Project Slot #. \nDefault value:" + Set_MEMDFDept_ClassSlot_Array[0]);
            // Research - Pacts
            this.ModData.AddConfigValue("Research", "about_MORANL", "[ <color=#FFFEC1>Research - Pacts</color> ]\n");
            this.ModData.AddConfigValue("Research", "Set_MORANLDept_PactUpgrade_Power", Set_MORANLDept_PactUpgrade_Power_Array[0], Set_MORANLDept_PactUpgrade_Power_Array[1], Set_MORANLDept_PactUpgrade_Power_Array[2], "Set Pact Upgrade Essence", "Pact - Bonus additional Essence during pact Upgrade. \nDefault value:" + Set_MORANLDept_PactUpgrade_Power_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_MORANLDept_PactUpgrade_Stability", Set_MORANLDept_PactUpgrade_Stability_Array[0], Set_MORANLDept_PactUpgrade_Stability_Array[1], Set_MORANLDept_PactUpgrade_Stability_Array[2], "Set Pact Upgrade Stability", "Pact - Bonus additional Stability during pact Upgrade. \nDefault value:" + Set_MORANLDept_PactUpgrade_Stability_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_MORANLDept_Quasi_Drop_Perc", Set_MORANLDept_Quasi_Drop_Perc_Array[0], Set_MORANLDept_Quasi_Drop_Perc_Array[1], Set_MORANLDept_Quasi_Drop_Perc_Array[2], "Set % Additional Quasi Drop", "Pact - Bonus % to drop quasi material from 1 already amputated body part from quasi upon kill. \nDefault value:" + Set_MORANLDept_Quasi_Drop_Perc_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_MORANLDept_Pact_Discount_Perc", Set_MORANLDept_Pact_Discount_Perc_Array[0], Set_MORANLDept_Pact_Discount_Perc_Array[1], Set_MORANLDept_Pact_Discount_Perc_Array[2], "Set % Pact Cost Discount", "Pact - Reduced cost for pact use. \nDefault value:" + Set_MORANLDept_Pact_Discount_Perc_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_MORANLDept_Pact_Recovery", Set_MORANLDept_Pact_Recovery_Array[0], Set_MORANLDept_Pact_Recovery_Array[1], Set_MORANLDept_Pact_Recovery_Array[2], "Set Pact Bane Recovery", "Pact - Bane Reduction per mission. \nDefault value:" + Set_MORANLDept_Pact_Recovery_Array[0]);


            // Research - Travel
            this.ModData.AddConfigValue("Research", "about_BRENG", "[ <color=#FFFEC1>Research - Travel</color> ]\n");

            this.ModData.AddConfigValue("Research", "Set_BRENGDept_Cooldown_Two", Set_BRENGDept_Cooldown_Two_Array[0], Set_BRENGDept_Cooldown_Two_Array[1], Set_BRENGDept_Cooldown_Two_Array[2], "Set Bramfatura Travel CD", "Travel - Set Bramfatura Travel Cooldown. \nDefault value:" + Set_BRENGDept_Cooldown_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_TimeLimit_Two", Set_BRENGDept_TimeLimit_Two_Array[0], Set_BRENGDept_TimeLimit_Two_Array[1], Set_BRENGDept_TimeLimit_Two_Array[2], "Set Bramfatura Stay Duration", "Travel - Set Bramfatura Stay Duration. \nDefault value:" + Set_BRENGDept_TimeLimit_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentPortalDistance_Two", Set_BRENGDept_DescentPortalDistance_Two_Array[0], Set_BRENGDept_DescentPortalDistance_Two_Array[1], Set_BRENGDept_DescentPortalDistance_Two_Array[2], "Set Descent Portal Distance", "Travel - Set Bramfatura Descent Mission Portal Spawn Distance. \nDefault value:" + Set_BRENGDept_DescentPortalDistance_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentStartFloor_Two", Set_BRENGDept_DescentStartFloor_Two_Array[0], Set_BRENGDept_DescentStartFloor_Two_Array[1], Set_BRENGDept_DescentStartFloor_Two_Array[2], "Set Descent Starting Floor #", "Travel - Set Bramfatura Descent Mission Starting Floor #. \nDefault value:" + Set_BRENGDept_DescentStartFloor_Two_Array[0]);



            this.ModData.AddConfigHeader("Hanger", "Hanger");
            // Hanger - Capsule
            this.ModData.AddConfigValue("Hanger", "about_AUCAP", "[ <color=#FFFEC1>Hanger - Capsule</color> ]\n");

            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Cooldown", Set_AUCAPDept_Cooldown_Array[0], Set_AUCAPDept_Cooldown_Array[1], Set_AUCAPDept_Cooldown_Array[2], "Set Capsule CD", "Hanger - Set Capsule Cooldown.");
            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Custom_RowValue", Set_AUCAPDept_Custom_RowValue_Array[0], Set_AUCAPDept_Custom_RowValue_Array[1], Set_AUCAPDept_Custom_RowValue_Array[2], "Set Capsule Row", "Hanger - Set Capsule Row. \nDefault value:" + Set_AUCAPDept_Custom_RowValue_Array[0]);
            // Hanger - Shuttle
            this.ModData.AddConfigValue("Hanger", "about_CGSHST", "[ <color=#FFFEC1>Hanger - Shuttle</color> ]\n");
            this.ModData.AddConfigValue("Hanger", "Set_CGSHSTDept_RowValue", Set_CGSHSTDept_RowValue_Array[0], Set_CGSHSTDept_RowValue_Array[1], Set_CGSHSTDept_RowValue_Array[2], "Set Shuttle Row", "Shuttle - Set Shuttle Row. \nDefault value:" + Set_CGSHSTDept_RowValue_Array[0]);
            // Hanger - Trade
            this.ModData.AddConfigValue("Hanger", "about_TRDSH", "[ <color=#FFFEC1>Hanger - Trade</color> ]\n");
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Shuttle_Cargo_Rows", Set_TRDSHDept_Shuttle_Cargo_Rows_Array[0], Set_TRDSHDept_Shuttle_Cargo_Rows_Array[1], Set_TRDSHDept_Shuttle_Cargo_Rows_Array[2], "Set Trade Shuttle Cargo Row", "Trade - Cargo Row For Trade Shuttle. \nDefault value:" + Set_TRDSHDept_Shuttle_Cargo_Rows_Array[0]);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Shuttle_Move_Speed", Set_TRDSHDept_Shuttle_Move_Speed_Array[0], Set_TRDSHDept_Shuttle_Move_Speed_Array[1], Set_TRDSHDept_Shuttle_Move_Speed_Array[2], "Set Trade Shuttle Speed", "Trade - Trade speed For Trade Shuttle. \nDefault value:" + Set_TRDSHDept_Shuttle_Move_Speed_Array[0]);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Reputation_Value_Perc", Set_TRDSHDept_Reputation_Value_Perc_Array[0], Set_TRDSHDept_Reputation_Value_Perc_Array[1], Set_TRDSHDept_Reputation_Value_Perc_Array[2], "Set Rep Ratio gain for Trading", "Trade - Reputation Gain ratio for Trading. \nDefault value:" + Set_TRDSHDept_Reputation_Value_Perc_Array[0]);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Unsupported_Items_Value_Perc", Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[0], Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[1], Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[2], "Set Unneeded Goods Price %", "Trade - % of Unneeded Goods Price. \nDefault value:" + Set_TRDSHDept_Unsupported_Items_Value_Perc_Array[0]);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Value_Of_Shuttle_Items_Perc", Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[0], Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[1], Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[2], "Increased Shipment value %", "Trade - % increase of shipment value. \nDefault value:" + Set_TRDSHDept_Value_Of_Shuttle_Items_Perc_Array[0]);



            //Data.MagnumDefaultValues.TryGetValue(MagnumParameter.TRDSHShuttleRestoreSpeed, out temp_result);

            //this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Cooldown", (int)temp_result, 1, (int)temp_result, "Set Trade Shuttle CD", "Trade - Set Trade Shuttle Cooldown.");

            //this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_TravelSpeed", (int)temp_result, 1, (int)temp_result, "Set Trade Shuttle MoveTime", "Trade - Set Trade Shuttle Delivery Time.");



            this.ModData.AddConfigHeader("Cloning", "Cloning");
            // Cloning - Genome
            this.ModData.AddConfigValue("Cloning", "about_GNED", "[ <color=#FFFEC1>Cloning - Genome</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "Set_GNEDDept_CostReduce", Set_GNEDDept_CostReduce_Array[0], Set_GNEDDept_CostReduce_Array[1], Set_GNEDDept_CostReduce_Array[2], "Set Cost Reduction", "Cloning - Set Clone Upgrade Cost Reduction. \nDefault value:" + Set_GNEDDept_CostReduce_Array[0]);
            // Cloning - Training
            this.ModData.AddConfigValue("Cloning", "about_TRCN", "[ <color=#FFFEC1>Cloning - Training</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "about_TRCN2", "Nothing to improve.\n");
            // Cloning - Capacitor
            this.ModData.AddConfigValue("Cloning", "about_BTEXC", "[ <color=#FFFEC1>Cloning - Capacitor</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "about_BTEXC2", "Nothing to improve.\n");

            this.ModData.AddConfigHeader("Supply", "Supply");
            // Supply - Conveyer
            this.ModData.AddConfigValue("Supply", "about_PRLN", "[ <color=#FFFEC1>Supply - Conveyer</color> ]\n");
            this.ModData.AddConfigValue("Supply", "about_PRLN2", "Nothing to improve. Production speed per item won't go below 1 hour per item.\n");
            // Supply - Scavengers
            this.ModData.AddConfigValue("Supply", "about_PUBG", "[ <color=#FFFEC1>Supply - Scavengers</color> ]\n");
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ResourcesValue", Set_PUBGDept_ResourcesValue_Array[0], Set_PUBGDept_ResourcesValue_Array[1], Set_PUBGDept_ResourcesValue_Array[2], "Set Resource Gain", "Scavengers - Set Resource Gain. \nDefault value:" + Set_PUBGDept_ResourcesValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_FoodMedsValue", Set_PUBGDept_FoodMedsValue_Array[0], Set_PUBGDept_FoodMedsValue_Array[1], Set_PUBGDept_FoodMedsValue_Array[2], "Set Food/Med Gain", "Scavengers - Set Food/Med Gain. \nDefault value:" + Set_PUBGDept_FoodMedsValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_AmmoGrenadesValue", Set_PUBGDept_AmmoGrenadesValue_Array[0], Set_PUBGDept_AmmoGrenadesValue_Array[1], Set_PUBGDept_AmmoGrenadesValue_Array[2], "Set Ammo/Grenade Gain", "Scavengers - Set Ammo/Grenade Gain. \nDefault value:" + Set_PUBGDept_AmmoGrenadesValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ArmorWeaponsValue", Set_PUBGDept_ArmorWeaponsValue_Array[0], Set_PUBGDept_ArmorWeaponsValue_Array[1], Set_PUBGDept_ArmorWeaponsValue_Array[2], "Set Gear Gain", "Scavengers - Set Weapon/Armor Gain. \nDefault value:" + Set_PUBGDept_ArmorWeaponsValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_Fridge_Store_Custom_RowValue", Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[0], Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[1], Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[2], "Set Fridge Row", "Scavengers - Set Fridge Row. \nDefault value:" + Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[0]);


            // Supply - Recycling
            this.ModData.AddConfigValue("Supply", "about_STCON", "[ <color=#FFFEC1>Supply - Recycling</color> ]\n");
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_DisaSpeed", Set_STCONDept_DisaSpeed_Array[0], Set_STCONDept_DisaSpeed_Array[1], Set_STCONDept_DisaSpeed_Array[2], "Set Disassembly Speed", "Recycling - Set Disassembly Speed. \nDefault value:" + Set_STCONDept_DisaSpeed_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_MoreComps", Set_STCONDept_MoreComps_Array[0], Set_STCONDept_MoreComps_Array[1], Set_STCONDept_MoreComps_Array[2], "Set More Resource Gain", "Recycling - Set More Resource Gain. (Disassembling 1 ammo will give +x gunpowder)\nDefault value:" + Set_STCONDept_MoreComps_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_AdditMDComp", Set_STCONDept_AdditMDComp_Array[0], Set_STCONDept_AdditMDComp_Array[1], Set_STCONDept_AdditMDComp_Array[2], "Set Extra Resource Gain", "Recycling - Set Extra Resource Gain. (Disassembling 1 ammo will give +x [random trash item])\nDefault value:" + Set_STCONDept_AdditMDComp_Array[0]);






            this.ModData.RegisterModConfigData(ModName);
        }

        // Token: 0x04000011 RID: 17
        private string ModName;

        // Token: 0x04000012 RID: 18
        public ModConfigData ModData;

    }
}
