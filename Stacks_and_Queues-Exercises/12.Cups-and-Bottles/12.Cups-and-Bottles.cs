using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] cupsSequence = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] bottlesSequence = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> cups = new Queue<int>(cupsSequence);
        Stack<int> bottles = new Stack<int>(bottlesSequence);

        int wastedWater = 0;
        while (cups.Any() && bottles.Any())
        {
            int bottle = bottles.Peek();
            int cup = cups.Peek();
            if (bottle - cup >= 0)
            {
                bottles.Pop();
                cups.Dequeue();
                wastedWater += bottle - cup;
            }
            else
            {
                while (cup - bottle > 0)
                {
                    cup -= bottle;
                    bottles.Pop();
                    bottle = bottles.Peek();
                }
                cups.Dequeue();
                bottles.Pop();
                wastedWater += bottle - cup;
            }
        }
        if (!cups.Any())
        {
            Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
        }
        else if (!bottles.Any())
        {
            Console.WriteLine($"Cups: {string.Join(" ", cups)}");
        }
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
    }
}

