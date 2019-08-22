using System.Collections.Generic;
using Chassis.Utilities;
using Chassis.Wrapping;
using System.Reflection;
using System.Linq;
using System;

namespace Chassis.Entities
{
    public sealed partial class Food : IEntity, IEntityManager
    {
        #region Manager
        IEnumerable<IEntity> IEntityManager.CompiledEntities => Entity.FindCompiledEntitiesCashed<Food>();

        IEnumerable<IEntity> IEntityManager.RuntimeEntities => Entity.CreateRuntimeEntitiesCashed(GetIDs, GetNameOrNull, (id, name) => new Food(id, name));

        bool IEntityManager.RequiresSourceForCreation => true;

        Entity.ManagerGroup IEntityManager.NamingGroup => Item.NamingGroup;

        IEnumerable<IPropertyInfo> IEntityManager.GetProperties(IEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity was null");
            var food = entity as Food;
            if (food == null) throw new InvalidOperationException($"entity was not {typeof(Food)}");

            return Entity.GetPropertyValues<Food, IPropertyInfo>(food);
        }

        IEntity IEntityManager.Create(Assembly owner, string entityName, IEntity source) => throw new NotImplementedException();
        #endregion

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
