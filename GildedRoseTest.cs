using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void CheckQuality()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedCheese {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(19, items[0].Quality);
            Assert.AreEqual(1, items[1].Quality);
            Assert.AreEqual(6, items[2].Quality);
            Assert.AreEqual(80, items[3].Quality);
            Assert.AreEqual(80, items[4].Quality);
            Assert.AreEqual(21, items[5].Quality);
            Assert.AreEqual(51, items[6].Quality);
            Assert.AreEqual(52, items[7].Quality);
        }

        [Test]
        public void CheckSellIn()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedCheese {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(1, items[1].SellIn);
            Assert.AreEqual(4, items[2].SellIn);
            Assert.AreEqual(0, items[3].SellIn);
            Assert.AreEqual(-1, items[4].SellIn);
            Assert.AreEqual(14, items[5].SellIn);
            Assert.AreEqual(9, items[6].SellIn);
            Assert.AreEqual(4, items[7].SellIn);
        }

        [Test]
        public void QualityRemainsAt0()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 0}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);


        }

        [Test]
        public void QualityRemainedAt50()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new AgedCheese {Name = "Aged Brie", SellIn = 2, Quality = 50},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 50}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(50, items[1].Quality);
        }

        [Test]
        public void QualityDecreasesTwiceAsFast ()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 0, Quality = 12}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(8, items[0].Quality);
            Assert.AreEqual(10, items[1].Quality);
        }

        [Test]
        public void Quality_IncreasesByTwo_WhenSellin10OrLess()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 21},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 22}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(22, items[0].Quality);
            Assert.AreEqual(23, items[1].Quality);
            Assert.AreEqual(24, items[2].Quality);
        }

        [Test]
        public void Quality_IncreasesByThree_WhenSellin5OrLess()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 21},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 22}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(23, items[0].Quality);
            Assert.AreEqual(24, items[1].Quality);
            Assert.AreEqual(25, items[2].Quality);
        }

        [Test]
        public void Quality_DropsToZero_WhenSellIn0()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 21},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -2, Quality = 22}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(0, items[1].Quality);
            Assert.AreEqual(0, items[2].Quality);
        }
        [Test]
        public void ConjureItemDecreasesBy2()
        {
            IList<ItemType> items = new List<ItemType>
            {
                new Conjured {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                new Conjured {Name = "Conjured Mana Cake", SellIn = 0, Quality = 8}

            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(4, items[0].Quality);
            Assert.AreEqual(4, items[1].Quality);
        }
    }
}
