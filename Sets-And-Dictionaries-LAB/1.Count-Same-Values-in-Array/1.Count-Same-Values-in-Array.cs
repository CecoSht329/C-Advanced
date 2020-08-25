using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numberCounter = new Dictionary<double, int>();

        var arrayOfDecimalNumbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
        foreach (var number in arrayOfDecimalNumbers)
        {
            if (!numberCounter.ContainsKey(number))
            {
                numberCounter.Add(number, 0);
            }
            numberCounter[number]++;
        }
        foreach (var kvp in numberCounter)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }

    }
}

