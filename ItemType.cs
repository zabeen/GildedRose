using System;
namespace csharp
{
    public class ItemType : Item
    {
        public virtual void UpdateSellin()
        {
            this.SellIn--;
        }

        public virtual void UpdateQuality()
        {
            // default behaviour of ItemType is
            // as long as Quality > 0,
            // Quality goes down by 1 when Sellin > 0
            // else Quality goes down by 2

            if (this.Quality > 0)
            {
                if (this.SellIn > 0)
                {
                    this.Quality --;
                }
                else
                {
                    this.Quality-=2;
                }
            }
        }

    }
}
