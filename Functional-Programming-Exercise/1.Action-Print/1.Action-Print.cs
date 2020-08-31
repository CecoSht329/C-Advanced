using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Action_Print
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printWords = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            printWords(words);
        }
    }
}
