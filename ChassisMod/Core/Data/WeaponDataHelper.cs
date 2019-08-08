using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using Common.Reflection;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class WeaponDataHelper : DataHelper<ConfigWeapon>
    {
        public static WeaponDataHelper Instance { get; } = new WeaponDataHelper();

        private WeaponDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var item = ItemDataHelper.Database[entityID];
                var name = LanguageDataHelper.English[item.Name];
                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Weapon" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var weapon = Database[entityID];
                return from prop in weapon.GetInstanceProperties()
                       select $"{prop.Name}: {FormatUtil.ContentToString(prop.GetValue(weapon))} <para/>";
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
