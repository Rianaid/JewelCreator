using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using JewelCreator.Configs;
using JewelCreator.Database;
using JewelCreator.Utils;
using VampireCommandFramework;

namespace JewelCreator
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInDependency("gg.deca.VampireCommandFramework")]
    public class Plugin : BasePlugin
    {
        Harmony _harmony;
        public static ManualLogSource Logger;
        public override void Load()
        {
            if (Helper.IsServer)
            {
                // Plugin startup logic
                Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} version {MyPluginInfo.PLUGIN_VERSION} is loaded!");
                Logger = Log;
                // Harmony patching
                _harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
                _harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
                MainConfig.SettingsInit();
                DB.inits();
                CommandRegistry.RegisterAll();
            }
            else
            {
                Log.LogFatal($"There is no Server world (yet). Did you install a server mod on the client?");
            }
        }

        public override bool Unload()
        {
            CommandRegistry.UnregisterAssembly();
            _harmony?.UnpatchSelf();
            return true;
        }
    }
}
