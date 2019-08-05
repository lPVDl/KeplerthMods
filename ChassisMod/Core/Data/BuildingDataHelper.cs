using System.Collections.Generic;
using DataBase;
using System;

namespace ChassisMod.Core.Data
{
    internal sealed class BuildingDataHelper : DataHelper<ConfigPlacement>
    {
        public static BuildingDataHelper Instance { get; } = new BuildingDataHelper();

        private BuildingDataHelper() { }

        public override string NameFor(int entityID)
        {
            try
            {
                var building = Database[entityID];
                var name = LanguageDataHelper.English[building.Name];
                if (!LanguageDataHelper.IsDefaultName(name)) return Language.Normalize(name);
            }
            catch (Exception) { }

            return "Building" + Language.Normalize(entityID);
        }

        public override IEnumerable<string> CommentFor(int entityID) => new string[] { "" };
    }
}
