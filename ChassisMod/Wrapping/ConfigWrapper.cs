using System.Collections.Generic;
using System.Reflection;
using Common.Reflection;
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

        private static readonly object ContainerPropertiesCash = new object();
        private static readonly object ContainerNameCash = new object();
        private static readonly object ContainerOwnerCash = new object();

        protected void FinishContainersInitialization()
        {
            var props = Cash.Read(ContainerPropertiesCash, GetType(), GetContainerProperties);

            foreach(var p in props)
            {
                var container = p.GetValue(this);

                if (container == null)
                {
                    Log.Error($"{GetType().Name}.{p.Name} was null!");
                    continue;
                }

                var name = Cash.Read(ContainerNameCash, container.GetType(), x => x.GetProperty("Name"));
                var owner = Cash.Read(ContainerOwnerCash, container.GetType(), x => x.GetProperty("Owner"));

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
