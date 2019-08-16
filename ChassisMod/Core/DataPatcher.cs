using System.Collections.Generic;
using Keplerth;
using Harmony;
using System;
using Common;

namespace ChassisMod.Core
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal sealed class ConfigPatcher : IPatcher
    {
        private sealed class Patch
        {
            public Action Action { get; set; }
            public string Info { get; set; }        
        }

        public static ConfigPatcher Instance { get; } = new ConfigPatcher();

        private static List<Patch> Patches { get; } = new List<Patch>();

        void IPatcher.Add(Action action, string info) => Patches.Add(new Patch() { Action = action, Info = info });

        private static void Postfix()
        {
            foreach(var patch in Patches)
            {
                try
                {
                    patch.Action();
                    PatchLog.WriteLine(patch.Info);
                }
                catch(Exception e) { Log.Exception(e, patch.Info); }
            }
        }
    }
}
