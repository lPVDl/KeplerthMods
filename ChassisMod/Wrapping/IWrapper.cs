using System.Reflection;
using System;

namespace ChassisMod.Wrapping
{
    interface IWrapper<T>
    {
        T GetObject();
        void AddPatch(Action action, Assembly patchOwner);
    }
}
