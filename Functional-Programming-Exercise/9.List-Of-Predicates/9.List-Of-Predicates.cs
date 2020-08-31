using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.List_Of_Predicates
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var numberSequense = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (DividersInfo(i, dividers))
                {
                    numberSequense.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numberSequense));
        }
        static bool DividersInfo(int n, List<int> dividers)
        {
            bool isTrue = true;
            foreach (var divider in dividers)
            {
                if (n % divider != 0)
                {
                    return false;
                }
            }
            return isTrue;
        }
    }
}
