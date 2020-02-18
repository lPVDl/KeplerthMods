using Common;
using Keplerth;
using System;

namespace Chassis
{
    [StaticConstructorOnStartup]
    public class DataExport
    {
        public DataExport()
        {
            try
            {
                SpriteScanner.ExportAll(@"T:/Keplerth/Sprites/");
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}
