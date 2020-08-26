using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var occurences = new Dictionary<int, int>();//number => occurences

        int linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (!occurences.ContainsKey(number))
            {
                occurences.Add(number, 0);
            }
            occurences[number]++;
        }
        Console.WriteLine();
        foreach (var kvp in occurences.Where(x => x.Value % 2 == 0))
        {
            Console.WriteLine(kvp.Key);
        }
    }
}

