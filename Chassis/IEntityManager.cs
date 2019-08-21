using System.Collections.Generic;

namespace Chassis
{
    internal interface IEntityManager
    {
        IEnumerable<IEntity> RuntimeInstances { get; }

        IEnumerable<IEntity> CompiledInstances { get; }

        IEnumerable<IPropertyInfo> GetProperties(IEntity entity);
    }
}
