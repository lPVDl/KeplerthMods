using System;

namespace ChassisMod.Wrapping
{
    partial class Container<TValue>
    {
        protected sealed class Data : Container<TValue>
        {
            internal TValue Value { get; set; }

            internal Data() { }

            internal override TValue Read() => Value;

            internal override void Write(TValue value) => throw new NotSupportedException($"Impossible to write into data container)");

            public override string ToString() => Value.ToString();
        }
    } 
}
