using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var followers = new Dictionary<string, SortedSet<string>>();
        var following = new Dictionary<string, SortedSet<string>>();

        var input = "";
        while ((input = Console.ReadLine()).ToLower() != "statistics")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var vloger = tokens[0];
            var action = tokens[1];
            if (action.ToLower() == "joined")
            {
                if (!followers.ContainsKey(vloger))
                {
                    followers.Add(vloger, new SortedSet<string>());
                    following.Add(vloger, new SortedSet<string>());
                }
            }
            else if (action.ToLower() == "followed")
            {
                var otherVloger = tokens[2];
                if (followers.ContainsKey(otherVloger) && followers.ContainsKey(vloger) &&
                    vloger != otherVloger)
                {
                    followers[otherVloger].Add(vloger);
                    following[vloger].Add(otherVloger);
                }
            }
        }
        var counter = 1;
        Console.WriteLine();
        Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");
        foreach (var kvp in followers
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => following[x.Key].Count))
        {
            Console.WriteLine($"{counter}. {kvp.Key} : {kvp.Value.Count} followers, {following[kvp.Key].Count} following");
            if (counter == 1)
            {
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"*  {item}");
                }
            }
            counter++;
        }
    }
}

