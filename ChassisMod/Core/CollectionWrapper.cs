using System.Collections.Generic;
using System.Linq;
using System;

namespace ChassisMod.Core
{
    partial class DataWrapper<TConfig>
    {
        public abstract class CollectionWrapper<TData, TDataIdentifier> where TData : class where TDataIdentifier : class
        {
            private string Name { get; }
            private DataWrapper<TConfig> Owner { get; }     

            internal CollectionWrapper(string name, DataWrapper<TConfig> owner)
            {
                Name = name;
                Owner = owner;
            }

            public void Insert(TData data, TDataIdentifier insertAt, InsertFlags delta)
            {
                if (!ValidateData(data)) throw new ArgumentException("data was invalid)");
                if (!ValidateIdentifier(insertAt)) throw new ArgumentException("insertAt was invalid");

                var patchInfo = $"{Owner}.{Name} = ";
                if (delta == InsertFlags.Before)
                    patchInfo += $"[... >{data}<, {insertAt} ...]";
                else
                    patchInfo += $"[... {insertAt}, >{data}< ...]";

                Owner.AddModification(patchInfo, config =>
                {
                    var cells = GetCollection(config).ToList();
                    var target = cells.FindIndex(x => GetIdentifier(x).Equals(insertAt));
                    cells.Insert(target + (int)delta, data);
                    SetCollection(config, cells);
                });
            }

            public void Replace<T>(TData data) where T : TData
            {
                ValidateData(data);

                var patchInfo = $"{Owner}.{Name}.Replace<{typeof(T)}>({data})";
                Owner.AddModification(patchInfo, config => 
                {
                    var cells = GetCollection(config).ToList();
                    var target = cells.FindIndex(x => x is T);
                    cells[target] = data;
                    SetCollection(config, cells);
                });
            }

            protected virtual bool ValidateData(TData data) => data != null;

            protected virtual bool ValidateIdentifier(TDataIdentifier identifier) => identifier != null;

            protected abstract TDataIdentifier GetIdentifier(TData data);

            protected abstract IEnumerable<TData> GetCollection(TConfig config);

            protected abstract void SetCollection(TConfig config, IEnumerable<TData> collection);
        }

        public abstract class CollectionWrapper<TData> : CollectionWrapper<TData, TData> where TData : class
        {
            internal CollectionWrapper(string name, DataWrapper<TConfig> owner) : base(name, owner) { }

            protected override TData GetIdentifier(TData data) => data;
        }
    }
}
