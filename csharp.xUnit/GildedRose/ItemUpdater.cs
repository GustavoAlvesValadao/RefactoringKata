using System;
using GildedRoseKata.Models;
using GildedRoseKata.Updaters;

namespace GildedRoseKata;

public class ItemUpdater
{
    public static void Update(Item item)
    {
        IItemUpdater updater = item.Name switch
        {
            "Aged Brie" => new AgedBrieUpdater(),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassUpdater(),
            "Sulfuras, Hand of Ragnaros" => new SulfurasUpdater(),
            "Conjured Mana Cake" => new ConjuredManaCakeItemUpdater(),
            _ => new NormalItemUpdater(),
        };
        updater.Update(item);
    }
}