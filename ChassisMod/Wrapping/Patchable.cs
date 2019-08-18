using ChassisMod.Patching;
using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    public abstract class Patchable<TValue> : Container<TValue>
    {
        internal void Set(Container<TValue> source, Assembly patcher)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            var info = new PatchLog.Message();

            Action patch = () =>
            {
                try
                {
                    info.Patcher = patcher;

                    info.Target = this;

                    info.Source = source;

                    info.OldValue = Read();

                    var newValue = source.Read();

                    if (!Validate(newValue)) throw new InvalidOperationException($"'{newValue}' is invalid value");

                    Write(newValue);
                }
                catch (Exception e)
                {
                    info.Error = e;

                    throw new Exception(info.ToString(), e);
                }
                finally
                {
                    info.Log();
                }

            };

            AddPatch(patch, patcher);
        }

        protected abstract bool Validate(TValue value);

        protected abstract void AddPatch(Action patch, Assembly patcher);
    }
}