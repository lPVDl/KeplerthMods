using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using DataBase;
using System;
using Common;

namespace ChassisMod.Analyzing
{
    internal static class EntityScanner
    {
        private static class Table<T> where T : DBBase
        {
            private static readonly Dictionary<int, T> table;

            public static bool Contains(int id) => table.ContainsKey(id);

            public static T Get(int id) => table[id];

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

        public static Entity Identify(int id)
        {
            if (Table<ConfigItem>.Contains(id))
            {
                return new Item() { ID = id, Name = NameItem(id) ?? "Item" + id };
            }

            throw new Exception("Failed to identify entity ID {id}");
        }

        private static string NameItem(int id)
        {
            try
            {
                var item = Table<ConfigItem>.Get(id);

                if (LanguageHelper.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.Exception(e); }

            return null;
        }
    }
}
