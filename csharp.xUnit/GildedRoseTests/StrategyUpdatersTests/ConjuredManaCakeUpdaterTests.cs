
using Xunit;
using GildedRoseKata;
using GildedRoseKata.Models;
namespace GildedRoseTests.StrategyUpdatersTests;

public class ConjuredManaCakeUpdaterTests
{    
    [Fact]
    public void ConjuredManaCake_QualityDropsToZeroAfterConcert()
    {
        var items = new[]
        {
            new Item
            {
                Name = "Conjured Mana Cake",
                SellIn = -1,
                Quality = 1
            }
        };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(0, items[0].Quality);
    }

    [Fact]
    public void Conjured_DegradesTwiceAsFast()
    {
        var items = new[] { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(8, items[0].Quality);
        Assert.Equal(2, items[0].SellIn);
    }

    [Fact]
    public void Conjured_DegradesFourTimesAfterExpiration()
    {
        var items = new[] { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 } };
        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.Equal(6, items[0].Quality);
    }
}