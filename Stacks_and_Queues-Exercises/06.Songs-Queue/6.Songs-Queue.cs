using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] songsInput = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        Queue<string> songs = new Queue<string>(songsInput);

        while (songs.Any())
        {
            string commandInput = Console.ReadLine();
            if (commandInput.StartsWith("Play"))
            {
                songs.Dequeue();
            }
            else if (commandInput.StartsWith("Add"))
            {
                string song = commandInput.Substring(4);
                if (!songs.Contains(song))
                {
                    songs.Enqueue(song);
                }
                else
                {
                    Console.WriteLine($"{song} is already contained!");
                }
            }
            else if (commandInput.StartsWith("Show"))
            {
                Console.WriteLine(string.Join(", ", songs));
            }
        }
        Console.WriteLine("No more songs!");
    }
}

