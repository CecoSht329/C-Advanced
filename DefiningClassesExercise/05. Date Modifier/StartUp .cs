using System;
using System.Linq;
using System.Collections.Generic;

namespace DateModifierAssignment
{
    public class StartUp
    {
        static void Main()
        {
            double result = DateModifier.CalculateDifference(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(Math.Abs(result));
        }
    }
}
