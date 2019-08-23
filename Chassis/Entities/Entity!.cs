using System.Collections.Generic;
using Chassis.Patching;
using System.Reflection;
using System.Linq;
using Common;
using System;

namespace Chassis.Entities
{
    public static partial class Entity
    {
        internal class ManagerGroup
        {
            public IEnumerable<IEntityManager> Managers { get; private set; }

            public ManagerGroup(params IEntityManager[] managers)
            {
                if (managers.Count() == 0) throw new ArgumentException("managers must have at least one element");
                if (managers.Contains(null)) throw new ArgumentNullException("managers contains null");

                Managers = managers;
            }
        }

        private static class RuntimeEntityCash<T>
        {
            public static IEnumerable<T> Values;
        }

        private static class CompiledEntityCash<T>
        {
            public static IEnumerable<T> Values;
        }

        private static class PropertyCash<TObject, TInterface>
        {
            public static IEnumerable<PropertyInfo> Values;
        }

        private class Manager<T>
        {
            public static readonly IEntityManager Instance = Managers.Single(e => e.GetType() == typeof(T));
        }

        private class Registration
        {
            public IEntity Entity { get; private set; }
            public FieldAttribute<CreateEntityAttribute> InitializationAddress { get; private set; }

            public string AssemblyName => InitializationAddress.Assembly.GetName().Name;

            public static Registration Process(CreationRequest request)
            {
                var owner = new InvokationAddress(request.Address.Assembly, request.Address.ToString());
                var entity = request.Manager.Create(request.EntityName, request.Source, owner);
                request.Address.Field.SetValue(null, entity);

                return new Registration()
                {
                    Entity = entity,
                    InitializationAddress = request.Address
                };
            }

            private Registration() { }
        }

        private struct FieldAttribute<T> where T : Attribute
        {
            public Assembly Assembly { get; private set; }
            public Type Class { get; private set; }
            public FieldInfo Field { get; private set; }
            public T Attribute { get; private set; }

            public override string ToString() => $"({Assembly.GetName().Name}.dll)[{Attribute.GetType().Name}]{Class}.{Field.Name}";

            public static IEnumerable<FieldAttribute<T>> GetAll(Assembly assembly)
            {
                return from @class in assembly.GetTypes()
                       from field in @class.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
                       from attr in field.GetCustomAttributes<T>()
                       select new FieldAttribute<T>()
                       {
                           Assembly = assembly,
                           Class = @class,
                           Field = field,
                           Attribute = attr
                       };
            }
        }

        private struct CreationRequest
        {
            public string EntityName { get; set; }
            public IEntityManager Manager { get; private set; }
            public IEntity Source { get; private set; }
            public FieldAttribute<CreateEntityAttribute> Address { get; private set; }

            public static CreationRequest Convert(FieldAttribute<CreateEntityAttribute> address)
            {
                var entityName = address.Field.Name;
                var entityType = address.Field.FieldType;
                var sourceName = address.Attribute.Source;

                if (!address.Field.IsStatic) throw new Exception($"{address} is not static. All fields with {nameof(CreateEntityAttribute)} must be static");

                var manager = Managers.FirstOrDefault(m => m.GetType() == entityType);
                if (manager == null)
                {
                    var validTypes = string.Join(") or (", Managers.Select(x => x.GetType().Name));
                    throw new Exception($"{address} has invalid type ({entityType}). Expected ({validTypes})");
                }

                var sameNames = from mgr in manager.NamingGroup.Managers
                                from ent in mgr.CompiledEntities
                                where Equal(ent.Name, entityName)
                                select ent;
                if (sameNames.Count() > 0) NameOccupiedException("Keplerth", sameNames.First());

                var modHolder = Registrations.FirstOrDefault(x => Equal(x.Entity.Name, entityName));
                if (modHolder != null) NameOccupiedException(modHolder.AssemblyName, modHolder.Entity);

                if (sourceName == "") throw new Exception($"{address}: Source can not empty string");
                IEntity source = null;
                if (sourceName == null && manager.CreationRequiresSource) throw new Exception($"{address}: Source can not be null for ({entityType.Name})");
                if (sourceName != null)
                {
                    source = manager.CompiledEntities.SingleOrDefault(e => string.Compare(e.Name, sourceName, true) == 0);
                    if (source == null)
                    {
                        var message = $"{address}: Source ({entityType.Name}.{sourceName}) was not found.";
                        var predictedNames = from mgr in Managers
                                             from ent in mgr.CompiledEntities
                                             where Equal(ent.Name, sourceName)
                                             select $"{ent.GetType().Name}.{ent.Name}";
                        if (predictedNames.Count() > 0)
                        {
                            var predictMessage = string.Join(") or (", predictedNames);
                            throw new Exception($"{message} Did you mean ({predictMessage})?");
                        }

                        throw new Exception(message);
                    }
                }

                return new CreationRequest()
                {
                    EntityName = entityName,
                    Manager = manager,
                    Source = source,
                    Address = address
                };

                bool Equal(string a, string b) => string.Compare(a, b, true) == 0;

                void NameOccupiedException(string assemblyName, IEntity entity)
                {
                    var addr = string.Join(".", assemblyName, entity.GetType().Name, entity.Name);

                    throw new Exception($"{address}: Name '{entityName}' was already occupied by {addr}({entity.ID})");
                }
            }
        }

