using System.Collections.Generic;
using GildedRoseKata.Models;
using GildedRoseKata.StrategyUpdaters;

namespace GildedRoseKata;

public class GildedRose(IList<Item> Items)
{
    readonly IList<Item> Items = Items;

    public void UpdateQuality()
    {
        _ = new ItemUpdater();

        foreach (var item in Items)
        {
            ItemUpdater.Update(item);
        }
    }
}