using System.Collections.Generic;
using ChassisMod.Core.Data;
using Common.Reflection;
using DataBase;
using System;

namespace ChassisMod.Core
{
    public abstract partial class DataWrapper<TConfig> where TConfig: DBBase
    {
        internal static Dictionary<int, TConfig> Table => ReflectionHelper.GetStaticFieldValue<TConfig>("Table") as Dictionary<int, TConfig>;

        internal TConfig Config => Table[ID];

        public int ID { get; private set; }
        internal string AssemblyID { get; private set; }
        internal string Name { get; private set; }
        internal string FullName { get; private set; }

        internal bool Exists(int configID) => DataHelper<TConfig>.Database.ContainsKey(configID);

        /// <summary>
        /// Initialize entity at runtime.
        /// </summary>
        internal protected DataWrapper(int id)
        {
            ID = id;
            Name = "???";
            AssemblyID = "???";
            FullName = CreateFullName(AssemblyID, Name);
        }

        /// <summary>
        /// Initialize Keplerth entity.
        /// </summary>
        internal protected DataWrapper(string name, int id)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

            ID = id;
            Name = name;
            AssemblyID = "Keplerth";
            FullName = CreateFullName(AssemblyID, Name);

            if (!Exists(ID)) throw new InvalidOperationException($"id was not found in the Keplerth database ({FullName})");
        }

        /// <summary>
        /// Initialize mod entity and generate ID.
        /// </summary>
        internal protected DataWrapper(string assemblyID, string name)
        {
            if (string.IsNullOrEmpty(assemblyID)) throw new ArgumentException("assemblyID was null or empty");
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

            Name = name;
            AssemblyID = assemblyID;
            FullName = CreateFullName(assemblyID, Name);
            ID = IDGenerator.New(FullName);
        }

        /// <summary>
        /// Initialize mod entity with given ID.
        /// </summary>
        internal protected DataWrapper(string assemblyID, string name, int id)
        {
            if (string.IsNullOrEmpty(assemblyID)) throw new ArgumentException("assemblyID was null or empty");
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("name was null or empty");

            Name = name;
            AssemblyID = assemblyID;
            FullName = CreateFullName(assemblyID, Name);
            ID = id;
        }

        internal void AddInstatiation(TConfig data, string dataInfo = "")
        {
            var patch = new DataPatch()
            {
                Description = $"new {ToString()}({dataInfo})",
                PatchAction = () =>
                {
                    Table[ID] = data;
                }
            };
            DataPatcher.Add(patch);
        }

        internal void AddModification(string description, Action<TConfig> modification)
        {
            var patch = new DataPatch()
            {
                Description = description,
                PatchAction = () =>
                {
                    modification(Table[ID]);
                }
            };
            DataPatcher.Add(patch);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            return (obj as DataWrapper<TConfig>).ID == ID;
        }

        public override int GetHashCode() => ID;

        public override string ToString() => Name;

        private static string CreateFullName(string assemblyID, string name) => string.Join(".", typeof(TConfig).Name, assemblyID, name);
    }
}
