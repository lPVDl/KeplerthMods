//using System.Collections.Generic;
//using ChassisMod.Core;
//using System.Linq;
//using DataBase;
//using System;

//namespace ChassisMod
//{
//    public sealed partial class Effect : DataWrapper<ConfigBuff>
//    {
//        public sealed class ModifiersWrapper : CollectionWrapper<Modifier>
//        {
//            internal ModifiersWrapper(string name, Effect owner) : base(name, owner) { }

//            protected override IEnumerable<Modifier> GetCollection(ConfigBuff config) => ReadModifiers(config);

//            protected override void SetCollection(ConfigBuff config, IEnumerable<Modifier> collection) => WriteModifiers(config, collection);
//        }

//        public ModifiersWrapper Modifiers { get; }

//        public void SetDescription(Language language, string description)
//        {
//            if (language == null) throw new ArgumentNullException("language was null");
//            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");

//            LanguagePatcher.Set(language, "BuffDescription" + ID, description);
//        }

//        public void SetDefaultDescription(string description)
//        {
//            if (string.IsNullOrEmpty(description)) throw new ArgumentException("description was null or empty");

//            LanguagePatcher.SetDefault("BuffDescription" + ID, description);
//        }

//        public void ModifyDescription(Func<string, string> modification)
//        {
//            if (modification == null) throw new ArgumentNullException("modification was null");

//            LanguagePatcher.AddModification("BuffDescription" + ID, modification);
//        }
//    }
//}
