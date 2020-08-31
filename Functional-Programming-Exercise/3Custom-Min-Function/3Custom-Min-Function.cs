using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> getSmallest = x => x.Min();

            Console.WriteLine(getSmallest(numbers));
        }
    }
}
