using System.Collections.Generic;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class CraftGroupDataHelper : DataHelper<ConfigCraftBase>
    {
        public static CraftGroupDataHelper Instance { get; } = new CraftGroupDataHelper();

        private CraftGroupDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var group = Database[entityID];
                var name = LanguageDataHelper.English[group.Name];
                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "CraftGroup" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var result = new List<string>();
                var group = Database[entityID];

                var crafts = group.CraftCellList.Select(id => CraftDataHelper.Instance.NameFor(id));
                result.Add("Crafts: " + string.Join(", ", crafts));

                var tableDB = CraftTableDataHelper.Database;
                var tables = from tableID in tableDB.Keys
                             where tableDB[tableID].CraftBaseList.Contains(entityID)
                             select CraftTableDataHelper.Instance.NameFor(tableID);
                result.Add("At: " + string.Join(", ", tables));

                return result;
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
