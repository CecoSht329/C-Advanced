using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Date_Modifier
{
    public static class DateModifier
    {
        public static double GetDaysBetweeen(string dateOne, string dateTwo)
        {
            DateTime dateTimeOne = DateTime.Parse(dateOne);
            DateTime dateTimeTwo = DateTime.Parse(dateTwo);
            double days = (dateTimeOne - dateTimeTwo).TotalDays;
            return days;
        }
    }
}
