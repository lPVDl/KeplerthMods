using System.Reflection;
using ChassisMod.Core;
using System.Linq;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class CraftGroup : DataWrapper<ConfigCraftBase>
    {
        public CraftGroup(string name, params Craft[] crafts) : base(Assembly.GetCallingAssembly().GetName().Name, name)
        {
            if (crafts.Any(x => x == null)) throw new ArgumentNullException("one or more crafts were null");

            var data = new ConfigCraftBase()
            {
                CraftCellList = (crafts.Length == 0) ? new int[] { 0 } : Array.ConvertAll(crafts, x => x.ID),
                Name = "CraftBaseName" + ID,
                Tips = "CraftBaseTips" + ID,
                Introduce = "CraftBaseIntroduce" + ID
            };

            var craftNames = crafts.Select(x => x.Name);

            AddInstatiation(data, string.Join(", ", craftNames));
        }

        /// <summary>
        /// Initialize entity at runtime.
        /// </summary>
        internal CraftGroup(int id) : base(id) { }

        /// <summary>
        /// Initialize Keplerth entity.
        /// </summary>
        internal CraftGroup(string name, int id) : base(name, id) { }

        public void SetTranslation(Language language, string name, string description, string materials)
        {
            if (language == null) throw new ArgumentNullException("language");
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");
            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");
            if (string.IsNullOrEmpty(materials)) throw new ArgumentException("materials was null or empty");

            LanguagePatcher.Set(language, "CraftBaseName" + ID, name);
            LanguagePatcher.Set(language, "CraftBaseTips" + ID, materials);
            LanguagePatcher.Set(language, "CraftBaseIntroduce" + ID, description);
        }

        public void SetDefaultTranslation(string name, string description, string materials)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");
            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");
            if (string.IsNullOrEmpty(materials)) throw new ArgumentException("materials was null or empty");

            LanguagePatcher.SetDefault("CraftBaseName" + ID, name);
            LanguagePatcher.SetDefault("CraftBaseTips" + ID, materials);
            LanguagePatcher.SetDefault("CraftBaseIntroduce" + ID, description);
        }
    }
}
