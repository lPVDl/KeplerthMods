using ChassisMod.Core;
using DataBase;

namespace ChassisMod
{
    public sealed class Food : DataWrapper<ConfigFood>
    {
        internal Food(string name, int id) : base (name, id) { }
    }
}
