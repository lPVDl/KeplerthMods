using ChassisMod.Core;
using DataBase;

namespace ChassisMod
{
    public sealed class StatusEffect : DataWrapper<ConfigBuff>
    {
        internal StatusEffect(string name, int id) : base (name, id) { }
    }
}
