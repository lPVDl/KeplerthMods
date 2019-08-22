//using System.Collections.Generic;
//using System.Reflection;
//using Common.Extensions;
//using System.Linq;
//using System;
//using Common;

//namespace ChassisMod
//{
//    public static class PatchCenter
//    {
//        public sealed class Exception : System.Exception
//        {
//            internal Exception(string message) : base(message) { }
//        }

//        private static readonly List<string> PatchedAssemblies = new List<string>();

//        private static readonly IEnumerable<Type> ValidTypes;

//        static PatchCenter()
//        {
//            try
//            {
//                ValidTypes = from type in Assembly.GetExecutingAssembly().GetTypes()
//                             from inter in type.GetInterfaces()
//                             where inter == typeof(IWrapperHybrid)
//                             select type;
//            }
//            catch (System.Exception e) { Log.Exception(e); }
//        }

//        private static Dictionary<Type, IEnumerable<PropertyInfo>> Entities = new Dictionary<Type, IEnumerable<PropertyInfo>>();
//        private static Dictionary<Type, IEnumerable<string>> EntityNames = new Dictionary<Type, IEnumerable<string>>();

//        public static void CreateEntities(Assembly assembly)
//        {
//            if (assembly == null) throw new ArgumentNullException("assembly was null");

//            var assemblyName = assembly.GetName().Name;
//            if (PatchedAssemblies.Contains(assemblyName)) throw new InvalidOperationException($"{assemblyName}.dll has been already patched");

//            PatchedAssemblies.Add(assemblyName);


//            var creationAttributes = GetAttributes<CreateFromAttribute>(assembly);

//            foreach (var (@class, field, attr) in creationAttributes)
//            {
//                var targetName = field.Name;

//                if (!field.IsStatic) throw new Exception($"{@class}.{targetName} was not static. All fields with {nameof(CreateFromAttribute)} must be static");

//                var targetType = field.FieldType;

//                if (!ValidTypes.Contains(targetType))
//                {
//                    var validTypes = string.Join(") or (", from t in ValidTypes select t.Name);
//                    throw new Exception($"{@class}.{targetName} was invalid type ({targetType.Name}). Expected ({validTypes})");
//                }

//                var sourceName = attr.Name;

//                if (string.IsNullOrEmpty(sourceName)) throw new Exception($"[{nameof(CreateFromAttribute)}(name)]{@class}.{targetName} had null or empty name");

//                var entities = Entities.Cash(targetType, x => x.GetProperties(BindingFlags.Public | BindingFlags.Static));

//                var copyFrom = entities.FirstOrDefault(x => x.Name == sourceName);

//                if (copyFrom == null) throw new Exception($"{@class}.{targetName} can not be created - {targetType.Name}.{sourceName} was not found (wrong name?)");

//                foreach (var t in ValidTypes)
//                {
//                    var names = EntityNames.Cash(t, x => t.GetProperties(BindingFlags.Public | BindingFlags.Static).Select(y => y.Name));

//                    var occupiedName = names.FirstOrDefault(x => x == targetName);

//                    if (occupiedName != null) throw new Exception($"{@class}.{targetName} can not be created - name '{targetName}' was already occupied by {t.Name}.{occupiedName}." +
//                        $"\nPlease, choose another name to avoid ambiguity in the patch log.");
//                }
//            }

//        }

//        private struct AttributeInfo
//        {
//            public Type Class { get; set; }
//            public FieldInfo Field { get; set; }
//            public Attribute Attribute { get; set; }
//        }

//        private static IEnumerable<Tuple<Type, FieldInfo, T>> GetAttributes<T>(Assembly assembly) where T : Attribute
//        {
//            return from @class in assembly.GetTypes()
//                   from field in @class.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
//                   from attr in field.GetCustomAttributes<T>()
//                   select Tuple.Create(@class, field, attr);
//        }
//    }


//}
