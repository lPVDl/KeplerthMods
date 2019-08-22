using System;

namespace Chassis.Entities
{
    partial class Entity
    {
        [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
        public sealed class CreateAttribute : Attribute
        {
            public string SourceName { get; set; }
        }
    }
    
}
