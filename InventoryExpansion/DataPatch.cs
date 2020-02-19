using Common;
using Keplerth;
using System;

namespace InventoryExpansion
{
    [StaticConstructorOnStartup]
    public static class DataPatch
    {
        static DataPatch()
        {
            try
            {
                Log.Message("This mod is running");
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}
