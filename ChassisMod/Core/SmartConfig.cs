namespace ChassisMod.Core
{
    public abstract class Entity
    {
        public virtual int ID { get => _id.Get(); internal set => _id.Set(value); }
        public virtual string Name { get => _name.Get(); internal set => _name.Set(value); }
        
        private readonly Readonly<int> _id = new Readonly<int>();
        private readonly Readonly<string> _name = new Readonly<string>();

        internal Entity() { }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            return (obj as Entity).ID == ID;
        }

        public override int GetHashCode() => ID;

        public override string ToString() => Name;
    }
}
