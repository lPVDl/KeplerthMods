using Common;
using System;
using UnityEngine;

namespace InventoryExpansion
{
    public static class Assets
    {
        public static readonly Sprite InventoryPageButtonNormal;
        public static readonly Sprite InventoryPageButtonSelected;
        public static readonly Sprite InventoryPageButtonWarning;

        public static readonly Sprite InventoryBackground;

        static Assets()
        {
            try
            {
                var assets = AssetBundle.LoadFromMemory(Properties.Resource.Assets);

                InventoryPageButtonNormal = assets.LoadAsset<Sprite>("InventoryPageButtonNormal");
                InventoryPageButtonSelected = assets.LoadAsset<Sprite>("InventoryPageButtonSelected");
                InventoryPageButtonWarning = assets.LoadAsset<Sprite>("InventoryPageButtonWarning");
                InventoryBackground = assets.LoadAsset<Sprite>("InventoryBackground");
            }
            catch (Exception e)
            {
                Log.Exception(e);
            }
        }
    }
}
