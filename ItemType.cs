using System;
namespace csharp
{
    public abstract class ItemType : Item
    {
        public virtual void UpdateSellin()
        {
            // default behaviour of all ItemTypes:
            // decrease Sellin by 1
            this.SellIn--;
        }

        public abstract void UpdateQuality();

    }
}
