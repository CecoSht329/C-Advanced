using System;
using System.Linq;

class Program
{
    static void Main() => Console.ReadLine()
       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
       .Where(w => char.IsUpper(w[0]))
       .ToList()
       .ForEach(Console.WriteLine);

}

