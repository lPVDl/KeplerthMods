using ChassisMod.Patching;
using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    public abstract partial class Container<TValue>
    {       
        public static implicit operator Container<TValue> (TValue value) => new ContainerWithData() { Value = value };

        internal void Set(Container<TValue> source, Assembly patcher)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            Action patch = () =>
            {
                var info = new PatchLog.Message();

                try
                {
                    info.Patcher = patcher;

                    info.Entity = this;

                    info.OldValue = Read();

                    var value = source.Read();

                    info.NewValue = value;

                    if (!Validate(value)) throw new InvalidOperationException($"'{value}' is invalid value");

                    Write(value);
                }
                catch (Exception e)
                {
                    info.Exception = e;

                    throw new Exception(info.ToString(), e);
                }
                finally
                {
                    info.Log();
                }
            };

            AddPatch(patch, patcher);
        }

        protected abstract TValue Read();

        protected abstract void Write(TValue value);

        protected abstract bool Validate(TValue value);

        protected abstract void AddPatch(Action patch, Assembly patchOwner);
    }
}
