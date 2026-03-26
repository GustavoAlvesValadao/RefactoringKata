using Xunit;
using GildedRoseKata;
using GildedRoseKata.Models;

namespace GildedRoseTests;

public class BackstageUpdaterTests
{
    [Fact]
    public void BackstagePass_IncreasesQuality()
    {
        var items = new[] { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(21, items[0].Quality);
    }

    [Fact]
    public void BackstagePass_DropsToZeroAfterConcert()
    {
        var items = new[] { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 20 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(0, items[0].Quality);
    }

    [Fact]
    public void Backstage_IncreasesByThreeWhenSellInIsFiveOrLess()
    {
        var items = new[] { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(13, items[0].Quality);
    }

    [Fact]
    public void Backstage_IncreasesByTwoWhenSellInIsTenOrLess()
    {
        var items = new[] { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(12, items[0].Quality);
    }

    [Fact]
    public void Backstage_DropsToZeroAfterConcert()
    {
        var items = new[] { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(0, items[0].Quality);
    }
}