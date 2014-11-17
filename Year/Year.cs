using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            bool isLeapYear = false;

            //if (year is not divisible by 4) then (it is a common year)
            if (!year.IsDivisibleBy(4)) isLeapYear = false;
            //else if (year is not divisible by 100) then (it is a leap year)
            else if (!year.IsDivisibleBy(100)) isLeapYear = true;
            //else if (year is not divisible by 400) then (it is a common year)
            else if (!year.IsDivisibleBy(400)) isLeapYear = false;
            //else (it is a leap year)
            else isLeapYear = true;

            return isLeapYear;
        }
    }

    public static class Extensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {            
            return dividend % divisor == 0;
        }
    }

}