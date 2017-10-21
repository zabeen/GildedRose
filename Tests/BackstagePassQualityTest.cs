using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class BackstagePassQualityTest
    {
        [Test]
        public void BackstagePass_Quality_IncreasesByTwoWhenSellinTenOrLess()
        {
            IList<Item> items = new List<Item>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 30},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 40}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(22, items[0].Quality);
            Assert.AreEqual(32, items[1].Quality);
            Assert.AreEqual(42, items[2].Quality);
        }

        [Test]
        public void BackstagePass_Quality_IncreasesByThreeWhenSellinFiveOrLess()
        {
            IList<Item> items = new List<Item>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 30},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 40}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(23, items[0].Quality);
            Assert.AreEqual(33, items[1].Quality);
            Assert.AreEqual(43, items[2].Quality);
        }

        [Test]
        public void BackstagePass_Quality_DropsToZeroOnExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 40}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
        }
    }
}
