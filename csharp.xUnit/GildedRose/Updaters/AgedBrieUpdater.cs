using GildedRoseKata.Models;

namespace GildedRoseKata.Updaters;

public class AgedBrieUpdater : IItemUpdater
{
    public void Update(Item item)
    {

        if (item.SellIn <= 0)
        {
            if (item.Quality < 50) item.Quality++;
            if (item.Quality < 50) item.Quality++;
        }
        else
        {
            if (item.Quality < 50) item.Quality++;
        }
        item.SellIn--;
    }
}