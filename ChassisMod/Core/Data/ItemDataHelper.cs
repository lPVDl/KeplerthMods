using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using Common.Reflection;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class ItemDataHelper : DataHelper<ConfigItem>
    {
        public static ItemDataHelper Instance { get; } = new ItemDataHelper();

        private ItemDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var item = Database[entityID];
                var name = LanguageDataHelper.English[item.Name];
                if (!LanguageDataHelper.IsDefaultName(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Item" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                string[] blacklist = { "Name", "Description", "FunctionDes" };
                var item = Database[entityID];
                return from prop in item.GetInstanceProperties()
                       let name = prop.Name
                       where !blacklist.Contains(name)
                       select name + ": " + FormatUtil.ContentToString(prop.GetValue(item)) + "<para/>";
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
