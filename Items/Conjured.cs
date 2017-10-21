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
                this.Quality -= (this.SellIn >= 0) ? INDATE_QUALITY_CHANGE*2 : EXPIRY_QUALITY_CHANGE*2;
            }

            // In case value falls below Minimum after change
            AdjustQualityToMinValue();
        }
    }
}
