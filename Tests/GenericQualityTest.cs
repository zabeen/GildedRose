using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GenericQualityTest
    {
        [Test]
        public void Generic_Quality_DecreasesByOneBeforeExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 10},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(9, items[0].Quality);
            Assert.AreEqual(9, items[1].Quality);
        }

        [Test]
        public void Generic_Quality_DecreasesTwiceAsFastAfterExpiry()
        {
            IList<Item> items = new List<Item>
            {
                new Generic {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10},
                new Generic {Name = "Elixir of the Mongoose", SellIn = -1, Quality = 10}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(8, items[0].Quality);
            Assert.AreEqual(8, items[1].Quality);
        }
    }
}
