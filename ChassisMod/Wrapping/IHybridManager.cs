using System.Collections.Generic;

namespace ChassisMod.Wrapping
{
    internal interface IHybridManager
    {
        IEnumerable<IHybrid> RuntimeInstances { get; }

        IEnumerable<IHybrid> CompiledInstances { get; }

        IEnumerable<IWrapperPropertyInfo> GetProperties(IHybrid hybrid);
    }
}
