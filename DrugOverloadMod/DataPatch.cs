using System.Reflection;
using ChassisMod.Analyzing;
using ChassisMod;
using Keplerth;
using Common;
using System;

namespace DrugOverloadMod
{
    [StaticConstructorOnStartup]
    internal class DataPatch
    {
        [CreateFrom("GoldPickaxe0")]
        public static readonly Item CopperAxe;

        static DataPatch()
        {
            try
            {
                //PatchCenter.CreateEntities(Assembly.GetExecutingAssembly());

                // EntityExporter.AddRequest(@"T:\KeplerthDatabase\");

                Item.StonePickaxe.TreeDamageBonus = 5000;
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
