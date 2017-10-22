using System;
namespace csharp
{
    public class AgedCheese : Item
    {
        protected override void UpdateQuality()
        {
            // Override behaviour
            // Increase quality, as long as quality is < MAX_QUALITY
            if (this.Quality < MAX_QUALITY)
                this.Quality += (this.SellIn >= 0) ? INDATE_QUALITY_CHANGE : EXPIRY_QUALITY_CHANGE;

            // in case value increases past max quality
            AdjustQualityToMaxValue();
        }
    }
}
