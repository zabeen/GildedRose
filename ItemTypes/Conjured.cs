using System;
namespace csharp
{
    public class Conjured : ItemType
    {
        public override void UpdateQuality()
        {
            // Override behaviour
            // As long as quality > 0
            // if sellin > 0, decrease quality by 2
            // else decrease quality by 4
            if (this.Quality > 0)
            {
                this.Quality -= (this.SellIn > 0) ? 2 : 4;
            }
        }
    }
}
