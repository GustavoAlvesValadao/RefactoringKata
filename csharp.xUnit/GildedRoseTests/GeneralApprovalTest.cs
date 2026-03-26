using Xunit;
using GildedRoseKata;
using GildedRoseKata.Models;
using System.Threading.Tasks;
using System.IO;
using System;
using VerifyXunit;

namespace GildedRoseTests;

public class GeneralApprovalTest
{

    [Fact]
    public void Quality_NeverNegativeForAnyItem()
    {
        var items = new[]
        {
        new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 0 },
        new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 0 },
        new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 0 },
        new Item { Name = "Aged Brie", SellIn = 3, Quality = 0 },
        new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 3, Quality = 0 },
        new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 0 },
    };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.True(items[0].Quality >= 0);
        Assert.True(items[1].Quality >= 0);
        Assert.True(items[2].Quality >= 0);
        Assert.True(items[3].Quality >= 0);
        Assert.True(items[4].Quality >= 0);
        Assert.True(items[5].Quality >= 0);
    }

    [Fact]
    public void Quality_NeverBeMoreThan50()
    {
        var items = new[]
        {
        new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 },
        new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 50 },
        new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 50 },
        new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 50 },
        new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 50 },
        new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 50 },
    };

        var app = new GildedRose(items);

        app.UpdateQuality();

        Assert.True(items[0].Quality <= 50);
        Assert.True(items[1].Quality <= 50);
        Assert.True(items[2].Quality <= 50);
        Assert.True(items[3].Quality <= 50);
        Assert.True(items[4].Quality <= 50);
    }

    [Fact]
    public Task ThirtyDays()
    {
        var fakeoutput = new System.Text.StringBuilder();
        Console.SetOut(new StringWriter(fakeoutput));
        Console.SetIn(new StringReader($"a{Environment.NewLine}"));

        Program.Main(["30"]);
        var output = fakeoutput.ToString();

        return Verifier.Verify(output);
    }
}