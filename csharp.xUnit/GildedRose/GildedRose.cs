using System.Collections.Generic;
using GildedRoseKata.Models;
using GildedRoseKata.Updaters;

namespace GildedRoseKata;

public class GildedRose(IList<Item> Items)
{
    readonly IList<Item> Items = Items;

    public void UpdateQuality()
    {
        ItemUpdater updater = new();

        foreach (var item in Items)
        {
            ItemUpdater.Update(item);
        }
    }
}