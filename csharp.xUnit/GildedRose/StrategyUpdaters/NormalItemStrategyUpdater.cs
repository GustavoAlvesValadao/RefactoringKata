using GildedRoseKata.Models;

namespace GildedRoseKata.StrategyUpdaters;

public class NormalItemUpdater : IItemUpdater
{
    public void Update(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }

        item.SellIn--;

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}