using System.Collections.Generic;
using Keplerth;
using Harmony;
using System;
using Common;

namespace ChassisMod.Core
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal static class DataPatcher
    {
        private static List<DataPatch> patches = new List<DataPatch>();

        public static void Add(DataPatch patch)
        {
            patches.Add(patch);
        }

        private static void Postfix()
        {
            foreach(var patch in patches)
            {
                try
                {
                    patch.PatchAction();
                    PatchLog.WriteLine(patch.Description);
                }
                catch(Exception e) { Log.Exception(e, patch.Description); }
            }
        }
    }
}
