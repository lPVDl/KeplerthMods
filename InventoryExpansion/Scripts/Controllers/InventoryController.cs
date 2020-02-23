using Common;
using Keplerth;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryExpansion
{
    public static class InventoryController
    {
        public static int InventoryPanelIndex
        {
            get => _currentPanel;
            set
            {
                _currentPanel = Mathf.Clamp(value, 0, 9);
                for (var i = 0; i < 9; i++)
                    _inventoryPanels[i].SetActive(i + 1 == _currentPanel);
                for (var i = 0; i < 10; i++)
                    _navigationPanel.Buttons[i].SetSelected(i == _currentPanel);
                _navigationPanel.Buttons[_currentPanel].StopAnimation();
            }
        }

        private static GameObject[] _inventoryPanels = new GameObject[9];
        private static NavigationPanelView _navigationPanel;
        private static int _currentPanel;

        public static void Initialize()
        {
            

            // Create 9 * 30 inventory slots
            var panel = Config.BagInfoScript.BigBagButtonList[0].transform.parent.gameObject;
            var newList = new GameObject[310];
            Array.Copy(Config.BagInfoScript.BigBagButtonList, 0, newList, 0, 40);
            for (var i = 0; i < 9; i++)
                _inventoryPanels[i] = InventoryPanelBuilder.Build(panel, 40 + 30 * i, newList);
            Config.BagInfoScript.BigBagButtonList = newList;
            Config.BagInfoScript.MaxBagCount = 310;

            // Create navigation buttons
            _navigationPanel = NavigationPanelBuilder.Build(panel);
            for (var i = 0; i < 10; i++)
                _navigationPanel.Buttons[i].OnClicked += OnButtonClicked;         

            // Replace background sprite. Disable inventory title. Disable close inventory button.
            var grandPanel = panel.transform.parent;
            grandPanel.GetChild(0).GetComponent<Image>().sprite = Assets.InventoryBackground;
            grandPanel.GetChild(0).GetComponent<Image>().type = Image.Type.Sliced;
            grandPanel.GetChild(2).gameObject.SetActive(false);
            grandPanel.GetChild(3).gameObject.SetActive(false);

            InventoryPanelIndex = 0;
        }

        public static void OnItemMoved(int slotIndex)
        {
            if (slotIndex > 9)
            {
                var pageIndex = (slotIndex - 10) / 30;
                if (InventoryPanelIndex != pageIndex)
                    _navigationPanel.Buttons[pageIndex].PlayInteractionAnimation();
            }
        }

        private static void OnButtonClicked(NavigationButtonView button)
        {
            InventoryPanelIndex = _navigationPanel.Buttons.IndexOf(button);
        }
    }
}
