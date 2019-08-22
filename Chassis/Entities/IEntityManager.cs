using System.Collections.Generic;
using System.Reflection;

namespace Chassis.Entities
{
    internal interface IEntityManager
    {
        IEnumerable<IEntity> RuntimeEntities { get; }

        IEnumerable<IEntity> CompiledEntities { get; }

        bool RequiresSourceForCreation { get; }

        Entity.ManagerGroup NamingGroup { get; }

        IEntity Create(Assembly owner, string entityName, IEntity source);

        IEnumerable<IPropertyInfo> GetProperties(IEntity entity);
    }
}
