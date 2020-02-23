using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryExpansion
{
    public static class NavigationPanelBuilder
    {
        public static NavigationPanelView Build(GameObject inventoryPanel)
        {
            var panel = new GameObject();
            var transform = panel.AddComponent<RectTransform>();
            transform.SetParent(inventoryPanel.transform.parent, false);
            //transform.anchoredPosition = new Vector2(0, 175);
            transform.anchoredPosition = new Vector2(0, 165);

            var grid = panel.AddComponent<GridLayoutGroup>();
            grid.cellSize = new Vector2(inventoryPanel.GetComponent<GridLayoutGroup>().cellSize.x, 24);
            grid.spacing = inventoryPanel.GetComponent<GridLayoutGroup>().spacing;
            grid.constraint = GridLayoutGroup.Constraint.FixedRowCount;
            grid.constraintCount = 1;
            grid.childAlignment = TextAnchor.MiddleCenter;

            var buttons = new List<NavigationButtonView>();
            panel.AddComponent<NavigationPanelView>().Buttons = buttons;

            for (var i = 0; i < 10; i++)
            {
                var button = new GameObject();
                var view = button.AddComponent<NavigationButtonView>();
                buttons.Add(view);

                view.SetSelected(false);
                view.SetParent(panel.transform);
            }

            return panel.GetComponent<NavigationPanelView>();
        }
    }
}
