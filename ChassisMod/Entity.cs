using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Common;
using System;

namespace ChassisMod
{
    internal static class Entity
    {
        private static class RuntimeEntityCash<T>
        {
            public static IEnumerable<T> Values;
        }

        private static class CompiledEntityCash<T>
        {
            public static IEnumerable<T> Values;
        }

        private static class PropertyCash<TObject, TInterface>
        {
            public static IEnumerable<PropertyInfo> Values;
        }

        internal static IEnumerable<IEntityManager> Managers { get; }

        static Entity()
        {
            try
            {
                Managers = from type in Assembly.GetExecutingAssembly().GetTypes()
                           where type.GetInterfaces().Contains(typeof(IEntityManager))
                           let ctor = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).Single()
                           select ctor.Invoke(new object[ctor.GetParameters().Length]) as IEntityManager;
            }
            catch (Exception e) { Log.Exception(e); }
        }

        public static IEnumerable<T> FindCompiledEntitiesCashed<T>() where T : class
        {
            var cash = CompiledEntityCash<T>.Values;

            if (cash != null) { return cash; }

            var type = typeof(T);

            cash = from field in type.GetFields(BindingFlags.Public | BindingFlags.Static)
                   where field.IsStatic && field.IsInitOnly && field.FieldType == type
                   let value = field.GetValue(null)
                   where value != null
                   select value as T;

            CompiledEntityCash<T>.Values = cash;

            return cash;
        }

        public static IEnumerable<T> CreateRuntimeEntitiesCashed<T>(Func<IEnumerable<int>> getIDs, Func<int, string> getNameOrNull, Func<int, string, T> createInstance)
        {
            if (getIDs == null) throw new ArgumentNullException("getIDs was null");
            if (getNameOrNull == null) throw new ArgumentNullException("getNameOrNull was null");
            if (createInstance == null) throw new ArgumentNullException("createInstance was null");

            var cash = RuntimeEntityCash<T>.Values;

            if (cash == null || cash.Count() == 0) { cash = CreateRuntimeEntities(getIDs, getNameOrNull, createInstance); }

            RuntimeEntityCash<T>.Values = cash;

            return cash;
        }

        private static IEnumerable<T> CreateRuntimeEntities<T>(Func<IEnumerable<int>> getIDs, Func<int, string> getNameOrNull, Func<int, string, T> createInstance)
        {
            var typeName = typeof(T).Name;
            var ids = getIDs();
            var names = ids.Select(x => getNameOrNull(x) ?? typeName + x).ToArray();

            // Remove duplicated names. [Bob, Steve, Bob] => [Bob0, Steve, Bob1]
            for (var i = 0; i < names.Length; i++)
            {
                for (var j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        var name = names[i];
                        var counter = 0;
                        for (var p = i; p < names.Length; p++)
                            if (names[p] == name)
                            {
                                names[p] += counter;
                                counter++;
                            }
                    }
                }
            }

            return ids.Zip(names, (id, name) => createInstance(id, name));
        }
        
        public static IEnumerable<TValue> GetPropertyValues<TObject, TValue>(TObject obj) where TValue : class
        {
            if (obj == null) throw new NullReferenceException("obj was null");

            var cash = PropertyCash<TObject, TValue>.Values;
            if (cash == null)
            {
                cash = from prop in typeof(TObject).GetProperties()
                       where prop.CanRead
                       let value = prop.GetValue(obj)
                       where value != null && value is TValue
                       select prop;
            }
            PropertyCash<TObject, TValue>.Values = cash;

            return cash.Select(x => x.GetValue(obj) as TValue);
        }    
    }
}
