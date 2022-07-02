using BepInEx;
using HarmonyLib;

namespace DemoExtender
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Harmony.CreateAndPatchAll(typeof(Patch));
        }
    }
}
