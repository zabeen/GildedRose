using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<ItemType> Items;
        public GildedRose(IList<ItemType> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateSellin();
                item.UpdateQuality();
            }
        }
    }
}