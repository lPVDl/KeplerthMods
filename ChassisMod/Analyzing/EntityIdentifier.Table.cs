using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using DataBase;
using System;
using Common;

namespace ChassisMod.Analyzing
{
    partial class EntityIdentifier
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
    }
}