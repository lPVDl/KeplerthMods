using System.Collections.Generic;
using System.Reflection;
using DataBase;
using Common;
using System;

namespace ChassisMod.Wrapping
{
    internal abstract partial class ConfigWrapper<TConfig> : Entity where TConfig : DBBase
    {
        private static FieldInfo TableRefence { get; }

        public static Dictionary<int, TConfig> Table
        {
            get
            {
                var table = TableRefence.GetValue(null);
                if (table == null) throw new Exception($"{typeof(TConfig).Name}.Table was null");

                return table as Dictionary<int, TConfig>;
            }
        }

        static ConfigWrapper()
        {
            TableRefence = typeof(TConfig).GetField("Table", BindingFlags.Public | BindingFlags.Static);

            if (TableRefence == null)
            {
                Log.Error($"{typeof(TConfig).Name}.Table was not found!");
                return;
            }

            if (TableRefence.FieldType != typeof(Dictionary<int, TConfig>))
            {
                Log.Error($"{typeof(TConfig).Name}.Table has invalid type!");
            }
        }
    }
}
