using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Default : Bridge
    {
        private void UpdateSellin()
        {
            this.SellIn--;
        }
        private void UpdateQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality -= (this.SellIn <= 0) ? 2 : 1;
            }
        }
        public override void UpdateValue()
        {
            UpdateSellin();
            UpdateQuality();

        }
    }
}
