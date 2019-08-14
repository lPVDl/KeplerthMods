using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using System.Linq;
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

                if (LanguageDataHelper.TryGetInEnglish(item.Name, out var name)) { return Language.Normalize(name); }
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

                if (LanguageDataHelper.TryGetInEnglish(food.EatBuffDescription, out var info)) { result.Add(info); }

                if (food.Buff.Length > 0 && food.Buff[0] != 0)
                {
                    var effects = food.Buff.Select(x => StatusEffectDataHelper.Instance.NameFor(x));
                    result.Add($"Effect: [ {string.Join(", ", effects)} ]");
                }

                if (food.BuffRandomOne.Length > 0 && food.BuffRandomOne[0] != 0 && food.RandomTimes > 0)
                {
                    var effects = food.BuffRandomOne.Select(x => StatusEffectDataHelper.Instance.NameFor(x));
                    result.Add($"RandomEffect: {food.RandomTimes} -> [ {string.Join(", ", effects)} ]");
                }

                if (food.EffectHp != 0) { result.Add($"PlayerHealth: {food.EffectHp / 100}%"); }

                if (food.EffectHunger != 0) { result.Add($"PlayerSatiety: {food.EffectHunger / 360}%"); }

                if (food.PetEatHp != 0) { result.Add($"MinionHealth: {food.PetEatHp / 100}%"); }

                if (food.PetEatHunger != 0) { result.Add($"MinionSatiety: {food.PetEatHunger / 60}%"); }

                if (food.FeedAnimalHunger != 0) { result.Add($"BreedingSatiety: {food.FeedAnimalHunger}u"); }

                if (food.ExEffect != 0) { result.Add($"SpecialEvent: #{food.ExEffect}"); }

                if (food.UseCD != 0) { result.Add($"Cooldown: {food.UseCD}s"); }

                return result;

            } catch (Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
