using System.Collections.Generic;
using System.Reflection;
using Keplerth;
using Harmony;
using System;
using Common;

namespace ChassisMod.Patching
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal sealed class ConfigPatcher
    {
        private sealed class Patch
        {
            public Action Action { get; set; }
            public Assembly Patcher { get; set; }     
        }

        public static ConfigPatcher Instance { get; } = new ConfigPatcher();

        private static List<Patch> Patches { get; } = new List<Patch>();

        public static void Add(Action patch, Assembly patcher)
        {
            if (patch == null) throw new ArgumentNullException("patch was null");
            if (patcher == null) throw new ArgumentNullException("patcher was null");

            var patchData = new Patch()
            {
                Action = patch,
                Patcher = patcher,
            };

            Patches.Add(patchData);
        }

        private static void Postfix()
        {
            foreach(var patch in Patches)
            {
                try
                {
                    patch.Action();
                }
                catch(Exception e)
                {
                    Log.Exception(e);
                }
            }
        }
    }
}
