//using System.Collections.Generic;
//using ChassisMod.Core.Data.Util;
//using System.Linq;
//using DataBase;
//using System;
//using Common;

//namespace ChassisMod.Core.Data
//{
//    internal sealed class WeaponHelper : ConfigHelper<ConfigWeapon>
//    {
//        public static WeaponHelper Instance { get; } = new WeaponHelper();

//        private WeaponHelper() { }

//        public bool IsWeapon(int itemID) => Keys.Contains(itemID);

//        public override string Name(int entityID)
//        {
//            try
//            {
//                var item = ItemHelper.Database[entityID];

//                if (LanguageHelper.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
//            }
//            catch (Exception e) { Log.ExceptionOnce(e); }

//            return "Weapon" + Language.Normalize(entityID);
//        }

//        public override IEnumerable<string> Comment(int entityID)
//        {
//            try
//            {
//                var weapon = Database[entityID];

//                return FormatUtil.GetPropertiesWithValues(weapon);
//            }
//            catch (Exception e) { Log.ExceptionOnce(e); }

//            return new string[] { "???" };
//        }
//    }
//}
