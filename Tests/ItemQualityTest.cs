using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ItemQualityTest
    {
        // These tests apply to all classes of type, Item

        [Test]
        public void Item_Quality_DoesNotGoBelowMinQuality()
        {
            IList<Item> items = new List<Item>
            {
                // all these items decrease in value - initialise Quality at 0
                new Generic {Name = "+5 Dexterity Vest", SellIn = 0, Quality = Item.MIN_QUALITY},
                new Generic {Name = "Elixir of the Mongoose", SellIn = -1, Quality = Item.MIN_QUALITY},
                new Conjured {Name = "Conjured Mana Cake", SellIn = -2, Quality = Item.MIN_QUALITY+1}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(0, items[2].Quality);
        }

        [Test]
        public void Item_Quality_DoesNotGoOverMaxQuality()
        {
            IList<Item> items = new List<Item>
            {
                // these items increase in Quality
                new AgedCheese {Name = "Aged Brie", SellIn = 15, Quality = Item.MAX_QUALITY},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = Item.MAX_QUALITY}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(Item.MAX_QUALITY, items[0].Quality);
            Assert.AreEqual(Item.MAX_QUALITY, items[1].Quality);
        }
    }
}