        internal static IEnumerable<IEntityManager> Managers { get; }
        private static readonly List<string> Assemblies = new List<string>();
        private static readonly List<Registration> Registrations = new List<Registration>();

        static Entity()
        {
            try
            {
                Managers = from type in Assembly.GetExecutingAssembly().GetTypes()
                           where type.GetInterfaces().Contains(typeof(IEntityManager))
                           let cctor = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).Single()
                           select cctor.Invoke(new object[cctor.GetParameters().Length]) as IEntityManager;
            }
            catch (Exception e) { Log.Exception(e); }
        }

        public static void InitializeAttributes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException("assembly was null");
            var asmName = assembly.GetName().Name;
            if (Assemblies.Contains(asmName)) throw new InvalidOperationException($"Assembly {asmName} was already initialized");
            Assemblies.Add(asmName);

            var requests = from attr in FieldAttribute<CreateEntityAttribute>.GetAll(assembly)
                           select CreationRequest.Convert(attr);

            var regs = from req in requests select Registration.Process(req);
            Registrations.AddRange(regs);
        }

        internal static IEnumerable<T> FindCompiledEntitiesCashed<T>() where T : class
        {
            var cash = CompiledEntityCash<T>.Values;

            if (cash != null) { return cash; }

            var type = typeof(T);

            cash = from field in type.GetFields(BindingFlags.Public | BindingFlags.Static)
                   where field.IsStatic && field.IsInitOnly && field.FieldType == type
                   let value = field.GetValue(null)
                   where value != null
                   select value as T;

            CompiledEntityCash<T>.Values = cash;

            return cash;
        }

        internal static IEnumerable<T> CreateRuntimeEntitiesCashed<T>(Func<IEnumerable<int>> getIDs, Func<int, string> getNameOrNull, Func<int, string, T> createInstance)
        {
            if (getIDs == null) throw new ArgumentNullException("getIDs was null");
            if (getNameOrNull == null) throw new ArgumentNullException("getNameOrNull was null");
            if (createInstance == null) throw new ArgumentNullException("createInstance was null");

            var cash = RuntimeEntityCash<T>.Values;

            if (cash == null || cash.Count() == 0) { cash = CreateRuntimeEntities(getIDs, getNameOrNull, createInstance); }

            RuntimeEntityCash<T>.Values = cash;

            return cash;
        }

        private static IEnumerable<T> CreateRuntimeEntities<T>(Func<IEnumerable<int>> getIDs, Func<int, string> getNameOrNull, Func<int, string, T> createInstance)
        {
            var typeName = typeof(T).Name;
            var ids = getIDs();
            var names = ids.Select(x => getNameOrNull(x) ?? typeName + x).ToArray();

            // Remove duplicated names. [Bob, Steve, Bob] => [Bob0, Steve, Bob1]
            for (var i = 0; i < names.Length; i++)
            {
                for (var j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        var name = names[i];
                        var counter = 0;
                        for (var p = i; p < names.Length; p++)
                            if (names[p] == name)
                            {
                                names[p] += counter;
                                counter++;
                            }
                    }
                }
            }

            return ids.Zip(names, (id, name) => createInstance(id, name));
        }

        internal static IEntityManager GetManager<T>() where T : IEntityManager => Manager<T>.Instance;

        internal static IEnumerable<TValue> GetPropertyValues<TObject, TValue>(TObject obj) where TValue : class
        {
            if (obj == null) throw new NullReferenceException("obj was null");

            var cash = PropertyCash<TObject, TValue>.Values;
            if (cash == null)
            {
                cash = from prop in typeof(TObject).GetProperties()
                       where prop.CanRead
                       let value = prop.GetValue(obj)
                       where value != null && value is TValue
                       select prop;
            }
            PropertyCash<TObject, TValue>.Values = cash;

            return cash.Select(x => x.GetValue(obj) as TValue);
        }        
    }
}
