using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            var lines = int.Parse(Console.ReadLine());
            for (int line = 0; line < lines; line++)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(tokens[0], int.Parse(tokens[1]));
                people.Add(person);
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(Environment.NewLine, people.Where(x => x.Age > 30).OrderBy(x => x.Name)));
        }
    }
}
