using Common;
using Keplerth;
using System;

namespace Chassis
{
    [StaticConstructorOnStartup]
    public static class DataExport
    {
        static DataExport()
        {
            try
            {
                //SpriteScanner.ExportAll(@"T:/Keplerth/Sprites/");
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}
