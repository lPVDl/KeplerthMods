//using System.Collections.Generic;
//using ChassisMod.Core.Data.Util;
//using DataBase;
//using System;
//using Common;

//namespace ChassisMod.Core.Data
//{
//    internal sealed class BuildingDataHelper : DataHelper<ConfigPlacement>
//    {
//        public static BuildingDataHelper Instance { get; } = new BuildingDataHelper();

//        private BuildingDataHelper() { }

//        public override string NameFor(int entityID)
//        {
//            try
//            {
//                var building = Database[entityID];
                
//                if (LanguageDataHelper.TryGetInEnglish(building.Name, out var name)) { return Language.Normalize(name); }
//            }
//            catch (Exception e) { Log.ExceptionOnce(e); }

//            return "Building" + Language.Normalize(entityID);
//        }

//        public override IEnumerable<string> CommentFor(int entityID)
//        {
//            try
//            {
//                var building = Database[entityID];
//                var props = FormatUtil.GetPropertiesWithValues(building, nameof(building.Name));
//                return FormatUtil.GroupJoin("; ", 2, props);
                        
//            }
//            catch(Exception e) { Log.ExceptionOnce(e); }

//            return new string[] { "???" };
//        }
//    }
//}
