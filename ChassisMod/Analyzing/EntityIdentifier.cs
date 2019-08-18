using System.Collections.Generic;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Analyzing
{
    internal static partial class EntityIdentifier
    {
        public static IEnumerable<Entity> GetAll()
        {
            var result = new List<Entity>();

            result.AddRange(from id in Table<ConfigItem>.Keys select GetItem(id));

            return result;
        }

        private static Entity GetItem(int id)
        {
            if (Table<ConfigFood>.Contains(id)) return new Food()
            {
                ID = id,
                Name = NameItem(id) ?? nameof(Food) + id
            };

            return new Item()
            {
                ID = id,
                Name = NameItem(id) ?? nameof(Item) + id
            };
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
