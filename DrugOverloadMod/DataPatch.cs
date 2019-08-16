using ChassisMod.KeplerthDatabase;
using ChassisMod;
using Keplerth;
using Common;
using System;

namespace DrugOverloadMod
{
    [StaticConstructorOnStartup]
    internal static class DataPatch
    {
        static DataPatch()
        {
            try
            {
                EffectDB.SpeedIII.Modifiers.Replace<Effect.MovementSpeedMul>(new Effect.MovementSpeedMul(2));
            }
            catch (Exception e) { Log.Exception(e); }
        }
    }
}
