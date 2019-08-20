using System.Reflection;

namespace ChassisMod.Wrapping
{
    partial class Wrapper<TConfig>
    {
        internal interface IPatchable<TValue>
        {
            Reader<TValue> Reader { get; }

            void Set(Reader<TValue> value, Assembly patcher);
        }
    }
}
