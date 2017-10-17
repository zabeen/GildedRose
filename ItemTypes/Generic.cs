using System;
namespace csharp
{
    public class Generic : ItemType
    {
        public override void UpdateQuality()
        {
            // override behaviour of Generic is
            // as long as Quality > 0,
            // Quality goes down by 1 when Sellin > 0
            // else Quality goes down by 2

            if (this.Quality > 0)
            {
                if (this.SellIn > 0)
                {
                    this.Quality--;
                }
                else
                {
                    this.Quality -= 2;
                }
            }
        }
    }
}
