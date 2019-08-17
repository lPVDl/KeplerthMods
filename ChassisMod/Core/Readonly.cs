using System;

namespace ChassisMod.Core
{
    internal sealed class Readonly<TValue>
    {
        private TValue _value;
        private bool _hasValue;

        public void Set(TValue value)
        {
            if (_hasValue) throw new InvalidOperationException("Tried to set value more than once");
            if (typeof(TValue).IsClass && Equals(value, null)) throw new ArgumentNullException("Tried to set null");

            _hasValue = true;
            _value = value;
        }

        public TValue Get()
        {
            if (!_hasValue) throw new InvalidOperationException("Tried to get unitialized value");

            return _value;
        }
    }
}
