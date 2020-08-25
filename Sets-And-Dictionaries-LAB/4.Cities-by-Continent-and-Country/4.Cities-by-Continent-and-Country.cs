using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var continentCountryCities = new Dictionary<string, Dictionary<string, List<string>>>();

        var lines = int.Parse(Console.ReadLine());
        for (int line = 0; line < lines; line++)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var continent = input[0];
            var country = input[1];
            var city = input[2];

            if (!continentCountryCities.ContainsKey(continent))
            {
                continentCountryCities[continent] = new Dictionary<string, List<string>>();
            }
            if (!continentCountryCities[continent].ContainsKey(country))
            {
                continentCountryCities[continent][country] = new List<string>();
            }
            continentCountryCities[continent][country].Add(city);
        }

        foreach (var (continentName, CountryAndCity) in continentCountryCities)
        {
            Console.WriteLine($"{continentName}:");
            foreach (var (country, cities) in CountryAndCity)
            {
                Console.WriteLine($"{country} -> {string.Join(", ",cities)}");
            }
        }
    }
}

