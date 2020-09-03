using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person = new Person();

            person.Name = "Pesho";
            person.Age = 20;

            Person anotherPerson = new Person();
            anotherPerson.Name = "Ivan";
            anotherPerson.Age = 28;
            Console.WriteLine(person.Name);

        }
    }
}
