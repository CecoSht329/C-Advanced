using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var occurences = new SortedDictionary<char, int>();

        var text = Console.ReadLine();
        foreach (var symbol in text)
        {
            if (!occurences.ContainsKey(symbol))
            {
                occurences.Add(symbol, 0);
            }
            occurences[symbol]++;
        }
        foreach (var kvp in occurences)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}

