using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(x => "Sir " + x)
               .ToList()
               .ForEach(x => Console.WriteLine(string.Join(Environment.NewLine, x)));

        }
    }
}
