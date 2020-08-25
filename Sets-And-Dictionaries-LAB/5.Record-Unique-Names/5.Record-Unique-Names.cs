using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int namesCount = int.Parse(Console.ReadLine());
        var uniqueNames = new HashSet<string>();
        for (int i = 0; i < namesCount; i++)
        {
            string name = Console.ReadLine();
            uniqueNames.Add(name);
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
    }
}

