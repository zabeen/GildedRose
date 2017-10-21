using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ConjuredQualityTest
    {
        [Test]
        public void Conjured_Quality_DecreasesByTwoBeforeExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new Conjured {Name = "Conjured Mana Cake", SellIn = 10, Quality = 10},
                new Conjured {Name = "Conjured Mana Cake", SellIn = 5, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(8, items[0].Quality);
            Assert.AreEqual(8, items[1].Quality);
        }

        [Test]
        public void Conjured_Quality_DecreasesByFourAfterExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new Conjured {Name = "Conjured Mana Cake", SellIn = 0, Quality = 10},
                new Conjured {Name = "Conjured Mana Cake", SellIn = -1, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(6, items[0].Quality);
            Assert.AreEqual(6, items[1].Quality);
        }
    }
}
