using System.Collections.Generic;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class CraftDataHelper : DataHelper<ConfigCraftCell>
    {
        public static CraftDataHelper Instance { get; } = new CraftDataHelper();

        private CraftDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var craft = Database[entityID];
                var item = DataHelper<ConfigItem>.Database[craft.CraftItem];

                if (LanguageDataHelper.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Craft" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var craft = Database[entityID];
                var comment = "Recipe: ";
                var ingredients = from i in craft.MaterialMain.Zip(craft.MainNum, Tuple.Create)
                                  select FormatIngredient(i.Item1, i.Item2);
                comment += string.Join(" + ", ingredients);
                comment += " -> ";
                comment += FormatIngredient(craft.CraftItem, craft.CraftNum);
                // comment += ".<para/>";

                // comment += "At: ";
                // var tableDB = CraftTableDataHelper.Database;
                // var groupDB = CraftGroupDataHelper.Database;
                // var tables = from tableID in tableDB.Keys
                //              from groupID in tableDB[tableID].CraftBaseList
                //              where groupDB[groupID].CraftCellList.Contains(entityID)
                //              select CraftTableDataHelper.Instance.NameFor(tableID);
                // comment += string.Join(", ", tables.Distinct());

                return new string[] { comment };
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "??? + ??? -> ???" };
        }

        private static string FormatIngredient(int itemID, int amount) => string.Format("{0}x({1})", amount, ItemDataHelper.Instance.NameFor(itemID));
    }
}
