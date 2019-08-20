using System.Collections.Generic;
using System.Reflection;
using Common.Reflection;
using Common.Extensions;
using System.Linq;
using DataBase;
using Common;
using System;

namespace ChassisMod.Wrapping
{
    internal abstract partial class ConfigWrapper<TConfig> : Entity where TConfig : DBBase
    {
        private static FieldInfo TableField { get; }

        public static Dictionary<int, TConfig> Table
        {
            get
            {
                var table = TableField.GetValue(null);
                if (table == null) throw new Exception($"{typeof(TConfig).Name}.Table was null");

                return table as Dictionary<int, TConfig>;
            }
        }

        static ConfigWrapper()
        {
            TableField = typeof(TConfig).GetField("Table", BindingFlags.Public | BindingFlags.Static);

            if (TableField == null)
            {
                Log.Error($"{typeof(TConfig).Name}.Table was not found!");
                return;
            }

            if (TableField.FieldType != typeof(Dictionary<int, TConfig>))
            {
                Log.Error($"{typeof(TConfig).Name}.Table has invalid type!");
            }
        }

        private static readonly Dictionary<Type, IEnumerable<PropertyInfo>> ContainerProperties = new Dictionary<Type, IEnumerable<PropertyInfo>>();
        private static readonly Dictionary<Type, PropertyInfo> ContainerName = new Dictionary<Type, PropertyInfo>();
        private static readonly Dictionary<Type, PropertyInfo> ContainerOwner = new Dictionary<Type, PropertyInfo>();

        protected void FinishContainersInitialization()
        {
            var props = ContainerProperties.Cash(GetType(), GetContainerProperties);

            foreach(var p in props)
            {
                var container = p.GetValue(this);

                if (container == null)
                {
                    Log.Error($"{GetType().Name}.{p.Name} was null!");
                    continue;
                }

                var name = ContainerName.Cash(container.GetType(), x => x.GetProperty("Name"));
                var owner = ContainerOwner.Cash(container.GetType(), x => x.GetProperty("Owner"));

                name.SetValue(container, p.Name);
                owner.SetValue(container, this);
            }
        }

        private static IEnumerable<PropertyInfo> GetContainerProperties(Type type)
        {
            var props = type.GetProperties();

            return from p in props
                   let pType = p.PropertyType
                   where Reflector.IsDerivedGenericType(pType, typeof(ConfigContainer<,>))
                   where pType.GenericTypeArguments[0] == typeof(TConfig)
                   select p;
        }
    }
}
