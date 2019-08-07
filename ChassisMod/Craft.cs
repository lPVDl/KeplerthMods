using System.Reflection;
using ChassisMod.Core;
using System.Linq;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Craft : DataWrapper<ConfigCraftCell>
    {
        public Craft(string name, Item result, int resultAmount, params Tuple<Item, int>[] ingredients) : base(Assembly.GetCallingAssembly().GetName().Name, name)
        {
            if (result == null) throw new ArgumentNullException("result was null");
            if (resultAmount <= 0) throw new ArgumentException("resultAmount must be greater than zero");
            if (ingredients.Any(x => x == null)) throw new ArgumentNullException("one or more ingredients were null");
            if (ingredients.Any(x => x.Item1 == null)) throw new ArgumentNullException("one or more ingredients item were null");
            if (ingredients.Any(x => x.Item2 <= 0)) throw new ArgumentNullException("one or more ingredients count were less than one");
            if (ingredients.Count() < 1) throw new ArgumentException("craft must have at least one ingredient");

            var data = new ConfigCraftCell()
            {
                CraftItem = result.ID,
                CraftNum = resultAmount,
                MaterialMain = Array.ConvertAll(ingredients, x => x.Item1.ID),
                MainNum = Array.ConvertAll(ingredients, x => x.Item2),
            };

            var ings = ingredients.Select(x => FormatIngredient(x.Item1.Name, x.Item2));
            var self = FormatIngredient(result.Name, resultAmount);
            var dataInfo = string.Join(" + ", ings) + " -> " + self;

            AddInstatiation(data, dataInfo);
        }

        private static string FormatIngredient(string name, int amount) => $"{amount}x{name}";

        internal Craft(string name, int id) : base(name, id) { }
    }
}
