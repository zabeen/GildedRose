using System;
namespace csharp
{
    public class BackstagePass : Item
    {
        protected override void UpdateQuality()
        {
            // Override behaviour
            // As long as quality < MAX_QUALITY
            // if sellin <= 0, set quality to 0
            // else if sellin <= 5, increase quality by 3
            // else if sellin <= 10, increase quality by 2
            // else increase quality by 1
            if (this.Quality < MAX_QUALITY)
            {
                if (this.SellIn <= 0)
                {
                    this.Quality = 0;
                }
                else if (this.SellIn <= 5)
                {
                    this.Quality += 3;
                }
                else if (this.SellIn <= 10)
                {
                    this.Quality += 2;
                }
                else
                {
                    this.Quality++;
                }
            }
        }
    }
}
