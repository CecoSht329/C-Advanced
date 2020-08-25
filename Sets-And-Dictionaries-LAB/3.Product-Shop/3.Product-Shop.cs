using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var shopProductPrice = new SortedDictionary<string, Dictionary<string, double>>();

        var input = "";
        while ((input = Console.ReadLine()) != "Revision")
        {
            var tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var shop = tokens[0];
            var product = tokens[1];
            var price = double.Parse(tokens[2]);

            if (!shopProductPrice.ContainsKey(shop))
            {
                shopProductPrice[shop] = new Dictionary<string, double>();
            }
            if (!shopProductPrice[shop].ContainsKey(product))
            {
                shopProductPrice[shop][product] = 0;
            }
            shopProductPrice[shop][product] = price;
        }

        foreach (var pair in shopProductPrice)
        {
            Console.WriteLine($"{pair.Key}->");
            foreach (var kvp in pair.Value)
            {
                Console.WriteLine($"Product: {kvp.Key}, Price: {kvp.Value}");
            }
        }
    }
}

