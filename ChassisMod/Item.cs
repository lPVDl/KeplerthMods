using System.Collections.Generic;
using ChassisMod.Utilities;
using ChassisMod.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace ChassisMod
{
    public sealed partial class Item : WrapperHybrid
    {
        public Reader<int> TreeDamageBonus
        {
            get => _item.TreeDamageBonus.Reader;
            set => _item.TreeDamageBonus.Set(value, Assembly.GetCallingAssembly());
        }

        private readonly ItemWrapper _item;

        private Item(string name, int id) : base(name, id)
        {
            _item = new ItemWrapper(this);
        }

        protected internal override IEnumerable<WrapperHybrid> GetRuntimeInstances()
        {
            var data = from id in ItemWrapper.Table.Keys
                       where !FoodWrapper.Table.Keys.Contains(id)
                       let name = LanguageUtil.NameFromTextID(ItemWrapper.Table[id].Name) ?? "Item" + id
                       select Tuple.Create(name, id);

            return CreateInstances(data, (name, id) => { return new Item(name, id); });
        }
    }
}
