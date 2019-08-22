//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;

//namespace Chassis
//{
//    partial class Entity
//    {
//        private class CreationRequest
//        {
//            private readonly FieldAttribute<CreateAttribute> _attribute;
//            private readonly string _entityName;
//            private readonly IEntityManager _manager;

//            private CreationRequest(FieldAttribute<CreateAttribute> attribute)
//            {
//                attribute.ValidateFieldStatic();

//                _entityName = attribute.Field.Name;
//                _manager = attribute.FindAcceptableManager();

//            }

//            private void ValidateName()
//            {
//                if (string.IsNullOrEmpty(_entityName)) throw new Exception()
//            }

//            public static IEnumerable<CreationRequest> Load(Assembly assembly)
//            {
//                var attrs = FieldAttribute<CreateAttribute>.Load(assembly);

//                return attrs.Select(x => new CreationRequest(x));
//            }
//        }
//    }
//}
