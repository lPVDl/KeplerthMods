//using System;

//namespace ChassisMod
//{
//    public abstract class Entity
//    {
//        protected sealed class Readonly<TValue>
//        {
//            private TValue _value;
//            private bool _hasValue;

//            public void Set(TValue value)
//            {
//                if (_hasValue) throw new InvalidOperationException("Tried to set value more than once");
//                if (typeof(TValue).IsClass && Equals(value, null)) throw new ArgumentNullException("Tried to set null");

//                _hasValue = true;
//                _value = value;
//            }

//            public TValue Get()
//            {
//                if (!_hasValue) throw new InvalidOperationException("Tried to get unitialized value");

//                return _value;
//            }
//        }

//        public virtual int ID { get => id.Get(); internal set => id.Set(value); }
//        public virtual string Name { get => name.Get(); internal set => name.Set(value); }
        
//        protected readonly Readonly<int> id = new Readonly<int>();
//        protected readonly Readonly<string> name = new Readonly<string>();

//        internal Entity() { }

//        public override bool Equals(object obj)
//        {
//            if (obj == null || obj.GetType() != GetType())
//                return false;

//            return (obj as Entity).ID == ID;
//        }

//        public override int GetHashCode() => ID;

//        public override string ToString() => Name;
//    }
//}
