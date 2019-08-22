using System.Reflection;
using Chassis.Entities;
using Keplerth;
using Common;
using System;

namespace DrugOverload
{
    [StaticConstructorOnStartup]
    internal class DataPatch
    {
        [Entity.Create(SourceName = nameof(Item.GoldPickaxe0))]
        public static readonly Item GoldScythe;

        static DataPatch()
        {
            try
            {
                //PatchCenter.CreateEntities(Assembly.GetExecutingAssembly());

                Entity.InitializeAttributes(Assembly.GetExecutingAssembly());

                // Entity.InitializeAttributes(Assembly.GetExecutingAssembly());

                Entity.Exporter.AddRequest(@"T:\Keplerth\Entities.Database\");

                // DatabaseExporter.AddRequest(@"T:\KeplerthDatabase\");

                // EntityExporter.AddRequest(@"T:\KeplerthDatabase\");

                //var hb = WrapperHybrid.GetManagerNames();



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
