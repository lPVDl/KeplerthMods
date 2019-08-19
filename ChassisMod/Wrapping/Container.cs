namespace ChassisMod.Wrapping
{
    public abstract partial class Container<TValue>
    {       
        public static implicit operator Container<TValue> (TValue value) => new Data() { Value = value };

        protected abstract TValue Read();

        protected abstract void Write(TValue value);
    }
}
