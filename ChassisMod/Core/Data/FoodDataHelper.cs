﻿using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class FoodDataHelper : DataHelper<ConfigFood>
    {
        public static FoodDataHelper Instance { get; } = new FoodDataHelper();

        private FoodDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var item = ItemDataHelper.Database[entityID];
                var name = LanguageDataHelper.English[item.Name];

                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Food" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var result = new List<string>();
                var food = Database[entityID];

                var info = LanguageDataHelper.English[food.EatBuffDescription];
                if (!LanguageDataHelper.IsDefault(info)) { result.Add(info); }

                var props = FormatUtil.GetPropertiesWithValues(food, nameof(food.EatBuffDescription));
                result.AddRange(props);

                return result;

            } catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}