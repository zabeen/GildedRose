using System;
namespace csharp
{
    public partial class Item
    {
        public const int MAX_QUALITY = 50;

        public void UpdateValues()
        {
            UpdateSellin();
            UpdateQuality();

            // enforce cap on Quality value
            if (this.Quality > MAX_QUALITY)
                this.Quality = MAX_QUALITY;
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
    }
}
