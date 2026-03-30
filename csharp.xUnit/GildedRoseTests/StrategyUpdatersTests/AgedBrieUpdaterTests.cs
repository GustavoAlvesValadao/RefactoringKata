using Xunit;
using GildedRoseKata.Models;
using GildedRoseKata;

namespace GildedRoseTests.StrategyUpdatersTests;

public class AgedBrieUpdaterTests
{

    [Fact]
    public void AgedBrie_IncreasesQualityByOne_WhenUpdated()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(1, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_NeverExceeds50_WhenUpdateQuality()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(50, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_IncreaseQuality_WhenSellInIsZero()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(4, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_IncreasesQualityTwice_WhenExpired()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = -1, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(12, items[0].Quality);
    }
}