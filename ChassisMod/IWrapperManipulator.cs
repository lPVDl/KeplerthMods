using System.Collections.Generic;

namespace ChassisMod.Wrapping
{
    internal interface IWrapperHybrid
    {
        int ID { get; }
        string Name { get; }

        IEnumerable<IWrapperPropertyInfo> Properties { get; }
    }
}
