using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Conjure : Bridge
    {
        public override void UpdateQuality()
        {
            if (this.Quality > 0)
            {
                if (this.SellIn <= 0)
                {
                    this.Quality -= 4;
                }
                else
                {
                    this.Quality -= 2;
                }
            }
        }
    }
}
