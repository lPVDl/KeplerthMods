using System.Collections.Generic;
using Chassis.Patching;

namespace Chassis.Entities
{
    internal interface IEntityManager
    {
        IEnumerable<IEntity> RuntimeEntities { get; }

        IEnumerable<IEntity> CompiledEntities { get; }

        bool CreationRequiresSource { get; }

        Entity.ManagerGroup NamingGroup { get; }

        IEntity Create(string entityName, IEntity source, IInvokationAddress patcher);

        IEnumerable<IPropertyInfo> GetProperties(IEntity entity);
    }
}
