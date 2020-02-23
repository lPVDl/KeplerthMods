using UnityEngine;

namespace InventoryExpansion
{
    public static class InventoryGrid
    {
        private static readonly Vector2 CellSize = new Vector2(88, 88);
        private static readonly Vector2 Spacing = new Vector2(2, 2);
        private static readonly Vector2Int GridSize = new Vector2Int(10, 4);
        private static readonly Vector2 Offset;
        private static readonly Vector2 Anchor = new Vector2(0.5f, 0.5f);

        static InventoryGrid()
        {
            Offset = GridSize * CellSize * 0.5f;
            Offset += Spacing * new Vector2(GridSize.x - 1, GridSize.y - 1) * 0.5f;
            Offset += new Vector2(- CellSize.x * 0.5f, CellSize.y * 0.5f);
        }

        public static void SnapToGrid(RectTransform slot, int index)
        {
            var x = (CellSize.x + Spacing.x) * (index % 10);
            var y = (CellSize.y + Spacing.y) * (index / 10) + 15;
            slot.anchorMin = Anchor;
            slot.anchorMax = Anchor;
            slot.sizeDelta = CellSize;
            slot.anchoredPosition = new Vector2(x, y) - Offset;
        }
    }
}
