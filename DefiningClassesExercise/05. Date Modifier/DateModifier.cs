
using System;

namespace DateModifierAssignment
{
    public static class DateModifier
    {

        public static double CalculateDifference(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            double result = (dateOne - dateTwo).TotalDays;
            return result;
        }
    }
}
