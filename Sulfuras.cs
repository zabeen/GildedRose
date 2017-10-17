using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Sulfuras : Item
    {
        readonly IList<Sulfuras> _sulfurasLst;

        private Sulfuras(IList<Sulfuras> sulfurasLst)
        {
            _sulfurasLst = sulfurasLst;
        }

        public Sulfuras()
        {
                
        }

        private int UpdateSellin(int sellin)
        {
            return sellin;
        }
        private int UpdateQuality(int quality)
        {
            return quality;
        }
        public void UpdateValue()
        {
            foreach (var sulfuras in _sulfurasLst)
            {
                sulfuras.SellIn = sulfuras.UpdateSellin(sulfuras.SellIn);
                sulfuras.Quality = sulfuras.UpdateQuality(sulfuras.Quality);
            }
        }


    }

}
