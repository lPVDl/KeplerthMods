using System.Reflection;
using Keplerth;
using Harmony;

namespace Common
{
    [StaticConstructorOnStartup]
    internal static class HarmonyPatcher
    {
        public static HarmonyInstance Instance { get; }

        static HarmonyPatcher()
        {
            try
            {
                var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                Instance = HarmonyInstance.Create(assemblyName);
                Instance.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (System.Exception e) { Log.ExceptionOnce(e); }
        }
    }
}
