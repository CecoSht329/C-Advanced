using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //array with the lengths of the two sets 
        var setsLengths = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int fisrstLength = setsLengths[0];
        int secondLength = setsLengths[1];

        var firstSet = new HashSet<int>();
        var secondSet = new HashSet<int>();
        for (int i = 0; i < fisrstLength; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            firstSet.Add(currentNumber);
        }
        for (int i = 0; i < secondLength; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            secondSet.Add(currentNumber);
        }
        firstSet.IntersectWith(secondSet);
        Console.WriteLine(string.Join(" ", firstSet));
    }
}

