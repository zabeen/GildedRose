using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.SellIn = UpdateSellin(item.SellIn, item.Name);
                item.Quality = UpdateQualityOfItem(item);
            }
        }

        private int UpdateSellin(int sellin, string name)
        {
            if (name != "Sulfuras, Hand of Ragnaros")
            {
                sellin--;
            }
            return sellin;
        }

        private int UpdateQualityOfItem (Item item)
        {
            int quality = item.Quality;

            switch (item.Name)
            {
                case "Aged Brie":
                    if (item.Quality < 50)
                        quality++;
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    if (item.Quality < 50)
                    {
                        if (item.SellIn <= 0)
                        {
                            quality = 0;
                        }
                        else if (item.SellIn <= 5)
                        {
                            quality += 3;
                        }
                        else if (item.SellIn <= 10)
                        {
                            quality += 2;
                        }
                        else
                        {
                            quality++;
                        }
                    }
                    break;
                case "Conjured Mana Cake":
                    if (item.Quality > 0)
                    {
                        if (item.SellIn <= 0)
                        {
                            quality -= 4;
                        }
                        else
                        {
                            quality -= 2;
                        }
                    }
                    break;
                default:
                    if (item.Quality > 0)
                    {
                        if (item.SellIn <= 0)
                        {
                            quality -= 2;
                        }
                        else
                        {
                            quality--;
                        }
                    }
                    break;
            }

            return quality;
        }
    }
}