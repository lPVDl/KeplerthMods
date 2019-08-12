using System.Collections.Generic;
using ChassisMod.Core.Data.Util;
using DataBase;
using System;
using Common;

namespace ChassisMod.Core.Data
{
    internal sealed class StatusEffectDataHelper : DataHelper<ConfigBuff>
    {
        public static StatusEffectDataHelper Instance { get; } = new StatusEffectDataHelper();

        private StatusEffectDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var effect = Database[entityID];
                var name = LanguageDataHelper.English[effect.Name];
                if (!LanguageDataHelper.IsDefault(name)) return Language.Normalize(name);
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

                var info = LanguageDataHelper.English[effect.Description];
                if (!LanguageDataHelper.IsDefault(info)) result.Add(info);

                var props = FormatUtil.GetPropertiesWithValues(effect, nameof(effect.Name), nameof(effect.Description));
                result.AddRange(props);

                return result;
                        
            }
            catch(Exception e) { Log.ExceptionOnce(e); }

            return new string[] { "???" };
        }
    }
}
