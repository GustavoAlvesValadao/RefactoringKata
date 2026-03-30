using System;
using System.Collections.Generic;

namespace GildedRoseKata.Models;

public static class PrintInventory
{
    public static void Print(IList<Item> items, int day)
    {
        Console.WriteLine($"-------- day {day} --------");
        Console.WriteLine("name, sellIn, quality");

        foreach (var item in items)
        {
            Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
        }

        Console.WriteLine();
    }
}