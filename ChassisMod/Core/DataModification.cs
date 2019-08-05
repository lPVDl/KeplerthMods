using System.Collections.Generic;
using Common.Reflection;
using DataBase;

namespace ChassisMod.Core
{
    internal sealed class DataModification<TConfig> : DataPatch where TConfig : DBBase
    {
        public DataModification(string description, int id, System.Action<TConfig> modification)
        {
            Description = description;
            PatchAction = () =>
            {
                var table = ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;
                modification(table[id]);
            };
            
        }
    }
}
