using System.Collections.Generic;
using System.Reflection;

namespace Chassis.Entities
{
    internal interface IEntityManager
    {
        IEnumerable<IEntity> RuntimeEntities { get; }

        IEnumerable<IEntity> CompiledEntities { get; }

        bool CreationRequiresSource { get; }

        Entity.ManagerGroup NamingGroup { get; }

        IEntity Create(string entityName, IEntity source, Assembly patcher);

        IEnumerable<IPropertyInfo> GetProperties(IEntity entity);
    }
}
