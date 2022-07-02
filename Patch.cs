using HarmonyLib;
using UnityEngine;

namespace DemoExtender
{
    [HarmonyPatch(typeof(InterfaceHandler))]
    [HarmonyPatch("FinishDemo")]
    class Patch
    {
        static bool Prefix()
        {
            Debug.Log("Prevented FinishDemo()");
            return false;
        }
    }
}
