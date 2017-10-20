using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class LegendarySellinTest
    {
        [Test]
        public void Legendary_Sellin_DoesNotChange()
        {
            IList<Item> items = new List<Item>
            {
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 20},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 20},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 20}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(10, items[0].SellIn);
            Assert.AreEqual(1, items[1].SellIn);
            Assert.AreEqual(0, items[2].SellIn);
            Assert.AreEqual(-1, items[3].SellIn);
        }
    }
}
