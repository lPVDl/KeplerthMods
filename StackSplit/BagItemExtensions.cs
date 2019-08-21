using UnityEngine;
using DataBase;
using Keplerth;

namespace StackSplit
{
    internal static class BagItemExtensions
    {
        public static void FillWithPickedItem(this BagItem bagSlot, int maxCount)
        {
            var items = bagSlot.GetBagItems(BaseBagItem.MouseOnBagIndex);
            if (items.ContainsKey(bagSlot.index))
            {
                var maxHold = ConfigItem.getMaxCount(items[bagSlot.index].id);
                if (items[bagSlot.index].id == BaseBag.PickItem.id && maxHold > 1)
                {
                    var sent = Mathf.Min(maxHold - items[bagSlot.index].count, BaseBag.PickItem.count, maxCount);
                    BaseBag.PickItem.count -= sent;
                    items[bagSlot.index].count += sent;
                }
                else
                {
                    var temp = BaseBag.PickItem;
                    BaseBag.PickItem = items[bagSlot.index];
                    items[bagSlot.index] = temp;
                }
            }
            else
            {
                items[bagSlot.index] = new ItemData(BaseBag.PickItem);
                var sent = Mathf.Min(maxCount, BaseBag.PickItem.count);
                items[bagSlot.index].count = sent;              
                BaseBag.PickItem.count -= sent;
            }

            bagSlot.ShowItemInfo();
            BaseBag.ShowPickItem();
        }
    }
}
