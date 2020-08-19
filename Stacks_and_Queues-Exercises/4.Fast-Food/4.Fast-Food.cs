using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int quantityFood = int.Parse(Console.ReadLine());
        int[] orders = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> queue = new Queue<int>(orders);
        int biggestOrder = int.MinValue;
        foreach (int order in orders)
        {
            if (order > biggestOrder)
            {
                biggestOrder = order;
            }
            if (quantityFood >= order)
            {
                quantityFood -= order;
                queue.Dequeue();
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(biggestOrder);
        if (queue.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}

