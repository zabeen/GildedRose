using System;
namespace csharp
{
    public class Conjured : Item
    {
        protected override void UpdateQuality()
        {
            // Override behaviour
            // As long as quality > 0
            // decrease quality twice as much as Generic Item
            if (this.Quality > 0)
            {
                this.Quality -= (this.SellIn > 0) ? Generic.INDATE_INCREASE*2 : Generic.EXPIRY_INCREASE*2;
            }
        }
    }
}
