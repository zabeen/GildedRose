using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class AgedCheeseQualityTest
    {
        [Test]
        public void AgedCheese_Quality_IncreasesByOneBeforeExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new AgedCheese {Name = "Aged Brie", SellIn = 10, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(11, items[0].Quality);
        }

        [Test]
        public void AgedCheese_Quality_IncreasesByTwoAfterExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new AgedCheese {Name = "Aged Brie", SellIn = 0, Quality = 10},
                new AgedCheese {Name = "Aged Brie", SellIn = -1, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(12, items[0].Quality);
            Assert.AreEqual(12, items[1].Quality);
        }
    }
}
