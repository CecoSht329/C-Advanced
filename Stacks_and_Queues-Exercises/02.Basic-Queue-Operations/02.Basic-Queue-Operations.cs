using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int numberOfElementsToEnqueue = numbers[0];
        int numberOfElementsToDequeue = numbers[1];
        int numberToLookFor = numbers[2];
        int[] numbersToGoInQueue = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> queueNumbers = new Queue<int>();
        for (int i = 0; i < numberOfElementsToEnqueue; i++)
        {
            queueNumbers.Enqueue(numbersToGoInQueue[i]);
        }
        for (int i = 0; i < numberOfElementsToDequeue; i++)
        {
            queueNumbers.Dequeue();
        }
        if (queueNumbers.Contains(numberToLookFor))
        {
            Console.WriteLine("true");
        }
        else if (!queueNumbers.Contains(numberToLookFor) && queueNumbers.Count > 0)
        {
            int smallestNumber = int.MaxValue;
            foreach (int number in queueNumbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
            Console.WriteLine(smallestNumber);
        }
        else if (queueNumbers.Count == 0)
        {
            Console.WriteLine(queueNumbers.Count);
        }
    }
}

