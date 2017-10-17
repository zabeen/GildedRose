using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Cheese : Bridge
    {
        private void UpdateSellin()
        {
            this.SellIn--;
        }
        private void UpdateQuality()
        {
            if (this.Quality < 50)
                this.Quality++;
        }
        public override void UpdateValue()
        {
            UpdateSellin();
            UpdateQuality();
        }
    }
}
