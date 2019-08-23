using System.Collections.Generic;
using System.Reflection;
using Chassis.Entities;
using Chassis.Patching;
using System.Linq;
using Common;
using System;

namespace Chassis.Wrapping
{
    internal abstract partial class Wrapper<TConfig> : IWrapper<TConfig> where TConfig : class
    {
        private static ConstructorInfo FromSourceConstructor { get; }
        private static FieldInfo TableField { get; }

        internal static Dictionary<int, TConfig> Table
        {
            get
            {
                var table = TableField.GetValue(null);
                if (table == null) throw new Exception($"{typeof(TConfig).Name}.Table was null");

                return table as Dictionary<int, TConfig>;
            }
        }

        protected IEntity Owner { get; }

        static Wrapper()
        {
            TableField = typeof(TConfig).GetField("Table", BindingFlags.Public | BindingFlags.Static);
            if (TableField == null) Log.Error($"{typeof(TConfig).Name}.Table was not found!");       
            if (TableField.FieldType != typeof(Dictionary<int, TConfig>)) Log.Error($"{typeof(TConfig).Name}.Table has invalid type!");
            
            var cctors = from cctor in typeof(TConfig).GetConstructors()
                         let param = cctor.GetParameters()
                         where param.Length == 1 && param[0].ParameterType == typeof(TConfig)
                         select cctor;
            FromSourceConstructor = cctors.FirstOrDefault();
            if (FromSourceConstructor == null) Log.Error($"Constructor with signature 'new {typeof(TConfig).Name}({typeof(TConfig).Name} source)' was not found!");           
            if (cctors.Count() > 1) Log.Error($"Found more than one constructor with signature 'new {typeof(TConfig).Name}({typeof(TConfig).Name} source)'!");         
        }

        protected Wrapper(IEntity owner)
        {
            Owner = owner;
        }

        void IWrapper<TConfig>.AddPatch(Action patch, IInvokationAddress patcher) => ConfigPatcher.Add(patch, patcher);

        TConfig IWrapper<TConfig>.GetConfig() => GetConfig();

        protected TConfig GetConfig()
        {
            if (Table.TryGetValue(Owner.ID, out var config))
            {
                if (config == null) throw new InvalidOperationException($"{Owner.Name}({Owner.ID}) was null");

                return config;
            }

            throw new InvalidOperationException($"{Owner.Name}({Owner.ID}) was not found in {typeof(TConfig).Name}.{nameof(Table)}");
        }

        protected void Initialize(Wrapper<TConfig> source, Action<TConfig> overrideData, IInvokationAddress patcher, bool log)
        {
            if (source == null) throw new ArgumentNullException("source was null");
            if (overrideData == null) throw new ArgumentNullException("overrideData was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            if (log) PatchLog.ReportInitalization(Owner, patcher);

            Action patch = () =>
            {
                var info = new PatchLog.Message();

                try
                {
                    info.Patcher = patcher;
                    info.Target = this;
                    info.Source = source;

                    var newConfig = FromSourceConstructor.Invoke(new object[] { source.GetConfig() }) as TConfig;
                    Table[Owner.ID] = newConfig;
                    overrideData(newConfig);
                }
                catch (Exception e)
                {
                    info.Error = e;
                    throw;
                }
                finally
                {
                    if (log) { info.Log(); }
                }
            };

            ConfigPatcher.Add(patch, patcher);
        }

        public override string ToString() => Owner.Name;
    }
}
