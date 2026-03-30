using Xunit;
using GildedRoseKata;
using GildedRoseKata.Models;

namespace GildedRoseTests.StrategyUpdatersTests;

public class SulfurasUpdaterTests
{
    [Fact]
    public void Sulfuras_NeverChangesQuality()
    {
        var items = new[] { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(80, items[0].Quality);
    }

    [Fact]
    public void Sulfuras_NeverChangesSellIn()
    {
        var items = new[] { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(0, items[0].SellIn);
    }

    [Fact]
    public void Sulfuras_NeverChanges()
    {
        var items = new[] { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(80, items[0].Quality);
        Assert.Equal(0, items[0].SellIn);
    }
}