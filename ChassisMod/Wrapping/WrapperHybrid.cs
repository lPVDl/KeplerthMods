using System.Collections.Generic;

namespace ChassisMod.Wrapping
{
    public abstract class WrapperHybrid : IWrapperHybrid
    {
        string IWrapperHybrid.Name => _name;

        public int ID { get; }

        IEnumerable<IWrapperPropertyInfo> IWrapperHybrid.Properties
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private readonly string _name;

        internal protected WrapperHybrid(string name, int id)
        {
            _name = name;
            ID = id;
        }
    }
}
