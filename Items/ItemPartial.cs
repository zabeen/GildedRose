using System;
namespace csharp
{
    public partial class Item
    {
        public const int MIN_QUALITY = 0;
        public const int MAX_QUALITY = 50;
        public const int INDATE_QUALITY_CHANGE = 1;
        public const int EXPIRY_QUALITY_CHANGE = 2;

        public void UpdateValues()
        {
            UpdateSellin();
            UpdateQuality();
        }

        protected virtual void UpdateSellin()
        {
            // default behaviour of all Item children
            // decrease Sellin by 1
            this.SellIn--;
        }

        protected virtual void UpdateQuality()
        {
            // keep empty as Update Quality logic varies
            return;
        }

        protected void AdjustQualityToMinValue()
        {
            if (this.Quality < MIN_QUALITY)
                this.Quality = MIN_QUALITY;
        }

        protected void AdjustQualityToMaxValue()
        {
            if (this.Quality > MAX_QUALITY)
                this.Quality = MAX_QUALITY;
        }
    }
}
