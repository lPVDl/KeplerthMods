//using System.Reflection;
//using Common;
//using System;

//namespace DrugOverload
//{
//    [ExecuteStaticConstructaor]
//    internal class DataPatch
//    {
//        [CreateEntity(Source = nameof(Food.Apple))]
//        public static readonly Food Grapes;
        
//        static DataPatch()
//        {
//            try
//            {
//                //PatchCenter.CreateEntities(Assembly.GetExecutingAssembly());

//                Entity.InitializeAttributes(Assembly.GetExecutingAssembly());

//                // Entity.InitializeAttributes(Assembly.GetExecutingAssembly());

//                EntityExporter.AddRequest(@"T:\Keplerth\Entities.Database\");

//                if (Grapes != null) Log.Message(Grapes.ToString());

//                // DatabaseExporter.AddRequest(@"T:\KeplerthDatabase\");

//                // EntityExporter.AddRequest(@"T:\KeplerthDatabase\");

//                //var hb = WrapperHybrid.GetManagerNames();

                

//                // Item.StonePickaxe.Name.Edit(x => x + "WARNING VERY OP PICKAXE");
//                // ChassisMod.KeplerthDatabase.ItemDB.StonePickaxe.TreeDamageBonus.Set(500, System.Reflection.Assembly.GetExecutingAssembly());

//                //ConfigScanner.SaveDefinitions(@"T:\KeplerthDatabase\");

//                // FoodDB.AGLPotion.ModifyDescription(x => x.Replace("20%", "125%"));
//                // EffectDB.SpeedIII.ModifyDescription(x => x.Replace("20%", "125%"));

//                // EffectDB.SpeedIII.Modifiers.Replace<Effect.MovementSpeedMul>(new Effect.MovementSpeedMul(1.25f));
//            }
//            catch (Exception e) { Log.Exception(e); }
//        }
//    }
//}
