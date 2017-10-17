using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class BackStagePass : Bridge
    {
        public override void UpdateQuality()
        {
            if (this.Quality < 50)
            {
                if (this.SellIn <= 0)
                {
                    this.Quality = 0;
                }
                else if (this.SellIn <= 5)
                {
                    this.Quality += 3;
                }
                else if (this.SellIn <= 10)
                {
                    this.Quality += 2;
                }
                else
                {
                    this.Quality++;
                }
            }
        }

    }
}
