namespace Chassis.Wrapping
{
    public abstract partial class Reader<TValue>
    {       
        public static implicit operator Reader<TValue> (TValue value) => new Data(value);

        internal abstract TValue Read();
    }
}
