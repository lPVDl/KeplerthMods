using System.Reflection;
using System;

namespace ChassisMod.Wrappers
{
    internal sealed class Property<TObject, TData> : Property<TData>
    {
        public string Name { get; set; }
        public IWrapper<TObject> Owner { get; set; }
        public Func<TObject, TData> ReadData { get; set; }
        public Action<TObject, TData> WriteData { get; set; }
        public Func<TData, bool> ValidateData { get; set; }

        protected override TData Read() => ReadData(Owner.GetObject());

        protected override void Write(TData data) => WriteData(Owner.GetObject(), data);

        protected override bool Validate(TData data) => ValidateData(data);

        protected override void AddPatch(Action patch, Assembly patchOwner) => Owner.AddPatch(patch, patchOwner);

        public override string ToString() => $"{Owner}.{Name}";
    }

    public abstract class Property<TData>
    {
        private sealed class Container : Property<TData>
        {
            internal TData Value;

            internal Container() { }

            protected override TData Read() => Value;

            protected override void Write(TData data) => throw new InvalidOperationException($"Impossible to write into {nameof(Container)}");

            protected override bool Validate(TData data) => throw new InvalidOperationException($"Impossible to validate {nameof(Container)}");

            protected override void AddPatch(Action patch, Assembly patchOwner) => throw new InvalidOperationException($"Impossible to add patch {nameof(Container)}");

            public override string ToString() => Value.ToString();
        }

        public static implicit operator Property<TData> (TData data) => new Container() { Value = data };

        public void Set(Property<TData> source, Assembly patchOwner)
        {
            if (source == null) throw new ArgumentNullException("source was null");

            Action patch = () =>
            {
                var data = source.Read();
                if (!Validate(data)) throw new InvalidOperationException($"{this} = {source}");
                Write(data);
            };

            AddPatch(patch, patchOwner);
        }

        protected abstract TData Read();

        protected abstract void Write(TData data);

        protected abstract bool Validate(TData data);

        protected abstract void AddPatch(Action patch, Assembly patchOwner);
    }
}
