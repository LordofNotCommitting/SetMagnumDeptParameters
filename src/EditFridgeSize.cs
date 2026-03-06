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
    [HarmonyPatch(typeof(MagnumCargoSystem), nameof(MagnumCargoSystem.Update))]
    public static class EditFridgeSize
    {
        static int Set_PUBGDept_Fridge_Store_Custom_RowValue = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_PUBGDept_Fridge_Store_Custom_RowValue", 1);
        static bool fridge_setup = false;

        public static void Postfix(MagnumCargo magnumCargo, MagnumProgression magnumSpaceship, SpaceTime spaceTime)
        {
            
            int FridgeInventoryRow = Set_PUBGDept_Fridge_Store_Custom_RowValue;

            if (!fridge_setup) {
                if (FridgeInventoryRow != magnumCargo.FridgeStorage.Height) {
                    List<BasePickupItem> list = new List<BasePickupItem>(magnumCargo.FridgeStorage.Items);
                    magnumCargo.FridgeStorage.RemoveAllItems();
                    magnumCargo.FridgeStorage.Resize(8, FridgeInventoryRow);
                    foreach (BasePickupItem item in list)
                    {
                        magnumCargo.FridgeStorage.TryPutItem(item, CellPosition.Zero, false, true);
                    }
                }

                fridge_setup = true;
            }
            


        }
    }
}
