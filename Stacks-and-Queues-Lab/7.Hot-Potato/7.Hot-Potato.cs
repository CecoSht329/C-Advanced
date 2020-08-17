using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int tosses = int.Parse(Console.ReadLine());

        Queue<string> kids = new Queue<string>(input
            .Split(" ", StringSplitOptions.RemoveEmptyEntries));
        while (kids.Count > 1)
        {
            for (int i = 1; i < tosses; i++)
            {
                string kid = kids.Dequeue();
                kids.Enqueue(kid);
            }
            Console.WriteLine($"Removed {kids.Dequeue()}");
        }
        Console.WriteLine($"Last is {kids.Dequeue()}");
    }
}

