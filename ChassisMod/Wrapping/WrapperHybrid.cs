using System.Collections.Generic;
using Common.Extensions;
using System.Reflection;
using System.Linq;
using Common;
using System;

namespace ChassisMod.Wrapping
{
    public abstract class WrapperHybrid : IHybrid, IHybridManager
    {
        private static readonly Dictionary<Type, IEnumerable<IHybrid>> RuntimeInstances = new Dictionary<Type, IEnumerable<IHybrid>>();

        private static readonly Dictionary<Type, IEnumerable<IHybrid>> CompiledInstances = new Dictionary<Type, IEnumerable<IHybrid>>();

        private static readonly Dictionary<Type, IEnumerable<PropertyInfo>> Properties = new Dictionary<Type, IEnumerable<PropertyInfo>>(); 

        IEnumerable<IHybrid> IHybridManager.RuntimeInstances
        {
            get
            {
                var result = RuntimeInstances.Cash(GetType(), x => GetRuntimeInstances().Select(y => y as IHybrid));

                return result;
            }
        }

        IEnumerable<IHybrid> IHybridManager.CompiledInstances
        {
            get
            {
                var result = CompiledInstances.Cash(GetType(), FindCompiledInstances);

                return result;

                IEnumerable<IHybrid> FindCompiledInstances(Type type)
                {
                    return from field in type.GetFields()
                           where field.IsStatic && field.FieldType == type
                           let value = field.GetValue(null)
                           where value != null
                           select value as IHybrid;
                }
            }
        }

        IEnumerable<IWrapperPropertyInfo> IHybridManager.GetProperties(IHybrid hybrid)
        {
            var props = Properties.Cash(hybrid.GetType(), x => x.GetProperties());

            return from p in props
                   let info = p.GetValue(hybrid) as IWrapperPropertyInfo
                   where info != null
                   select info;
        }

        internal static IEnumerable<IHybridManager> Managers { get; }

        string IHybrid.Name => _name;

        public int ID { get; }

        private readonly string _name;

        internal protected abstract IEnumerable<WrapperHybrid> GetRuntimeInstances();

        static WrapperHybrid()
        {
            try
            {
                Managers = from t in Assembly.GetExecutingAssembly().GetTypes()
                           where !t.IsAbstract && t.GetInterfaces().Contains(typeof(IHybridManager))
                           let ctor = t.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).Single()
                           select ctor.Invoke(new object[ctor.GetParameters().Length]) as IHybridManager;
            }
            catch (Exception e) { Log.Exception(e); }
        }

        internal protected WrapperHybrid(string name, int id)
        {
            _name = name;
            ID = id;
        }

        internal protected static IEnumerable<WrapperHybrid> CreateInstances(IEnumerable<Tuple<string, int>> source, Func<string, int, WrapperHybrid> createInstance)
        {
            var data = from el in source group el.Item2 by el.Item1;

            var result = new List<WrapperHybrid>();

            foreach (var g in data)
            {
                if (g.Count() > 1)
                {
                    var index = 0;
                    foreach (var id in g)
                    {
                        result.Add(createInstance(g.Key + index, id));
                        index++;
                    }
                    continue;
                }

                result.Add(createInstance(g.Key, g.First()));
            }

            return result;
        }
    }
}
