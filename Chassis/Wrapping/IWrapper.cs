using System.Reflection;
using DataBase;
using System;

namespace Chassis.Wrapping
{
    internal interface IWrapper<TConfig> where TConfig : DBBase
    {
        TConfig GetConfig();

        void AddPatch(Action patch, Assembly patcher);
    }
}
