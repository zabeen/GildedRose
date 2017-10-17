using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Cheese : Bridge
    {
        public override void UpdateQuality()
        {
            if (this.Quality < 50)
                this.Quality++;
        }
    }
}
