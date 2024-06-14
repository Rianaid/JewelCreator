using BepInEx.Configuration;
using JewelCreator.Database;
using System.IO;

namespace JewelCreator.Configs
{
    internal class MainConfig
    {
        private static readonly string FileDirectory = Path.Combine("BepInEx", "config");
        private static readonly string FileName = "JewelsCreator.json";
        private static readonly string fullPath = Path.Combine(FileDirectory, FileName);
        private static readonly ConfigFile Conf = new ConfigFile(fullPath, true);
        public static ConfigEntry<bool> EnableCommand;
        public static ConfigEntry<bool> AdminOnlyCommand;
        public static ConfigEntry<int> TierLevel;
        public static ConfigEntry<float> SkillModPower;

        public static void SettingsInit()
        {
            EnableCommand = Conf.Bind("JewelCreator", "Enabled", true, "Enable command \"JewelCreator\". only for Admins");
            AdminOnlyCommand = Conf.Bind("JewelCreator", "Enabled", true, "Enable command \"JewelCreator\".");
            TierLevel = Conf.Bind("JewelCreator", "TierLevel", 4, "Setup (1-4) tier of jewels.");
            SkillModPower = Conf.Bind("JewelCreator", "SkillModPower", 1f, "Setup (0.0 - 1.0) jewels skill modification power.");
            SettingsBind();
        }
        public static void SettingsBind()
        {
            if (TierLevel.Value < 1 || TierLevel.Value > 4)
            {
                Plugin.Logger.LogWarning($"Tier level must be from 1 to 4 inclusive. set to default value (4).");
                TierLevel.Value = 4;
            }
            if (SkillModPower.Value < 0|| SkillModPower.Value > 1)
            {
                Plugin.Logger.LogWarning($"Skill Mod Power must be from 0 to 1 inclusive. set to default value (1).");
                SkillModPower.Value = 1;
            }
            DB.AdminOnlyCommand = AdminOnlyCommand.Value;
            DB.EnabledCommand = EnableCommand.Value;
            DB.JewelTier = TierLevel.Value -1;
            DB.SkillPower = SkillModPower.Value;
        }
    }
}
