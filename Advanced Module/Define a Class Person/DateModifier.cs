using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static int DateDifference(string startDateAsStr, string endDateAsStr)
        {
            DateTime startDate = DateTime.Parse(startDateAsStr);
            DateTime endDate = DateTime.Parse(endDateAsStr);

            var diff = endDate - startDate;

            return Math.Abs(diff.Days);
        }
    }
}
