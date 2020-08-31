using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Predicate_Party_
{
    class Program
    {
        static void Main()
        {
            var guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            var input = "";
            while ((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var filterCommand = tokens[1];
                var criteria = tokens[2];

                if (command == "Remove")
                {
                    var guestsToRemove = new List<string>();
                    if (filterCommand == "StartsWith")
                    {
                        guests.RemoveAll(x => x.StartsWith(criteria));
                    }
                    else if (filterCommand == "EndsWith")
                    {
                        guests.RemoveAll(x => x.EndsWith(criteria));

                    }
                    else if (filterCommand == "Length")
                    {
                        guests.RemoveAll(x => x.Length == int.Parse(criteria));
                    }


                }
                else if (command == "Double")
                {
                    var guestsToAdd = new List<string>();
                    if (filterCommand == "StartsWith")
                    {
                        guestsToAdd = guests.Where(x => x.StartsWith(criteria)).ToList();
                    }
                    else if (filterCommand == "EndsWith")
                    {
                        guestsToAdd = guests.Where(x => x.EndsWith(criteria)).ToList();

                    }
                    else if (filterCommand == "Length")
                    {
                        guestsToAdd = guests.Where(x => x.Length == int.Parse(criteria)).ToList();
                    }

                    foreach (var name in guestsToAdd)
                    {
                        int index = guestsToAdd.IndexOf(name);

                        guests.Insert(index + 1, name);
                    }
                }
            }
            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party!":
                $"Nobody is going to the party!");
        }
    }
}
