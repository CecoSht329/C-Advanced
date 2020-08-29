using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();

        Console.WriteLine(numbers.Count);
        Console.WriteLine(numbers.Sum());
    }
}

