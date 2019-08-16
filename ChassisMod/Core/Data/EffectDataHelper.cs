using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using System.Linq;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class EffectDataHelper : DataHelper<ConfigBuff>
    {
        public static EffectDataHelper Instance { get; } = new EffectDataHelper();

        private EffectDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var effect = Database[entityID];

                if (LanguageDataHelper.TryGetInEnglish(effect.Name, out var name)) { return Language.Normalize(name); }
            }
            catch (Exception e) { Log.ExceptionOnce(e); }

            return "Effect" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID)
        {
            try
            {
                var result = new List<string>();
                var effect = Database[entityID];

                if (LanguageDataHelper.TryGetInEnglish(effect.Description, out var info)) { result.Add(info); }

                var modifiers = Effect.ReadModifiers(effect).Select(x => x.ToString());

                if (modifiers.Count() > 0) result.Add($"Modifiers: [ {string.Join(", ", modifiers)} ]");

                result.Add($"Tier: {effect.Level}");
                result.Add($"Duration: {(effect.DurationTime != -1 ? effect.DurationTime + "s" : "∞")}");

                return result;
                        
            }
            catch(Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
