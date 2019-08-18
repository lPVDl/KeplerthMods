using ChassisMod;
using Keplerth;
using Common;
using System;

namespace DrugOverloadMod
{
    [StaticConstructorOnStartup]
    internal static class DataPatch
    {
        static DataPatch()
        {
            try
            {
                Item.StonePickaxe.TreeDamageBonus = -1;
                // ChassisMod.KeplerthDatabase.ItemDB.StonePickaxe.TreeDamageBonus.Set(500, System.Reflection.Assembly.GetExecutingAssembly());

                //ConfigScanner.SaveDefinitions(@"T:\KeplerthDatabase\");

                // FoodDB.AGLPotion.ModifyDescription(x => x.Replace("20%", "125%"));
                // EffectDB.SpeedIII.ModifyDescription(x => x.Replace("20%", "125%"));

                // EffectDB.SpeedIII.Modifiers.Replace<Effect.MovementSpeedMul>(new Effect.MovementSpeedMul(1.25f));
            }
            catch (Exception e) { Log.Exception(e); }
        }
    }
}
