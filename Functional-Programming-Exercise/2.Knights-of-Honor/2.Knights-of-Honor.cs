using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => "Sir " + x)
            .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
