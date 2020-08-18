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
        int elementsToPushCount = numbers[0];
        int elementsToPopCount = numbers[1];
        int elementToLookFor = numbers[2];

        int[] stackNums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        Stack<int> stackOfNumbers = new Stack<int>();

        for (int i = 0; i < elementsToPushCount; i++)
        {
            stackOfNumbers.Push(stackNums[i]);
        }
        for (int i = 0; i < elementsToPopCount; i++)
        {
            stackOfNumbers.Pop();
        }
        if (stackOfNumbers.Contains(elementToLookFor))
        {
            Console.WriteLine(stackOfNumbers.Contains(elementToLookFor));
        }
        else if (!stackOfNumbers.Contains(elementToLookFor) && stackOfNumbers.Count > 0)
        {
            int smallestNumber = int.MaxValue;
            foreach (int number in stackOfNumbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
            Console.WriteLine(smallestNumber);
        }
        else if (stackOfNumbers.Count == 0)
        {
            Console.WriteLine(stackOfNumbers.Count);
        }
    }
}

