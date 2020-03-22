using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS02.CodeReview.Helper
{
    public class DateTimeHelper
    {
        /// <summary>
        /// Check Whether the Entered Year is a Leap Year or Not
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool CheckLeapYear(int year)
        {
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0);

            if (year % 400 == 0)
            {
                isLeapYear = true;
            }

            return isLeapYear;
        }
    }
}