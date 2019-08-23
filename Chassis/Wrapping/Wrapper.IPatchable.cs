using Chassis.Patching;

namespace Chassis.Wrapping
{
    partial class Wrapper<TConfig>
    {
        internal interface IPatchable<TValue>
        {
            Reader<TValue> Reader { get; }

            void Set(Reader<TValue> value, IInvokationAddress patcher);
        }
    }
}
