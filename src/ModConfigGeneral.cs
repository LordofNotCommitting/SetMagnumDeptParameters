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
        public static int[] Set_NewsDept_Cooldown_Array = new int[] { 168, 1, 168 };
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
        public static int[] Set_WPSTDept_UpgradeCap_Perc_Array = new int[] { 0, 0, 1000 };

        public static int[] Set_ARMSTDept_CostReduce_Array = new int[] { 0, -600, 0 };
        public static int[] Set_ARMSTDept_ProjSlot_Array = new int[] { 4, 4, 30 };
        public static int[] Set_ARMSTDept_UpgradeCap_Perc_Array = new int[] { 0, 0, 1000 };

        public static int[] Set_AGSTDept_ImpGainOnAmp_Perc_Array = new int[] { 5, 5, 100 };

        public static int[] Set_MEMDFDept_ClassSlot_Array = new int[] { 2, 2, 20 };

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




        public ModConfigGeneral(string ModName, string ConfigPath)
        {

            float temp_result = 0f;
            this.ModName = ModName;
            this.ModData = new ModConfigData(ConfigPath);
            this.ModData.AddConfigHeader("STRING:General Settings", "general");
            this.ModData.AddConfigValue("general", "about_final", "STRING:<color=#f51b1b>The game must be restarted after setting then saving this config to take effect.</color>\n\n");

            this.ModData.AddConfigValue("general", "about_final2", "STRING:The stat here are <color=#f51b1b>before other sub-dept bonus</color> are being applied to.\n\n");

            this.ModData.AddConfigHeader("STRING:Navigation", "Navigation");
            // Navigation - monitoring
            this.ModData.AddConfigValue("Navigation", "about_ND", "STRING:[ <color=#FFFEC1>Navigation - Monitoring</color> ]\n");

            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_Cooldown", Set_NewsDept_Cooldown_Array[0], Set_NewsDept_Cooldown_Array[1], Set_NewsDept_Cooldown_Array[2], "STRING:Set Monitoring CD", "STRING:Monitoring - Set Monitoring Cooldown. \nDefault value:" + Set_NewsDept_Cooldown_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RewardPointPF", Set_NewsDept_RewardPointPF_Array[0], Set_NewsDept_RewardPointPF_Array[1], Set_NewsDept_RewardPointPF_Array[2], "STRING:Set Monitoring Reward pt per floor", "STRING:Monitoring - Set Monitoring Reward point per floor. \nDefault value:" + Set_NewsDept_RewardPointPF_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RepBonus", Set_NewsDept_RepBonus_Array[0], Set_NewsDept_RepBonus_Array[1], Set_NewsDept_RepBonus_Array[2], "STRING:Set Monitoring Rep Bonus", "STRING:Monitoring - Set Monitoring Rep Bonus. \nDefault value:" + Set_NewsDept_RepBonus_Array[0]);
            // Navigation - scanner
            this.ModData.AddConfigValue("Navigation", "about_HWS", "STRING:[ <color=#FFFEC1>Navigation - Scanner</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ScanRange", Set_HWSDept_ScanRange_Array[0], Set_HWSDept_ScanRange_Array[1], Set_HWSDept_ScanRange_Array[2], "STRING:Set Scanner Range", "STRING:Scanner - Set range of scanner. \nDefault value:" + Set_HWSDept_ScanRange_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_EnemyPointPF", Set_HWSDept_EnemyPointPF_Array[0], Set_HWSDept_EnemyPointPF_Array[1], Set_HWSDept_EnemyPointPF_Array[2], "STRING:Set Enemy Point", "STRING:Scanner - Set Enemy Point per floor subtraction point. \nDefault value:" + Set_HWSDept_EnemyPointPF_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemPointPM", Set_HWSDept_ItemPointPM_Array[0], Set_HWSDept_ItemPointPM_Array[1], Set_HWSDept_ItemPointPM_Array[2], "STRING:Set Items Point Per Mission", "STRING:Scanner - Set Item Point Per Mission. \nDefault value:" + Set_HWSDept_ItemPointPM_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemLevel", Set_HWSDept_ItemLevel_Array[0], Set_HWSDept_ItemLevel_Array[1], Set_HWSDept_ItemLevel_Array[2], "STRING:Set Items Level", "STRING:Scanner - Set Additional Item level on Mission. \nDefault value:" + Set_HWSDept_ItemLevel_Array[0]);
            // Navigation - proxy company
            this.ModData.AddConfigValue("Navigation", "about_PRCO", "STRING:[ <color=#FFFEC1>Navigation - Proxy Company</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_ProdSpeed_Perc", Set_PRCODept_ProdSpeed_Perc_Array[0], Set_PRCODept_ProdSpeed_Perc_Array[1], Set_PRCODept_ProdSpeed_Perc_Array[2], "STRING:Set Proxy Production Speed %", "STRING:Proxy Company - Set Production Speed Multiplier %. \nDefault value:" + Set_PRCODept_ProdSpeed_Perc_Array[0]);
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_MissMult_Perc", Set_PRCODept_MissMult_Perc_Array[0], Set_PRCODept_MissMult_Perc_Array[1], Set_PRCODept_MissMult_Perc_Array[2], "STRING:Set Proxy Mission Mult %", "STRING:Proxy Company - Set Mission Result Multiplier %. \nDefault value:" + Set_PRCODept_MissMult_Perc_Array[0]);

            this.ModData.AddConfigHeader("STRING:Engineering", "Engineering");
            // Engineering - Weaponry
            this.ModData.AddConfigValue("Engineering", "about_WPST", "STRING:[ <color=#FFFEC1>Engineering - Weaponry</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_CostReduce", Set_WPSTDept_CostReduce_Array[0], Set_WPSTDept_CostReduce_Array[1], Set_WPSTDept_CostReduce_Array[2], "STRING:Set Cost Reduction", "STRING:Weaponry - Set Cost Reduction. \nDefault value:" + Set_WPSTDept_CostReduce_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_ProjSlot", Set_WPSTDept_ProjSlot_Array[0], Set_WPSTDept_ProjSlot_Array[1], Set_WPSTDept_ProjSlot_Array[2], "STRING:Set Project Slot", "STRING:Weaponry - Set Project Slot #. \nDefault value:" + Set_WPSTDept_ProjSlot_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_UpgradeCap_Perc", Set_WPSTDept_UpgradeCap_Perc_Array[0], Set_WPSTDept_UpgradeCap_Perc_Array[1], Set_WPSTDept_UpgradeCap_Perc_Array[2], "STRING:Set Project Upgrade Cap %", "STRING:Weaponry - Set Project Upgrade Cap Multiplier %. \nDefault value:" + Set_WPSTDept_UpgradeCap_Perc_Array[0]);
            // Engineering - Arsenal
            this.ModData.AddConfigValue("Engineering", "about_ARMST", "STRING:[ <color=#FFFEC1>Engineering - Arsenal</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_CostReduce", Set_ARMSTDept_CostReduce_Array[0], Set_ARMSTDept_CostReduce_Array[1], Set_ARMSTDept_CostReduce_Array[2], "STRING:Set Cost Reduction", "STRING:Arsenal - Set Cost Reduction. \nDefault value:" + Set_ARMSTDept_CostReduce_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_ProjSlot", Set_ARMSTDept_ProjSlot_Array[0], Set_ARMSTDept_ProjSlot_Array[1], Set_ARMSTDept_ProjSlot_Array[2], "STRING:Set Project Slot", "STRING:Arsenal - Set Project Slot #. \nDefault value:" + Set_ARMSTDept_ProjSlot_Array[0]);
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_UpgradeCap_Perc", Set_ARMSTDept_UpgradeCap_Perc_Array[0], Set_ARMSTDept_UpgradeCap_Perc_Array[1], Set_ARMSTDept_UpgradeCap_Perc_Array[2], "STRING:Set Project Upgrade Cap %", "STRING:Arsenal - Set Project Upgrade Cap Multiplier %. \nDefault value:" + Set_ARMSTDept_UpgradeCap_Perc_Array[0]);
            // Engineering - Augmetics
            this.ModData.AddConfigValue("Engineering", "about_AGST", "STRING:[ <color=#FFFEC1>Engineering - Augmetics</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_AGSTDept_ImpGainOnAmp_Perc", Set_AGSTDept_ImpGainOnAmp_Perc_Array[0], Set_AGSTDept_ImpGainOnAmp_Perc_Array[1], Set_AGSTDept_ImpGainOnAmp_Perc_Array[2], "STRING:Set Implant Gain on Amp %", "STRING:Augmetics - Set Implant Gain on Amp Percentage. \nDefault value:" + Set_AGSTDept_ImpGainOnAmp_Perc_Array[0]);


            this.ModData.AddConfigHeader("STRING:Research", "Research");
            // Research - Classes
            this.ModData.AddConfigValue("Research", "about_MEMDF", "STRING:[ <color=#FFFEC1>Research - Classes</color> ]\n");
            this.ModData.AddConfigValue("Research", "Set_MEMDFDept_ClassSlot", Set_MEMDFDept_ClassSlot_Array[0], Set_MEMDFDept_ClassSlot_Array[1], Set_MEMDFDept_ClassSlot_Array[2], "STRING:Set Project Slot", "STRING:Classes - Set Project Slot #. \nDefault value:" + Set_MEMDFDept_ClassSlot_Array[0]);
            // Research - Pacts
            this.ModData.AddConfigValue("Research", "about_MORANL", "STRING:[ <color=#FFFEC1>Research - Pacts (In Proggress)</color> ]\n");
            this.ModData.AddConfigValue("Research", "about_MORANL2", "STRING:N/A\n");
            // Research - Travel
            this.ModData.AddConfigValue("Research", "about_BRENG", "STRING:[ <color=#FFFEC1>Research - Travel</color> ]\n");

            this.ModData.AddConfigValue("Research", "Set_BRENGDept_Cooldown_Two", Set_BRENGDept_Cooldown_Two_Array[0], Set_BRENGDept_Cooldown_Two_Array[1], Set_BRENGDept_Cooldown_Two_Array[2], "STRING:Set Bramfatura Travel CD", "STRING:Travel - Set Bramfatura Travel Cooldown. \nDefault value:" + Set_BRENGDept_Cooldown_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_TimeLimit_Two", Set_BRENGDept_TimeLimit_Two_Array[0], Set_BRENGDept_TimeLimit_Two_Array[1], Set_BRENGDept_TimeLimit_Two_Array[2], "STRING:Set Bramfatura Stay Duration", "STRING:Travel - Set Bramfatura Stay Duration. \nDefault value:" + Set_BRENGDept_TimeLimit_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentPortalDistance_Two", Set_BRENGDept_DescentPortalDistance_Two_Array[0], Set_BRENGDept_DescentPortalDistance_Two_Array[1], Set_BRENGDept_DescentPortalDistance_Two_Array[2], "STRING:Set Descent Portal Distance", "STRING:Travel - Set Bramfatura Descent Mission Portal Spawn Distance. \nDefault value:" + Set_BRENGDept_DescentPortalDistance_Two_Array[0]);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentStartFloor_Two", Set_BRENGDept_DescentStartFloor_Two_Array[0], Set_BRENGDept_DescentStartFloor_Two_Array[1], Set_BRENGDept_DescentStartFloor_Two_Array[2], "STRING:Set Descent Starting Floor #", "STRING:Travel - Set Bramfatura Descent Mission Starting Floor #. \nDefault value:" + Set_BRENGDept_DescentStartFloor_Two_Array[0]);



            this.ModData.AddConfigHeader("STRING:Hanger", "Hanger");
            // Hanger - Capsule
            this.ModData.AddConfigValue("Hanger", "about_AUCAP", "STRING:[ <color=#FFFEC1>Hanger - Capsule</color> ]\n");

            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Cooldown", Set_AUCAPDept_Cooldown_Array[0], Set_AUCAPDept_Cooldown_Array[1], Set_AUCAPDept_Cooldown_Array[2], "STRING:Set Capsule CD", "STRING:Hanger - Set Capsule Cooldown.");
            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Custom_RowValue", Set_AUCAPDept_Custom_RowValue_Array[0], Set_AUCAPDept_Custom_RowValue_Array[1], Set_AUCAPDept_Custom_RowValue_Array[2], "STRING:Set Capsule Row", "STRING:Hanger - Set Capsule Row. \nDefault value:" + Set_AUCAPDept_Custom_RowValue_Array[0]);
            // Hanger - Shuttle
            this.ModData.AddConfigValue("Hanger", "about_CGSHST", "STRING:[ <color=#FFFEC1>Hanger - Shuttle</color> ]\n");
            this.ModData.AddConfigValue("Hanger", "Set_CGSHSTDept_RowValue", Set_CGSHSTDept_RowValue_Array[0], Set_CGSHSTDept_RowValue_Array[1], Set_CGSHSTDept_RowValue_Array[2], "STRING:Set Shuttle Row", "STRING:Shuttle - Set Shuttle Row. \nDefault value:" + Set_CGSHSTDept_RowValue_Array[0]);
            // Hanger - Trade
            this.ModData.AddConfigValue("Hanger", "about_TRDSH", "STRING:[ <color=#FFFEC1>Hanger - Trade</color> ]\n");

            this.ModData.AddConfigValue("Hanger", "about_TRDSH2", "STRING:Temporarily disabled it to make it beta compatible.\n");
            //Data.MagnumDefaultValues.TryGetValue(MagnumParameter.TRDSHShuttleRestoreSpeed, out temp_result);

            temp_result = 24;
            //this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Cooldown", (int)temp_result, 1, (int)temp_result, "STRING:Set Trade Shuttle CD", "STRING:Trade - Set Trade Shuttle Cooldown.");

            temp_result = 96;
            //this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_TravelSpeed", (int)temp_result, 1, (int)temp_result, "STRING:Set Trade Shuttle MoveTime", "STRING:Trade - Set Trade Shuttle Delivery Time.");



            this.ModData.AddConfigHeader("STRING:Cloning", "Cloning");
            // Cloning - Genome
            this.ModData.AddConfigValue("Cloning", "about_GNED", "STRING:[ <color=#FFFEC1>Cloning - Genome</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "about_GNED2", "STRING:Nothing to improve.\n");
            // Cloning - Training
            this.ModData.AddConfigValue("Cloning", "about_TRCN", "STRING:[ <color=#FFFEC1>Cloning - Training</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "about_TRCN2", "STRING:Nothing to improve.\n");
            // Cloning - Capacitor
            this.ModData.AddConfigValue("Cloning", "about_BTEXC", "STRING:[ <color=#FFFEC1>Cloning - Capacitor</color> ]\n");
            this.ModData.AddConfigValue("Cloning", "about_BTEXC2", "STRING:Nothing to improve.\n");

            this.ModData.AddConfigHeader("STRING:Supply", "Supply");
            // Supply - Conveyer
            this.ModData.AddConfigValue("Supply", "about_PRLN", "STRING:[ <color=#FFFEC1>Supply - Conveyer</color> ]\n");
            this.ModData.AddConfigValue("Supply", "about_PRLN2", "STRING:Nothing to improve. Production speed per item won't go below 1 hour per item.\n");
            // Supply - Scavengers
            this.ModData.AddConfigValue("Supply", "about_PUBG", "STRING:[ <color=#FFFEC1>Supply - Scavengers</color> ]\n");
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ResourcesValue", Set_PUBGDept_ResourcesValue_Array[0], Set_PUBGDept_ResourcesValue_Array[1], Set_PUBGDept_ResourcesValue_Array[2], "STRING:Set Resource Gain", "STRING:Scavengers - Set Resource Gain. \nDefault value:" + Set_PUBGDept_ResourcesValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_FoodMedsValue", Set_PUBGDept_FoodMedsValue_Array[0], Set_PUBGDept_FoodMedsValue_Array[1], Set_PUBGDept_FoodMedsValue_Array[2], "STRING:Set Food/Med Gain", "STRING:Scavengers - Set Food/Med Gain. \nDefault value:" + Set_PUBGDept_FoodMedsValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_AmmoGrenadesValue", Set_PUBGDept_AmmoGrenadesValue_Array[0], Set_PUBGDept_AmmoGrenadesValue_Array[1], Set_PUBGDept_AmmoGrenadesValue_Array[2], "STRING:Set Ammo/Grenade Gain", "STRING:Scavengers - Set Ammo/Grenade Gain. \nDefault value:" + Set_PUBGDept_AmmoGrenadesValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ArmorWeaponsValue", Set_PUBGDept_ArmorWeaponsValue_Array[0], Set_PUBGDept_ArmorWeaponsValue_Array[1], Set_PUBGDept_ArmorWeaponsValue_Array[2], "STRING:Set Gear Gain", "STRING:Scavengers - Set Weapon/Armor Gain. \nDefault value:" + Set_PUBGDept_ArmorWeaponsValue_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_Fridge_Store_Custom_RowValue", Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[0], Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[1], Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[2], "STRING:Set Fridge Row", "STRING:Scavengers - Set Fridge Row. \nDefault value:" + Set_PUBGDept_Fridge_Store_Custom_RowValue_Array[0]);


            // Supply - Recycling
            this.ModData.AddConfigValue("Supply", "about_STCON", "STRING:[ <color=#FFFEC1>Supply - Recycling</color> ]\n");
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_DisaSpeed", Set_STCONDept_DisaSpeed_Array[0], Set_STCONDept_DisaSpeed_Array[1], Set_STCONDept_DisaSpeed_Array[2], "STRING:Set Disassembly Speed", "STRING:Recycling - Set Disassembly Speed. \nDefault value:" + Set_STCONDept_DisaSpeed_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_MoreComps", Set_STCONDept_MoreComps_Array[0], Set_STCONDept_MoreComps_Array[1], Set_STCONDept_MoreComps_Array[2], "STRING:Set More Resource Gain", "STRING:Recycling - Set More Resource Gain. (Disassembling 1 ammo will give +x gunpowder)\nDefault value:" + Set_STCONDept_MoreComps_Array[0]);
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_AdditMDComp", Set_STCONDept_AdditMDComp_Array[0], Set_STCONDept_AdditMDComp_Array[1], Set_STCONDept_AdditMDComp_Array[2], "STRING:Set Extra Resource Gain", "STRING:Recycling - Set Extra Resource Gain. (Disassembling 1 ammo will give +x [random trash item])\nDefault value:" + Set_STCONDept_AdditMDComp_Array[0]);






            this.ModData.RegisterModConfigData(ModName);
        }

        // Token: 0x04000011 RID: 17
        private string ModName;

        // Token: 0x04000012 RID: 18
        public ModConfigData ModData;

    }
}
