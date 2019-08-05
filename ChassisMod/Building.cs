using ChassisMod.Core;
using DataBase;

namespace ChassisMod
{
    public sealed class Building : DataWrapper<ConfigPlacement>
    {
        internal Building(string name, int id) : base(name, id) { }
    }
}
