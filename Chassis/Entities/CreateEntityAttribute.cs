using System;

namespace Chassis.Entities
{ 
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class CreateEntityAttribute : Attribute
    {
        public string Source { get; set; }
    }
       
}
