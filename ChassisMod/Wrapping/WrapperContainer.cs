using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    internal sealed class WrapperContainer<TObject, TValue> : Container<TValue>
    {
        public string Name { get; set; }
        public IWrapper<TObject> Owner { get; set; }
        public Func<TObject, TValue> ReadValue { get; set; }
        public Action<TObject, TValue> WriteValue { get; set; }
        public Func<TValue, bool> ValidateValue { get; set; }

        protected override TValue Read() => ReadValue(Owner.GetObject());

        protected override void Write(TValue value) => WriteValue(Owner.GetObject(), value);

        protected override bool Validate(TValue value) => ValidateValue(value);

        protected override void AddPatch(Action patch, Assembly patcher) => Owner.AddPatch(patch, patcher);

        public override string ToString() => $"{Owner}.{Name}";
    }
}
