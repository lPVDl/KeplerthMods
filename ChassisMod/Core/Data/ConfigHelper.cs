using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using DataBase;

namespace ChassisMod.Core.Data
{
    internal abstract class ConfigHelper<TConfig> where TConfig : DBBase
    {
        public static Dictionary<int, TConfig> Database { get; } = LoadDatabase();

        private static Dictionary<int, TConfig> LoadDatabase()
        {
            var file = Application.streamingAssetsPath + "/Config/" + typeof(TConfig).Name + ".json";
            var text = System.IO.File.ReadAllText(file);

            return JsonConvert.DeserializeObject<Dictionary<int, TConfig>>(text);
        }

        protected ConfigHelper() { }

        public virtual IEnumerable<int> Keys { get; } = Database.Keys;

        public abstract string Name(int entityID);
        public abstract IEnumerable<string> Comment(int entityID);

    }
}
