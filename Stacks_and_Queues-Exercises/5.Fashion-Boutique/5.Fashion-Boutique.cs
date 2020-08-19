using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] clothesArr = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
        Stack<int> boxes = new Stack<int>(clothesArr);
        int rackCapacity = int.Parse(Console.ReadLine());
        int rackCount = 1;
        int currentRackCapacity = rackCapacity;

        while (boxes.Count > 0)
        {
            int currentClothes = boxes.Peek();

            if (currentRackCapacity >= currentClothes)
            {
                currentRackCapacity -= currentClothes;
                boxes.Pop();
            }
            else
            {
                rackCount++;
                currentRackCapacity = rackCapacity;
            }
        }
        Console.WriteLine(rackCount);
    }
}

