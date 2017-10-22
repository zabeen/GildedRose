﻿using System;
namespace csharp
{
    public class BackstagePass : Item
    {
        protected override void UpdateQuality()
        {
            // Override behaviour
            // if sellin < 0, set quality to 0 - return
            // Else, As long as quality < MAX_QUALITY:
            // if sellin < 5, increase quality by 3
            // else if sellin < 10, increase quality by 2
            // else increase quality by 1

            if (this.SellIn < 0)
            {
                this.Quality = 0;
                return;
            }

            if (this.Quality < MAX_QUALITY)
            {
                if (this.SellIn < 5)
                {
                    this.Quality += 3;
                }
                else if (this.SellIn < 10)
                {
                    this.Quality += 2;
                }
                else
                {
                    this.Quality++;
                }

                // in case value increases past max quality
                AdjustQualityToMaxValue();
            }
        }
    }
}
