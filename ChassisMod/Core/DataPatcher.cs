using System.Collections.Generic;
using System.Reflection;
using Keplerth;
using Harmony;
using System;
using Common;

namespace ChassisMod.Core
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal sealed class ConfigPatcher
    {
        private sealed class Patch
        {
            public Action Action { get; set; }
            public Assembly Owner { get; set; }     
        }

        public static ConfigPatcher Instance { get; } = new ConfigPatcher();

        private static List<Patch> Patches { get; } = new List<Patch>();

        public static void Add(Action patch, Assembly patchOwner)
        {
            var patchData = new Patch()
            {
                Action = patch,
                Owner = patchOwner,
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
                catch(Exception e) { Log.Exception(e); }
            }
        }
    }
}
