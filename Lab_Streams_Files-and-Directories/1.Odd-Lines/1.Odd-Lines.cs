using System;
using System.IO;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader("Resources/01. Odd Lines/Input.txt"))
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                }
            }
        }
    }
}
