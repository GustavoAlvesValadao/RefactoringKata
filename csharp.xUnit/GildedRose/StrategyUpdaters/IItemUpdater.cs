using GildedRoseKata.Models;

namespace GildedRoseKata.StrategyUpdaters;

public interface IItemUpdater
{
    void Update(Item item);
}