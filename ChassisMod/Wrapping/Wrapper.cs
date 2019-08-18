using System.Collections.Generic;
using Common.Reflection;
using DataBase;

namespace ChassisMod.Wrapping
{
    internal abstract partial class Wrapper<TConfig> : Entity where TConfig : DBBase
    {
        private static Dictionary<int, TConfig> Table => Reflector.GetFieldValue(typeof(TConfig), "Table") as Dictionary<int, TConfig>;
    }
}
