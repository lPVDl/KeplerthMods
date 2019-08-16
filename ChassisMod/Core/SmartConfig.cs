namespace ChassisMod.Core
{
    public abstract class SmartConfig
    {
        internal static IPatcher DatabasePatcher { get; } = ConfigPatcher.Instance;

        public int ID { get => _id; internal set => _id.Set(value); }
        public string Name { get => _name; internal set => _name.Set(value); }
        public string Assembly { get => _assembly; internal set => _assembly.Set(value); }
        
        private readonly Readonly<int> _id = new Readonly<int>();
        private readonly Readonly<string> _name = new Readonly<string>();
        private readonly Readonly<string> _assembly = new Readonly<string>();

        internal SmartConfig() { }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
                return false;

            return (obj as SmartConfig).ID == ID;
        }

        public override int GetHashCode() => ID;

        public override string ToString() => _name;
    }
}
