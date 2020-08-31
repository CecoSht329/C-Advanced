using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Custom_Comparator
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers.Sort();

            Func<int, bool> filterEven = x => x % 2 == 0;
            Func<int, bool> filterOdd = x => x % 2 != 0;

            Console.WriteLine($"{string.Join(" ", numbers.Where(filterEven))} {string.Join(" ", numbers.Where(filterOdd))}");
        }
    }
}
