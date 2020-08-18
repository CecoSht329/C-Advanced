using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queueInfrontOfSuperMarket = new Queue<string>();

        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            
            if (input != "Paid")
            {
                queueInfrontOfSuperMarket.Enqueue(input);
            }
            else
            {
                while (queueInfrontOfSuperMarket.Count > 0)
                {
                    Console.WriteLine(queueInfrontOfSuperMarket.Dequeue());
                }
            }
        }
        Console.WriteLine($"{queueInfrontOfSuperMarket.Count} people remaining.");
    }
}

