using Chassis.Entities;
using DataBase;

namespace Chassis.Wrapping
{
    internal sealed class WeaponWrapper : Wrapper<ConfigWeapon>
    {
        public WeaponWrapper(IEntity owner) : base(owner) { }

        public void Initialize(WeaponWrapper source, IInvokationAddress patcher, bool log) => Initialize(source, x => { }, patcher, log);
    }
}
