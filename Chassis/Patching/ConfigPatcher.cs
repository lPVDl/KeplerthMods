using System.Collections.Generic;
using Keplerth;
using Harmony;
using System;
using Common;

namespace Chassis.Patching
{
    [HarmonyPatch(typeof(Init), "InitTableData")]
    internal static class ConfigPatcher
    {
        private sealed class Patch
        {
            public Action Action { get; set; }
            public IInvokationAddress Owner { get; set; }    
        }

        public static event Action PatchingStarted;
        public static event Action PatchingEnded;

        private static readonly List<Patch> Patches = new List<Patch>();
        private static readonly List<string> IgnoredAssemblies = new List<string>();
        private static bool PatchingNow;

        public static void Add(Action patch, IInvokationAddress patcher)
        {
            if (PatchingNow) throw new InvalidOperationException("Tried to add new patch while patching was running"); 
            if (patch == null) throw new ArgumentNullException("patch was null");
            if (patcher == null) throw new ArgumentNullException("patcherAddress was null");

            var patchData = new Patch()
            {
                Action = patch,
                Owner = patcher,
            };

            Patches.Add(patchData);
        }

        private static void Postfix()
        {
            if (!PatchingNow)
            {
                PatchingNow = true;
                PatchLog.WriteLine();
                PatchLog.WriteLine("===PATCHING STARTED===");
                try { PatchingStarted?.Invoke(); }
                catch (Exception e) { Log.Exception(e); }
            }                   

            foreach(var patch in Patches)
            {
                var asmName = patch.Owner.Assembly.GetName().Name;

                if (IgnoredAssemblies.Contains(asmName)) continue;

                try { patch.Action(); }
                catch(Exception e)
                {
                    Log.Message("Patch error: " + e.Message + Environment.NewLine + e.StackTrace);
                    Log.Message("Patch created:" + Environment.NewLine + patch.Owner.StackTrace);
                    IgnoredAssemblies.Add(asmName);
                    PatchLog.WriteLine($"[{nameof(Chassis)}] Moved '{asmName}.dll' to blacklist.");
                    PatchLog.WriteLine("===RELOADING===");
                    Init.InitTableData();
                }
            }

            if (PatchingNow)
            {
                PatchingNow = false;
                PatchLog.WriteLine("===PATCHING ENDED===");
                try { PatchingEnded?.Invoke(); }
                catch (Exception e) { Log.Exception(e); }
            }
            
        }
    }
}
