using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        IList<Bridge> Items;

        public GildedRose(IList<Bridge> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateValue();
            }
        }
    }
}