using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var n = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Func<int, bool> filter = x => x % 2 != 0;
            Console.WriteLine(string.Join(" ", numbers.Where(filter)));
        }
    }
}
