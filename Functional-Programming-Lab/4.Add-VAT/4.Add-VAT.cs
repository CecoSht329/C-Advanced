using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var prices = Console.ReadLine()
            .Split(", ")
            .Select(decimal.Parse)
            .Select(x => x + x * 0.2m)
            .ToList();

        foreach (var price in prices)
        {
            Console.WriteLine($"{price:f2}");
        }
    }
}

