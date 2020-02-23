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
                for (var i = 0; i < _inventorySlots.Length - 10; i++)
                {
                    var panelIndex = i / 30;
                    var transform = _inventorySlots[i + 10].GetComponent<RectTransform>();
                    InventoryGrid.SnapToGrid(transform, panelIndex == _currentPanel ? (i % 30 + 10) : 1000);
                }
                for (var i = 0; i < 10; i++)
                    _navigationPanel.Buttons[i].SetSelected(i == _currentPanel);
                _navigationPanel.Buttons[_currentPanel].StopAnimation();
            }
        }

        private static GameObject[] _inventorySlots;
        private static NavigationPanelView _navigationPanel;
        private static int _currentPanel;

        public static void Initialize()
        {
            InitializeInventorySlots();
            FixCraftSlots();

            // Create navigation buttons
            var panel = _inventorySlots[0].transform.parent;
            _navigationPanel = NavigationPanelBuilder.Build(panel.gameObject);
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

        private static void InitializeInventorySlots()
        {
            _inventorySlots = new GameObject[310];
            Array.Copy(Config.BagInfoScript.BigBagButtonList, 0, _inventorySlots, 0, 40);
            Config.BagInfoScript.BigBagButtonList = _inventorySlots;
            Config.BagInfoScript.MaxBagCount = 310;
            

            var panel = _inventorySlots[0].transform.parent;
            for (var j = 0; j < 9; j++)
            {
                var indexOffset = 40 + j * 30;
                for (var i = 10; i < 40; i++)
                {
                    var index = i - 10 + indexOffset;
                    var button = GameObject.Instantiate(_inventorySlots[0], panel.transform);
                    button.name = "Button (" + index + ")";
                    _inventorySlots[index] = button;
                }
            }

            panel.GetComponent<GridLayoutGroup>().enabled = false;
            for (var i = 0; i < 40; i++)
                InventoryGrid.SnapToGrid(Config.BagInfoScript.BigBagButtonList[i].GetComponent<RectTransform>(), i);
        }

        private static void FixCraftSlots()
        {
            Config.BagInfoScript.MainMaterialStartIndex = 1000;
            for (var i = 0; i < Config.CraftInfoScript.baseItemButtons.Length; i++)
            {
                var button = Config.CraftInfoScript.baseItemButtons[i];
                button.name = "BaseItemButton (" + (1000 + i) + ")";
                button.GetComponent<BagItem>().index = 1000 + i;
            }
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
