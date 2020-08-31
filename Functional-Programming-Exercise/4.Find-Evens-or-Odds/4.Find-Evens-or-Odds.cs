using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            var bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = bounds[0];
            int end = bounds[1];
            var sortOfNumbers = Console.ReadLine();

            Predicate<int> filter = x => sortOfNumbers == "odd" ? x % 2 != 0 : x % 2 == 0;

            var numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}
