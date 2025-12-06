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
    [HarmonyPatch(typeof(MagnumProgression), nameof(MagnumProgression.OnAfterLoad))]
    public static class RefreshParameter
    {
        public static void Postfix(ref MagnumProgression __instance)
        {
            //god, just update my damn departments. allright?
            foreach (MagnumDepartment magnumDepartment in __instance._departments)
            {
                magnumDepartment.OnPerksUpdated();
            }
        }
    }
}
