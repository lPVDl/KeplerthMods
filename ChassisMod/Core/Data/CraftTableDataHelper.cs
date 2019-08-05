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
                if (!LanguageDataHelper.IsDefaultName(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "CraftTable" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var table = Database[entityID];
                var comment = "CraftGroups: ";
                var groups = from cgID in table.CraftBaseList select CraftGroupDataHelper.Instance.NameFor(cgID);
                comment += string.Join(", ", groups);

                return new string[] { comment };
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
