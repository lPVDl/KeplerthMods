using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    partial class Container<TValue>
    {
        protected sealed class ContainerWithData : Container<TValue>
        {
            internal TValue Value;

            internal ContainerWithData() { }

            protected override TValue Read() => Value;

            protected override void Write(TValue value) => throw new InvalidOperationException($"Impossible to write into {nameof(ContainerWithData)}");

            protected override bool Validate(TValue value) => throw new InvalidOperationException($"Impossible to validate {nameof(ContainerWithData)}");

            protected override void AddPatch(Action patch, Assembly patcher) => throw new InvalidOperationException($"Impossible to patch {nameof(ContainerWithData)}");

            public override string ToString() => Value.ToString();
        }
    } 
}
