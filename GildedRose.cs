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

        private int UpdateSellin(int sellin, string name)
        {
            if (name != "Sulfuras, Hand of Ragnaros")
            {
                sellin--;
            }
            return sellin;
        }
        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.SellIn = UpdateSellin(item.SellIn, item.Name);

                switch (item.Name)
                {
                    case "Aged Brie":
                        if (item.Quality < 50)
                            item.Quality++;
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                     
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (item.Quality < 50)
                        {
                            if (item.SellIn <= 0)
                            {
                                item.Quality = 0;
                            }
                            else if (item.SellIn <= 5)
                            {
                                item.Quality += 3;
                            }
                            else if (item.SellIn <= 10)
                            {
                                item.Quality += 2;
                            }
                            else
                            {
                                item.Quality++;
                            }
                        }
                        break;
                    default:
                        if (item.Quality > 0)
                        {
                            if (item.SellIn <= 0)
                            {
                                item.Quality = item.Quality - 2;
                            }
                            else
                            {
                                item.Quality--;
                            }
                        }
                        break;
                }

            }

            //for (var i = 0; i < Items.Count; i++)
            //{
            //    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //    {
            //        if (Items[i].Quality > 0)
            //        {
            //            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //            {
            //                Items[i].Quality = Items[i].Quality - 1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (Items[i].Quality < 50)
            //        {
            //            Items[i].Quality = Items[i].Quality + 1;

            //            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].SellIn < 11)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }

            //                if (Items[i].SellIn < 6)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //    {
            //        Items[i].SellIn = Items[i].SellIn - 1;
            //    }

            //    if (Items[i].SellIn < 0)
            //    {
            //        if (Items[i].Name != "Aged Brie")
            //        {
            //            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].Quality > 0)
            //                {
            //                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                    {
            //                        Items[i].Quality = Items[i].Quality - 1;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Items[i].Quality = Items[i].Quality - Items[i].Quality;
            //            }
            //        }
            //        else
            //        {
            //            if (Items[i].Quality < 50)
            //            {
            //                Items[i].Quality = Items[i].Quality + 1;
            //            }
            //        }
        }
    }
}
//    }
//}
