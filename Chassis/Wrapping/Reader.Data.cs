namespace Chassis.Wrapping
{
    partial class Reader<TValue>
    {
        protected sealed class Data : Reader<TValue>
        {
            private readonly TValue _value;

            internal Data(TValue value) { _value = value; }

            internal override TValue Read() => _value;

            public override string ToString()
            {
                if (_value == null) return "null";

                return _value.ToString();
            }
        }
    } 
}
