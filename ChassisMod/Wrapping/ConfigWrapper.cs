using System.Collections.Generic;
using Common.Reflection;
using DataBase;

namespace ChassisMod.Wrapping
{
    internal abstract partial class ConfigWrapper<TConfig> : Entity where TConfig : DBBase
    {
        public static Dictionary<int, TConfig> Table => Reflector.GetFieldValue(typeof(TConfig), "Table") as Dictionary<int, TConfig>;
    }
}
