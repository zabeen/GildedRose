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
            IList<Item> items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(19, items[0].Quality);
            Assert.AreEqual(1, items[1].Quality);
            Assert.AreEqual(6, items[2].Quality);
            Assert.AreEqual(80, items[3].Quality);
            Assert.AreEqual(80, items[4].Quality);
            Assert.AreEqual(21, items[5].Quality);
            Assert.AreEqual(50, items[6].Quality);
            Assert.AreEqual(50, items[7].Quality);
        }

        [Test]
        public void CheckSellIn()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
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
        public void QualityNeverNegative()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 0}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreNotEqual(-1, items[0].Quality);
            Assert.AreNotEqual(-1, items[1].Quality);


        }
    }
}
