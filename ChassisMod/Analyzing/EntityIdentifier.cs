using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Analyzing
{
    internal static class EntityIdentifier
    {
        private static class Table<T> where T : DBBase
        {
            private static readonly Dictionary<int, T> table;

            public static bool Contains(int id) => table.ContainsKey(id);

            public static T Get(int id) => table[id];

            public static IEnumerable<int> Keys => table.Keys;

            static Table()
            {
                try
                {
                    var file = Application.streamingAssetsPath + "/Config/" + typeof(T).Name + ".json";
                    var text = System.IO.File.ReadAllText(file);

                    table = JsonConvert.DeserializeObject<Dictionary<int, T>>(text);
                }
                catch (Exception e) { Log.Exception(e); }
            }
        }

        public static IEnumerable<Entity> GetAll()
        {
            var result = new List<Entity>();

            result.AddRange(from id in Table<ConfigItem>.Keys select GetItem(id));

            return result;
        }

        private static Entity GetItem(int id)
        {
            return new Item() { ID = id, Name = NameItem(id) ?? nameof(Item) + id };
        }

        private static string NameItem(int id)
        {
            try
            {
                var item = Table<ConfigItem>.Get(id);

                if (LanguageUtil.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.Exception(e); }

            return null;
        }
    }
}
