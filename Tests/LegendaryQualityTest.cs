using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class LegendaryQualityTest
    {
        [Test]
        public void LegendaryQualityDoesNotChange()
        {
            IList<Item> items = new List<Item>
            {
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 30},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 20},
                new Legendary {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(30, items[0].Quality);
            Assert.AreEqual(20, items[1].Quality);
            Assert.AreEqual(10, items[2].Quality);
        }
    }
}
