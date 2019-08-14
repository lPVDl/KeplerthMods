using System;

namespace ChassisMod.Core
{
    internal sealed class DataPatch
    {
        public string Description { get; set; }
        public Action PatchAction { get; set; }
    }
}
