using ChassisMod.Core;
using DataBase;

namespace ChassisMod
{
    public sealed class Weapon : Item, IWrapper<ConfigWeapon>
    {
        ConfigWeapon IWrapper<ConfigWeapon>.GetObject() => ConfigWeapon.Table[ID];

        internal Weapon() : base() { }

        public Weapon(string name, Weapon source) : base(name, source) { }
    }
}
