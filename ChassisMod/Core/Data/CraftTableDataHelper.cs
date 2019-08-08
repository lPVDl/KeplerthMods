using System.Collections.Generic;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class CraftTableDataHelper : DataHelper<ConfigCraftTable>
    {
        public static CraftTableDataHelper Instance { get; } = new CraftTableDataHelper();

        private CraftTableDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var building = BuildingDataHelper.Database[entityID];
                var name = LanguageDataHelper.English[building.Name];
                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "CraftTable" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var result = new List<string>();
                var table = Database[entityID];

                var groups = from cgID in table.CraftBaseList
                             select CraftGroupDataHelper.Instance.NameFor(cgID);
                result.Add("CraftGroups: " + string.Join(", ", groups));

                return result;
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
