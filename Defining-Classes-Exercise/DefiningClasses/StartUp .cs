using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();
            Person person = new Person("Ivan", 30);

            family.AddMember(person);
            
        }
    }
}
