using Keplerth;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryExpansion
{
    public class InventoryPanelBuilder
    {
        public static GameObject Build(GameObject source, int indexOffset, GameObject[] resultBuffer)
        {
            var panel = GameObject.Instantiate(source, source.transform.parent);
            for (var i = 0; i < panel.transform.childCount; i++)
            {
                var button = panel.transform.GetChild(i).gameObject;
                var index = ParseIndex(button.name);

                button.GetComponent<BigBagItem>().enabled = false;
                button.GetComponent<Image>().enabled = false;
                button.GetComponent<Button>().enabled = false;

                if (index > 9)
                {
                    var patchedIndex = index + indexOffset - 10;
                    resultBuffer[patchedIndex] = button;
                    button.GetComponent<Image>().enabled = true;
                    button.GetComponent<Button>().enabled = true;
                    button.GetComponent<BigBagItem>().enabled = true;
                }
            }

            return panel;
        }

        private static int ParseIndex(string name)
        {
            var start = name.IndexOf("(") + 1;
            var end = name.IndexOf(")") - 1;
            var index = name.Substring(start, end - start + 1);
            return int.Parse(index);
        }
    }
}
