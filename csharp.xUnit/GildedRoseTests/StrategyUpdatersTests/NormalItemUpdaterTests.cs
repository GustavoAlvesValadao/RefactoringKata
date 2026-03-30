using Xunit;
using GildedRoseKata;
using GildedRoseKata.Models;

namespace GildedRoseTests.StrategyUpdatersTests;

public class NormalItemUpdaterTests
{
    [Fact]
    public void NormalItem_DecreasesQualityByOne()
    {
        var items = new[] { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(19, items[0].Quality);
    }

    [Fact]
    public void NormalItem_DecreasesSellInByOne()
    {
        var items = new[] { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(9, items[0].SellIn);
    }

    [Fact]
    public void NormalItem_QualityNeverBeNegative()
    {
        var items = new[] { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(0, items[0].Quality);
    }

    [Fact]
    public void NormalItem_DegradesTwiceAsFastAfterSellDate()
    {
        var items = new[] { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(18, items[0].Quality);
    }

    [Fact]
    public void NormalItem_DegradesTwiceAfterExpiration()
    {
        var items = new[] { new Item { Name = "Elixir", SellIn = 0, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(8, items[0].Quality);
    }

}