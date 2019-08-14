using System.Collections.Generic;
using ChassisMod.Core;
using System.Linq;
using DataBase;

namespace ChassisMod
{
    public sealed class CraftTable : DataWrapper<ConfigCraftTable>
    {
        public sealed class CraftsWrapper : CollectionWrapper<CraftGroup, CraftGroup>
        {
            internal CraftsWrapper(string name, CraftTable owner) : base(name, owner) { }

            protected override IEnumerable<CraftGroup> GetCollection(ConfigCraftTable config)
            {
                if (config.CraftBaseList.Length == 1 && config.CraftBaseList[0] == 0)
                    return new CraftGroup[] { };

                return config.CraftBaseList.Select(x => new CraftGroup(x));
            }

            protected override void SetCollection(ConfigCraftTable config, IEnumerable<CraftGroup> collection)
            {
                if (collection.Count() == 0)
                {
                    config.CraftBaseList = new int[] { 0 };
                    return;
                }

                config.CraftBaseList = collection.Select(x => x.ID).ToArray();
            }
        }

        public CraftsWrapper Crafts { get; }

        internal CraftTable(string name, int id) : base(name, id)
        {
            Crafts = new CraftsWrapper(nameof(Crafts), this);
        }       
    }
}
