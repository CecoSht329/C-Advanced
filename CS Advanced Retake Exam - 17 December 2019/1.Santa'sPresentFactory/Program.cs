using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] materialBoxes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] magicBoxes = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Dictionary<int, string> magicAndPresent = new Dictionary<int, string>
        {
            {150,"Doll"},
            {250,"Wooden train"},
            {300,"Teddy bear"},
            {400,"Bicycle"}
        };

        Dictionary<string, int> presentsCount = new Dictionary<string, int>
        {
            {"Doll",0 },
            {"Wooden train",0 },
            {"Teddy bear",0 },
            {"Bicycle",0 }
        };

        Stack<int> materials = new Stack<int>(materialBoxes);
        Queue<int> magics = new Queue<int>(magicBoxes);

        while (materials.Count > 0 && magics.Count > 0)
        {
            int product = materials.Peek() * magics.Peek();
            if (magicAndPresent.ContainsKey(product))
            {
                string present = magicAndPresent[product];
                presentsCount[present]++;
                materials.Pop();
                magics.Dequeue();
            }
            if (product < 0)
            {
                int sum = materials.Pop() + magics.Dequeue();
                materials.Push(sum);
            }
            if (!magicAndPresent.ContainsKey(product) && product > 0)
            {
                magics.Dequeue();
                int sumToPush = materials.Pop() + 15;
                materials.Push(sumToPush);
            }
            if (product == 0)
            {
                if (materials.Peek() == 0)
                {
                    materials.Pop();
                }
                if (magics.Peek() == 0)
                {
                    magics.Dequeue();
                }
            }
        }
        if ((presentsCount["Doll"] >= 1 && presentsCount["Wooden train"] >= 1)
            || (presentsCount["Teddy bear"] >= 1 && presentsCount["Bicycle"] >= 1))
        {
            Console.WriteLine("The presents are crafted! Merry Christmas!");
        }
        else
        {
            Console.WriteLine("No presents this Christmas!");
        }

        if (materials.Any())
        {
            Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
        }

        if (magics.Any())
        {
            Console.WriteLine($"Magic left: {string.Join(", ", magics)}");
        }

        foreach (var present in presentsCount
            .OrderBy(p => p.Key)
            .Where(p => p.Value > 0))
        {
            Console.WriteLine($"{present.Key}: {present.Value}");
        }
    }
}

