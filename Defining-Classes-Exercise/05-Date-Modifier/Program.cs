using System;

namespace _05_Date_Modifier
{
    class Program
    {
        static void Main()
        {
            double result = DateModifier.GetDaysBetweeen(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(Math.Abs(result));
        }
    }
}
