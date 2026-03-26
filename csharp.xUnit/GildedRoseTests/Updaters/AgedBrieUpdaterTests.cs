using Xunit;
using GildedRoseKata.Models;
using GildedRoseKata;

namespace GildedRoseTests.Updaters;

public class AgedBrieUpdaterTests
{

    [Fact]
    public void AgedBrie_IncreasesQualityByOne()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(1, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_Quality_NeverMoreThan50()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(50, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_QualityRaisesIfSellInIsZero()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(4, items[0].Quality);
    }

    [Fact]
    public void AgedBrie_IncreasesTwiceAfterExpiration()
    {
        var items = new[] { new Item { Name = "Aged Brie", SellIn = -1, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(12, items[0].Quality);
    }
}