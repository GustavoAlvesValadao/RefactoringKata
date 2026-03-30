using GildedRoseKata.Models;

namespace GildedRoseKata.StrategyUpdaters;

public class ConjuredManaCakeItemUpdater : IItemUpdater
{
    public void Update(Item item)
    {
        item.SellIn--;
        if (item.Quality > 0) item.Quality--;
        if (item.Quality > 0) item.Quality--;

        if (item.SellIn < 0)
        {
            if (item.Quality > 0) item.Quality--;
            if (item.Quality > 0) item.Quality--;
        }
    }
}