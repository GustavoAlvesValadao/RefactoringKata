using System;
using System.Collections.Generic;

namespace GildedRoseKata.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = ItemFactory.CreateItems();

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            PrintInventory.Print(items, i);
            app.UpdateQuality();
        }
    }
}