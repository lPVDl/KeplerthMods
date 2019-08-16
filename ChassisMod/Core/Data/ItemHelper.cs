using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class ItemHelper : ConfigHelper<ConfigItem>
    {
        public static ItemHelper Instance { get; } = new ItemHelper();

        private ItemHelper() { }

        public override IEnumerable<int> Keys => from key in base.Keys
                                                 where !FoodHelper.Instance.IsFood(key)
                                                 where !WeaponHelper.Instance.IsWeapon(key)
                                                 select key;

        public override string Name(int entityID)
        {
            try
            {
                var item = Database[entityID];

                if (LanguageHelper.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Item" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> Comment(int entityID)
        {
            try
            {
                var result = new List<string>();
                var item = Database[entityID];

                if (LanguageHelper.TryGetInEnglish(item.Name, out var name)) { result.Add($"Name: \"{name}\""); }
                if (LanguageHelper.TryGetInEnglish(item.Description, out var description)) { result.Add($"Description: \"{description}\""); }
                if (LanguageHelper.TryGetInEnglish(item.FunctionDes, out var funcDes)) { result.Add($"Function: \"{funcDes}\""); }

                result.AddRange(FormatUtil.GetPropertiesWithValues(item, nameof(item.Name), nameof(item.Description), nameof(item.FunctionDes)));

                return result;
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
