using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Sulfuras : Bridge
    {
        private void UpdateSellin()
        {
            // nothing to do
        }
        private void UpdateQuality()
        {
            // nothing to do
        }
        public override void UpdateValue()
        {
            UpdateSellin();
            UpdateQuality();
        }
    }

}
