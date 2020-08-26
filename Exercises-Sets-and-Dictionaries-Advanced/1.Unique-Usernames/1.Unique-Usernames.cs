using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var names = new HashSet<string>();
        int linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            var name = Console.ReadLine();
            names.Add(name);
        }
        Console.WriteLine(string.Join(Environment.NewLine, names));
    }
}

