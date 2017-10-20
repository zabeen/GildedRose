using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class ItemSellinTest
    {
        [Test]
        public void Item_Sellin_DecreasesByOneOnUpdate()
        {
            // Sellin of these items should decrease
            IList<Item> items = new List<Item>{
                new Generic {Name = "+5 Dexterity Vest", SellIn = 20, Quality = 20},
                new Generic {Name = "Elixir of the Mongoose", SellIn = 10, Quality = 20},
                new AgedCheese {Name = "Aged Brie", SellIn = 1, Quality = 20},
                new BackstagePass {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20},
                new Conjured {Name = "Conjured Mana Cake", SellIn = -1, Quality = 20}
            };

            GildedRose app = new GildedRose(items);
            app.UpdateQuality();

            Assert.AreEqual(19, items[0].SellIn);
            Assert.AreEqual(9, items[1].SellIn);
            Assert.AreEqual(0, items[2].SellIn);
            Assert.AreEqual(-1, items[3].SellIn);
            Assert.AreEqual(-2, items[4].SellIn);
        }
    }
}
