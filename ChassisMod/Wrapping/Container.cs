namespace ChassisMod.Wrapping
{
    public abstract partial class Container<TValue>
    {       
        public static implicit operator Container<TValue> (TValue value) => new Data() { Value = value };

        internal virtual string Format(TValue value)
        {
            if (value == null) return "null";

            return value.ToString();
        }

        internal abstract TValue Read();

        internal abstract void Write(TValue value);
    }
}
