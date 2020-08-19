using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Queue<int[]> pumps = new Queue<int[]>();
        FillQueue(n, pumps);

        int counter = 0;

        while (true)
        {
            int fuelAmount = 0;
            bool foundPoint = true;

            for (int i = 0; i < n; i++)
            {
                int[] currentPump = pumps.Dequeue();

                fuelAmount += currentPump[0];

                if (fuelAmount < currentPump[1])
                {
                    foundPoint = false;
                }

                fuelAmount -= currentPump[1];
                pumps.Enqueue(currentPump);
            }
            if (foundPoint)
            {
                break;
            }
            counter++;
            pumps.Enqueue(pumps.Dequeue());//this makes the circle simulation in the Queue
        }
        Console.WriteLine(counter);
    }

    private static void FillQueue(int n, Queue<int[]> pumps)
    {
        for (int i = 0; i < n; i++)
        {
            int[] currentPump = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            pumps.Enqueue(currentPump);
        }
    }
}

