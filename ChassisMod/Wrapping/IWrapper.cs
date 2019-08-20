using System.Reflection;
using DataBase;
using System;

namespace ChassisMod.Wrapping
{
    internal interface IWrapper<TConfig> where TConfig : DBBase
    {
        TConfig GetConfig();

        void AddPatch(Action patch, Assembly patcher);
    }
}
