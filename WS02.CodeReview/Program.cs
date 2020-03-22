using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS02.CodeReview.Helper;

namespace WS02.CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Whether the Entered Year is a Leap Year or Not");
            Console.Write("Enter the Year in Four Digits: ");
            var year = Convert.ToInt32(Console.ReadLine());

            var DateTimeHelper = new DateTimeHelper();
            if (DateTimeHelper.CheckLeapYear(year))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }

            Console.ReadKey();
        }
    }
}
