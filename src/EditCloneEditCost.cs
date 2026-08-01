using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

namespace SetMagnumDeptParameters
{
    [HarmonyPatch(typeof(MagnumProject), nameof(MagnumProject.InitRecord))]
    public static class EditCloneEditCost
    {
        static int Set_GNEDDept_CostReduce = Plugin.ConfigGeneral.ModData.GetConfigValue<int>("Set_GNEDDept_CostReduce", ModConfigGeneral.Set_GNEDDept_CostReduce_Array[0]);
        //static bool clone_cost_setup = false;


        public static void EnforceValueCap()
        {
            Set_GNEDDept_CostReduce = Math.Min(Set_GNEDDept_CostReduce, ModConfigGeneral.Set_GNEDDept_CostReduce_Array[2]);
        }

        public static bool Prefix()
        {
            //only do this when not default val
            if (Set_GNEDDept_CostReduce != ModConfigGeneral.Set_GNEDDept_CostReduce_Array[0]) {
                //ConfigRecordCollection<MercenaryProfileRecord> temp_merc_list = Data.MercenaryProfiles;
                List<string> temp_merc_IDlist = Data.MercenaryProfiles.Ids.ToList();
                foreach (string temp_merc_ID in temp_merc_IDlist)
                {
                    //Plugin.Logger.Log(temp_merc_ID);
                    MercenaryProfileRecord mercenaryProfileRecord = Data.MercenaryProfiles.GetRecord(temp_merc_ID, true).Clone(temp_merc_ID);
                    if (mercenaryProfileRecord.ModifyStartCost != Set_GNEDDept_CostReduce)
                    {
                        mercenaryProfileRecord.ModifyStartCost = Set_GNEDDept_CostReduce;
                    }

                    Data.MercenaryProfiles.RemoveRecord(temp_merc_ID);
                    Data.MercenaryProfiles.AddRecord(temp_merc_ID, mercenaryProfileRecord);
                }
            }
            

            return true;
        }
    }
}
