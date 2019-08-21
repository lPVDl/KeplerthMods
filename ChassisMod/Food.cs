using System.Collections.Generic;
using ChassisMod.Utilities;
using ChassisMod.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace ChassisMod
{
    public sealed partial class Food : IEntity, IEntityManager
    {
        IEnumerable<IEntity> IEntityManager.CompiledInstances => Entity.FindCompiledEntitiesCashed<Food>();

        IEnumerable<IEntity> IEntityManager.RuntimeInstances => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Food(id, name));

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");

            var food = entity as Food;

            if (food == null) throw new InvalidOperationException($"entity was not {typeof(Food)}");

            return Entity.GetPropertyValues<Food, IPropertyInfo>(food);
        }

        public int ID { get; }
        public string Name { get; }

        public Reader<float> PlayerSatiety
        {
            get => _food.PlayerSatiety.Reader;
            set => _food.PlayerSatiety.Set(value, Assembly.GetExecutingAssembly());
        }

        private readonly ItemWrapper _item;
        private readonly FoodWrapper _food;

        private Food(int id, string name)
        {
            ID = id;
            Name = name;

            _item = new ItemWrapper(this);
            _food = new FoodWrapper(this);
        }

        private static IEnumerable<int> GetIDs()
        {
            return from id in FoodWrapper.Table.Keys
                   where ItemWrapper.Table.ContainsKey(id)
                   select id;
        }

        private static string GetNameOrNull(int id) => LanguageUtil.GetNameOrNull(ItemWrapper.Table[id].Name);
    }
}
