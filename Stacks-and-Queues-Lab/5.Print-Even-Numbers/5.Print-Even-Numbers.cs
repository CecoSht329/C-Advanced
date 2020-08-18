using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> queue = new Queue<int>(numbers.Where(x => x % 2 == 0));

        Console.WriteLine(string.Join(", ", queue));
    }
}

