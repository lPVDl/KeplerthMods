using System.Collections.Generic;
using System.Reflection;
using DataBase;
using Common;
using System;

namespace ChassisMod.Wrapping
{
    internal abstract partial class Wrapper<TConfig> : Entity where TConfig : DBBase
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

        static Wrapper()
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
    }
}
