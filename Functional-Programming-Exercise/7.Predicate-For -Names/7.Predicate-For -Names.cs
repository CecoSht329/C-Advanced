using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Predicate_For__Names
{
    class Program
    {
        static void Main()
        {
            var desiredLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= desiredLength)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
