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
        // Token: 0x0600001D RID: 29 RVA: 0x00002840 File Offset: 0x00000A40



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
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.NDCooldownTimeReduce, out temp_result);
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_Cooldown", (int)temp_result, 1, (int)temp_result, "STRING:Set Monitoring CD", "STRING:Monitoring - Set Monitoring Cooldown");
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RewardPointPF", 0, 0, 1000, "STRING:Set Monitoring Reward pt per floor", "STRING:Monitoring - Set Monitoring Reward point per floor");
            this.ModData.AddConfigValue("Navigation", "Set_NewsDept_RepBonus", 0, 0, 100, "STRING:Set Monitoring Rep Bonus", "STRING:Monitoring - Set Monitoring Rep Bonus");
            // Navigation - scanner
            this.ModData.AddConfigValue("Navigation", "about_HWS", "STRING:[ <color=#FFFEC1>Navigation - Scanner</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ScanRange", 1, 1, 10, "STRING:Set Scanner Range", "STRING:Scanner - Set range of scanner.");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_EnemyPointPF", 0, -600, 0, "STRING:Set Enemy Point", "STRING:Scanner - Set Enemy Point per floor subtraction point.");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemPointPM", 0, 0, 2000, "STRING:Set Items Point Per Mission", "STRING:Scanner - Set Item Point Per Mission.");
            this.ModData.AddConfigValue("Navigation", "Set_HWSDept_ItemLevel", 0, 0, 10, "STRING:Set Items Level", "STRING:Scanner - Set Additional Item level on Mission.");
            // Navigation - proxy company
            this.ModData.AddConfigValue("Navigation", "about_PRCO", "STRING:[ <color=#FFFEC1>Navigation - Proxy Company</color> ]\n");
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_ProdSpeed_Perc", 100, 0, 1000, "STRING:Set Proxy Production Speed %", "STRING:Proxy Company - Set Production Speed Multiplier %.");
            this.ModData.AddConfigValue("Navigation", "Set_PRCODept_MissMult_Perc", 100, 0, 1000, "STRING:Set Proxy Mission Mult %", "STRING:Proxy Company - Set Mission Result Multiplier %.");

            this.ModData.AddConfigHeader("STRING:Engineering", "Engineering");
            // Engineering - Weaponry
            this.ModData.AddConfigValue("Engineering", "about_WPST", "STRING:[ <color=#FFFEC1>Engineering - Weaponry</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_CostReduce", 0, -20, 0, "STRING:Set Cost Reduction", "STRING:Weaponry - Set Cost Reduction.");
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_ProjSlot", 1, 1, 20, "STRING:Set Project Slot", "STRING:Weaponry - Set Project Slot #.");
            this.ModData.AddConfigValue("Engineering", "Set_WPSTDept_UpgradeCap_Perc", 0, 0, 1000, "STRING:Set Project Upgrade Cap %", "STRING:Weaponry - Set Project Upgrade Cap Multiplier %.");
            // Engineering - Arsenal
            this.ModData.AddConfigValue("Engineering", "about_ARMST", "STRING:[ <color=#FFFEC1>Engineering - Arsenal</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_CostReduce", 0, -20, 0, "STRING:Set Cost Reduction", "STRING:Arsenal - Set Cost Reduction.");
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_ProjSlot", 1, 1, 30, "STRING:Set Project Slot", "STRING:Arsenal - Set Project Slot #.");
            this.ModData.AddConfigValue("Engineering", "Set_ARMSTDept_UpgradeCap_Perc", 0, 0, 1000, "STRING:Set Project Upgrade Cap %", "STRING:Arsenal - Set Project Upgrade Cap Multiplier %.");
            // Engineering - Augmetics
            this.ModData.AddConfigValue("Engineering", "about_AGST", "STRING:[ <color=#FFFEC1>Engineering - Augmetics</color> ]\n");
            this.ModData.AddConfigValue("Engineering", "Set_AGSTDept_ImpGainOnAmp_Perc", 15, 15, 100, "STRING:Set Implant Gain on Amp %", "STRING:Augmetics - Set Implant Gain on Amp Percentage.");


            this.ModData.AddConfigHeader("STRING:Research", "Research");
            // Research - Classes
            this.ModData.AddConfigValue("Research", "about_MEMDF", "STRING:[ <color=#FFFEC1>Research - Classes</color> ]\n");
            this.ModData.AddConfigValue("Research", "Set_MEMDFDept_ClassSlot", 1, 1, 20, "STRING:Set Project Slot", "STRING:Classes - Set Project Slot #.");
            // Research - Pacts
            this.ModData.AddConfigValue("Research", "about_MORANL", "STRING:[ <color=#FFFEC1>Research - Pacts (In Proggress)</color> ]\n");
            this.ModData.AddConfigValue("Research", "about_MORANL2", "STRING:N/A\n");
            // Research - Travel
            this.ModData.AddConfigValue("Research", "about_BRENG", "STRING:[ <color=#FFFEC1>Research - Travel</color> ]\n");
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.BRENGCooldownDuration, out temp_result);
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_Cooldown", (int)temp_result, 1, (int)temp_result, "STRING:Set Bramfatura Travel CD", "STRING:Travel - Set Bramfatura Travel Cooldown.");
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_TimeLimit", 600, 600, 6000, "STRING:Set Bramfatura Stay Duration", "STRING:Travel - Set Bramfatura Stay Duration.");
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentPortalDistance", 32, 1, 32, "STRING:Set Descent Portal Distance", "STRING:Travel - Set Bramfatura Descent Mission Portal Spawn Distance.");
            this.ModData.AddConfigValue("Research", "Set_BRENGDept_DescentStartFloor", 1, 1, 40, "STRING:Set Descent Starting Floor #", "STRING:Travel - Set Bramfatura Descent Mission Starting Floor #.");

            this.ModData.AddConfigHeader("STRING:Hanger", "Hanger");
            // Hanger - Capsule
            this.ModData.AddConfigValue("Hanger", "about_AUCAP", "STRING:[ <color=#FFFEC1>Hanger - Capsule</color> ]\n");
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.AUCAPCapsuleRestoreSpeed, out temp_result);
            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Cooldown", (int)temp_result, 1, (int)temp_result, "STRING:Set Capsule CD", "STRING:Hanger - Set Capsule Cooldown.");
            this.ModData.AddConfigValue("Hanger", "Set_AUCAPDept_Custom_RowValue", 1, 1, 10, "STRING:Set Capsule Row", "STRING:Hanger - Set Capsule Row (default is 1).");
            // Hanger - Shuttle
            this.ModData.AddConfigValue("Hanger", "about_CGSHST", "STRING:[ <color=#FFFEC1>Hanger - Shuttle</color> ]\n");
            this.ModData.AddConfigValue("Hanger", "Set_CGSHSTDept_RowValue", 1, 1, 40, "STRING:Set Shuttle Row", "STRING:Shuttle - Set Shuttle Row.");
            // Hanger - Trade
            this.ModData.AddConfigValue("Hanger", "about_TRDSH", "STRING:[ <color=#FFFEC1>Hanger - Trade</color> ]\n");
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.TRDSHShuttleRestoreSpeed, out temp_result);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_Cooldown", (int)temp_result, 1, (int)temp_result, "STRING:Set Trade Shuttle CD", "STRING:Trade - Set Trade Shuttle Cooldown.");
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.TRDSHShuttleMoveSpeed, out temp_result);
            this.ModData.AddConfigValue("Hanger", "Set_TRDSHDept_TravelSpeed", (int)temp_result, 1, (int)temp_result, "STRING:Set Trade Shuttle MoveTime", "STRING:Trade - Set Trade Shuttle Delivery Time.");

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
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ResourcesValue", 1, -2, 10, "STRING:Set Resource Gain", "STRING:Scavengers - Set Resource Gain.");
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_FoodMedsValue", 1, -2, 10, "STRING:Set Food/Med Gain", "STRING:Scavengers - Set Food/Med Gain.");
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_AmmoGrenadesValue", 1, -2, 10, "STRING:Set Ammo/Grenade Gain", "STRING:Scavengers - Set Ammo/Grenade Gain.");
            this.ModData.AddConfigValue("Supply", "Set_PUBGDept_ArmorWeaponsValue", 1, -2, 10, "STRING:Set Gear Gain", "STRING:Scavengers - Set Weapon/Armor Gain.");
            // Supply - Recycling
            this.ModData.AddConfigValue("Supply", "about_STCON", "STRING:[ <color=#FFFEC1>Supply - Recycling</color> ]\n");
            Data.MagnumDefaultValues.TryGetValue(MagnumParameter.STCONDisassemblyItemsSpeed, out temp_result);
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_DisaSpeed", (int)temp_result, 1, (int)temp_result, "STRING:Set Disassembly Speed", "STRING:Recycling - Set Disassembly Speed.");
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_MoreComps", 0, -2, 20, "STRING:Set More Resource Gain", "STRING:Recycling - Set More Resource Gain. (Disassembling 1 ammo will give +x gunpowder)");
            this.ModData.AddConfigValue("Supply", "Set_STCONDept_AdditMDComp", 0, -2, 10, "STRING:Set Extra Resource Gain", "STRING:Recycling - Set Extra Resource Gain. (Disassembling 1 ammo will give +x [random trash item])");



            this.ModData.RegisterModConfigData(ModName);
        }

        // Token: 0x04000011 RID: 17
        private string ModName;

        // Token: 0x04000012 RID: 18
        public ModConfigData ModData;

    }
}
