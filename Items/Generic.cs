using System;
namespace csharp
{
    public class Generic : Item
    {
        public const int INDATE_INCREASE = 1;
        public const int EXPIRY_INCREASE = 2;

        protected override void UpdateQuality()
        {
            // override behaviour of Generic is
            // as long as Quality > 0,
            // Quality goes down by 1 when Sellin > 0
            // else Quality goes down by 2
            if (this.Quality > 0)
            {
                this.Quality -= (this.SellIn > 0) ? INDATE_INCREASE : EXPIRY_INCREASE;
            }
        }
    }
}
