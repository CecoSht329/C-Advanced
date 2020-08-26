using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var wardrobe = new Dictionary<string, Dictionary<string, long>>();

        var numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            var clothesInfo = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var color = clothesInfo[0];
            var clothes = clothesInfo[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, long>());
            }
            foreach (var clothing in clothes)
            {
                if (!wardrobe[color].ContainsKey(clothing))
                {
                    wardrobe[color].Add(clothing, 0);
                }
                wardrobe[color][clothing]++;
            }
        }
        var colorClothingToLookFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var colorToLookFor = colorClothingToLookFor[0];
        var clothingToLookFor = colorClothingToLookFor[1];

        foreach (var (color, clothes) in wardrobe)
        {
            Console.WriteLine($"{color} clothes:");
            foreach (var (clothing, count) in clothes)
            {
                if (color == colorToLookFor && clothing == clothingToLookFor)
                {
                    Console.WriteLine($"* {clothing} - {count} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {clothing} - {count}");
                }
            }
        }
    }
}

