using System;
using System.Collections.Generic;
using System.Linq;

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
        Console.WriteLine(string.Join(Environment.NewLine, occurences.Select(x => $"{x.Key}: {x.Value} time/s")));
        //foreach (var kvp in occurences)
        //{
        //    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        //}
    }
}

