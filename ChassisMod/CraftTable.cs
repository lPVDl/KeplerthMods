using ChassisMod.Core;
using System.Linq;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class CraftTable : DataWrapper<ConfigCraftTable>
    {
        internal CraftTable(string name, int id) : base(name, id) { }

        public void Insert(CraftGroup toInsert, CraftGroup insertAt, int indexDelta)
        {
            if (toInsert == null) throw new ArgumentNullException("toInsert was null");
            if (insertAt == null) throw new ArgumentNullException("insertAt was null");

            var patchInfo = $"{Name}.Crafts = ";
            if (indexDelta <= 0)
                patchInfo += $"[... >{toInsert}<, {insertAt} ...]";
            else
                patchInfo += $"[... {insertAt}, >{toInsert}< ...]";

            AddModification(patchInfo, Insert);

            void Insert(ConfigCraftTable table)
            {
                var crafts = table.CraftBaseList.ToList();
                var targetIndex = crafts.IndexOf(insertAt.ID);
                crafts.Insert(targetIndex + indexDelta, toInsert.ID);
                table.CraftBaseList = crafts.ToArray();
            }
        }
    }
}
