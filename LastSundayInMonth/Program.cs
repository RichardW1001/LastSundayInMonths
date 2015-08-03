using System;
using System.Collections.Generic;
using System.Linq;

namespace LastSundayInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            var sundays14 = LastDaysInMonthForYear(2014, DayOfWeek.Sunday).ToArray();
            var saturdays13 = LastDaysInMonthForYear(2013, DayOfWeek.Saturday).ToArray();
            var tuesdays99 = LastDaysInMonthForYear(1999, DayOfWeek.Tuesday).ToArray();
            var tuesdays00 = LastDaysInMonthForYear(2000, DayOfWeek.Tuesday).ToArray();
        }

        private static IEnumerable<DateTime> LastDaysInMonthForYear(int y, DayOfWeek w)
        {
            return
                Enumerable.Range(1, 12)
                    .Select(i => new DateTime(y, i, 1).AddMonths(1).AddDays(-(int) w - 1))
                    .Select(d => d.AddDays((int) w - (int) d.DayOfWeek));
        } 
    }
}
