using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var uniuniqueElements = new SortedSet<string>();

        int linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            var compound = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var element in compound)
            {
                uniuniqueElements.Add(element);
            }
        }
        Console.WriteLine(string.Join(" ", uniuniqueElements));
    }
}

