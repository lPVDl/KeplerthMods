using System;

namespace ChassisMod.Core
{
    internal abstract class DataPatch
    {
        public string Description { get; protected set; }
        public Action PatchAction { get; protected set; }
    }
}
