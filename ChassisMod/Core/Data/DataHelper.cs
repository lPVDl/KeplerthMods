using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using DataBase;

namespace ChassisMod.Core.Data
{
    internal abstract class DataHelper<TConfig> where TConfig : DBBase
    {
        public static Dictionary<int, TConfig> Database { get; } = LoadDatabase();

        private static Dictionary<int, TConfig> LoadDatabase()
        {
            var file = Application.streamingAssetsPath + "/Config/" + typeof(TConfig).Name + ".json";
            var text = System.IO.File.ReadAllText(file);

            return JsonConvert.DeserializeObject<Dictionary<int, TConfig>>(text);
        }

        protected DataHelper() { }

        public IEnumerable<int> Keys { get; } = Database.Keys;
        public abstract string NameFor(int entityID);
        public abstract IEnumerable<string> CommentFor(int entityID);
   
    }
}
