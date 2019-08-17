using System.Reflection;
using System;

namespace ChassisMod.Wrappers
{
    interface IWrapper<T>
    {
        T GetObject();
        void AddPatch(Action action, Assembly patchOwner);
    }
}
