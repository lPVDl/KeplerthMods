using Common.Reflection;
using ChassisMod.Core;
using DataBase;
using System;

namespace ChassisMod
{
    public sealed class Food : DataWrapper<ConfigFood>
    {
        internal Food(string name, int id) : base (name, id) { }

        internal Food(string assemblyID, string name, int id) : base(assemblyID, name, id) { }

        internal void CopyFrom(Food source)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            AddModification("", food =>
            {               
                var buffInfo = food.GetInstanceFieldValue("eatBuffDescription");

                var data = ConfigFood.Table[source.ID];
                food.CopyInstanceFieldValues(data);

                food.SetInstanceFieldValue("eatBuffDescription", buffInfo);
            });
        }

        public void SetDescription(Language language, string description)
        {
            if (language == null) throw new ArgumentNullException("language was null");
            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");

            LanguagePatcher.Set(language, "EatBuffDescription" + ID, description);
        }

        public void SetDefaultDescription(string description)
        {
            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");

            LanguagePatcher.SetDefault("EatBuffDescription" + ID, description);
        }

        public void ModifyDescription(Func<string, string> modification)
        {
            if (modification == null) throw new ArgumentNullException("modification was null");

            LanguagePatcher.AddModification("EatBuffDescription" + ID, modification);
        }
    }
}
