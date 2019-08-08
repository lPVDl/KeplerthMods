using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
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
                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Item" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var item = Database[entityID];

                return FormatUtil.GetPropertiesWithValues(item, nameof(item.Name), nameof(item.Description), nameof(item.FunctionDes));
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
