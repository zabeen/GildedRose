using System;
namespace csharp
{
    public class AgedCheese : Item
    {
        protected override void UpdateQuality()
        {
            // Override behaviour for Aged Cheese
            // Increase quality by 1, as long as quality is < MAX_QUALITY
            if (this.Quality < MAX_QUALITY)
                this.Quality++;
        }
    }
}
