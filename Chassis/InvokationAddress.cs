using System.Reflection;

namespace Chassis
{
    internal interface IInvokationAddress
    {
        Assembly Assembly { get; }
        string StackTrace { get; }
    }

    internal class InvokationAddress : IInvokationAddress
    {
        public Assembly Assembly { get; set; }
        public string StackTrace { get; set; }

        public InvokationAddress(Assembly patcher, string stackTrace)
        {
            Assembly = patcher;
            StackTrace = stackTrace;
        }
    }
}
