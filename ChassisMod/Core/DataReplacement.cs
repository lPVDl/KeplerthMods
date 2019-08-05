using System.Collections.Generic;
using Common.Reflection;
using DataBase;

namespace ChassisMod.Core
{
    internal sealed class DataReplacement<TConfig> : DataPatch where TConfig: DBBase
    {
        public DataReplacement(string description, int id, TConfig data)
        {
            Description = description;
            PatchAction = () =>
            {
                var table = ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;
                table[id] = data;
            };
        }
    }
}
