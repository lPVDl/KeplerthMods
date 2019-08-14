using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (delta == ChassisMod.InsertFlags.Before)
                    patchInfo += $"[... >{data}<, {insertAt} ...]";
                else
                    patchInfo += $"[... {insertAt}, >{data}< ...]";

                Owner.AddModification(patchInfo, config =>
                {
                    var cells = GetCollection(config).ToList();
                    var target = cells.Find(x => GetIdentifier(x).Equals(insertAt));
                    cells.Insert(cells.IndexOf(target) + (int)delta, data);
                    SetCollection(config, cells);
                });
            }

            protected virtual bool ValidateData(TData data) => data != null;

            protected virtual bool ValidateIdentifier(TDataIdentifier identifier) => identifier != null;

            protected virtual TDataIdentifier GetIdentifier(TData data)
            {
                if (typeof(TData) == typeof(TDataIdentifier)) return data as TDataIdentifier;

                throw new NotImplementedException($"{GetType()}({nameof(CollectionWrapper<TData, TDataIdentifier>)}.GetIdentifier() is not implemented");
            }

            protected abstract IEnumerable<TData> GetCollection(TConfig config);

            protected abstract void SetCollection(TConfig config, IEnumerable<TData> collection);
        }
    }
}
