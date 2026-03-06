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
    [HarmonyPatch(typeof(AutonomousCapsuleDepartment), nameof(AutonomousCapsuleDepartment.OnPerksUpdated))]
    public static class EditCapsuleSize
    {
        static int Set_AUCAPDept_Custom_RowValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_AUCAPDept_Custom_RowValue", 1);


        public static void Postfix(ref AutonomousCapsuleDepartment __instance)
        {
            int autonomousCapsuleInventorySize = __instance._magnumSpaceship.AutonomousCapsuleInventorySize;
            int autonomousCapsuleInventoryRow = Set_AUCAPDept_Custom_RowValue;

            List<BasePickupItem> list = new List<BasePickupItem>(__instance.CapsuleStorage.Items);
            __instance.CapsuleStorage.RemoveAllItems();
            __instance.CapsuleStorage.Resize(autonomousCapsuleInventorySize, autonomousCapsuleInventoryRow);
            foreach (BasePickupItem item in list)
            {
                __instance.CapsuleStorage.TryPutItem(item, CellPosition.Zero, false, true);
            }

        }
    }
}
