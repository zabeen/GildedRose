using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class Bridge : Item
    {
        public virtual void UpdateSellin()
        {
            this.SellIn--;
        }

        public abstract void UpdateQuality();
        public virtual void UpdateValue()
        {
            UpdateSellin();
            UpdateQuality();

        }
       
    }
}
