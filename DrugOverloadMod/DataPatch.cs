using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keplerth;
using Common;
using ChassisMod;
using ChassisMod.KeplerthDatabase;

namespace DrugOverloadMod
{
    [StaticConstructorOnStartup]
    internal static class DataPatch
    {
        static DataPatch()
        {
            try
            {
                StatusEffectDB.SpeedIII.Modifiers.Replace<StatusEffect.MovementSpeedMultiplier>(new StatusEffect.MovementSpeedMultiplier(3));
            }
            catch(Exception e) { Log.Exception(e); }
        }
    }
}
