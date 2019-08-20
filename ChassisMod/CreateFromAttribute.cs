using System;

namespace ChassisMod
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class CreateFromAttribute : Attribute
    {
        internal string Name { get; }

        public CreateFromAttribute(string name)
        {
            Name = name;
        }
    }
}
