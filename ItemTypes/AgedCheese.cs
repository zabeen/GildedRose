using System;
namespace csharp
{
    public class AgedCheese : ItemType
    {
        public override void UpdateQuality()
        {
            // Override behaviour for Aged Cheese
            // Increase quality by 1, as long as quality is < 50
            if (this.Quality < 50)
                this.Quality++;
        }
    }
}
