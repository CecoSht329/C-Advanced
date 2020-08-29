using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Where(x => x % 2 == 0)
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", numbers));
    }
}

