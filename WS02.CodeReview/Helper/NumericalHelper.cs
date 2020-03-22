using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS02.CodeReview.Helper
{
    public class NumericalHelper
    {
        /// <summary>
        /// Find Magnitude of Integer
        /// Number : 3145678
        /// Magnitude : 7
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int FindMagnitudeOfInteger(int number)
        {
            int num, mag = 0;
            while (number > 0)
            {
                mag++;
                num = number / 10;
            };

            return mag;
        }

        /// <summary>
        /// Compute Average for the Set of Values
        /// Average of 1,2,3,4 is 2.5
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public decimal ComputeAverage(int[] list)
        {
            int m, i, sum = 0, avg = 0;
            for (i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }

            return sum / list.Length;
        }
    }
}