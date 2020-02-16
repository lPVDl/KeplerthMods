using Common;
using Harmony;
using Keplerth;
using System;

namespace Scythe
{
    [HarmonyPatch(typeof(Config), "LoadCurSelectLanguage")]
    [StaticConstructorOnStartup]
    internal static class LanguagePatch
    {
        static LanguagePatch()
        {
            SetData();
        }

        private static void Postfix()
        {
            SetData();
        }

        private static void SetData()
        {
            try
            {
                for (var i = 0; i < ConfigPatch.ScytheID.Length; i++)
                {
                    Config.DictLang["ItemName" + ConfigPatch.ScytheID[i]] = ConfigPatch.Material[i] + " Scythe";
                    Config.DictLang["ItemDes" + ConfigPatch.ScytheID[i]] = $"Harvests extra seed with {(int)Math.Round(ConfigPatch.ExtraYieldChances[i] * 100)}% chance.";
                }

                Config.DictLang["CraftBaseName" + ConfigPatch.RecipeGroupID] = "Scythe";
                Config.DictLang["CraftBaseIntroduce" + ConfigPatch.RecipeGroupID] = "An cutting-edge sharp tool which obviously your grass would not like to deal with.";
                Config.DictLang["CraftBaseTips" + ConfigPatch.RecipeGroupID] = "Materials: Metal Bar + Wood";
            }
            catch (Exception e) { Log.Exception(e); }
        }
    }
}
