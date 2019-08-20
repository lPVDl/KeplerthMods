using System.Collections.Generic;
using ChassisMod.Utilities;
using ChassisMod.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace ChassisMod
{
    public sealed partial class Food : WrapperHybrid
    {
        public Reader<float> PlayerSatiety
        {
            get => _food.PlayerSatiety.Reader;
            set => _food.PlayerSatiety.Set(value, Assembly.GetExecutingAssembly());
        }

        private readonly ItemWrapper _item;
        private readonly FoodWrapper _food;

        private Food(string name, int id) : base(name, id)
        {
            _item = new ItemWrapper(this);
            _food = new FoodWrapper(this);
        }

        protected internal override IEnumerable<WrapperHybrid> GetRuntimeInstances()
        {
            var data = from id in FoodWrapper.Table.Keys
                       let name = LanguageUtil.NameFromTextID(ItemWrapper.Table[id].Name) ?? "Food" + id
                       select Tuple.Create(name, id);

            return CreateInstances(data, (name, id) => { return new Food(name, id); });
        }
    }
}
