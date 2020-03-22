using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS02.CodeReview.Helper
{
    public class MathematicalHelper
    {
        /// <summary>
        /// Check whether the Entered Number is Even or Odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckEvenOddNumber(int number)
        {
            bool IsEvenNumber;
            int i = number;
            if (i % 2 == 0)
            {
                IsEvenNumber = true;
            }
            else
            {
                IsEvenNumber = false;
            }

            return IsEvenNumber;
        }

        /// <summary>
        /// Swap two Numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        public void SwapTwoNumber(int number1, int number2)
        {
            int num1, num2, temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
        }

        /// <summary>
        /// Get a Number and Display the Sum of the Digits
        /// Number : 123
        /// Sum of Digits of the Number : 6
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int SumOfTheDigits(int number)
        {
            int sum = 0, r;
            while (number != 1)
            {
                r = number % 10;
                number = number / 10;
                sum = sum + r;
            }

            return sum;
        }

        /// <summary>
        /// Get a Number and Display the Number with its Reverse
        /// Number : 123
        /// Reverse of it : 321
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string DisplayReverseOfNumber(string number)
        {
            int num, reverse = 0;
            num = int.Parse(number);
            if (num < 10)
            {
                return num + "";
            }

            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }

            return reverse + "";
        }

        /// <summary>
        /// C# Program to Print a BinaryTriangle
        /// Number of Rows : 5
        /// Result.
        /// 1
        /// 01
        /// 010
        /// 1010
        /// 10101
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string PrintBinaryTriangle(int numberOfRow)
        {
            int p, lastInt = 0, input;
            string result = null;
            input = numberOfRow;
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        result = result + "0";
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        result = result + "1";
                        lastInt = 1;
                    }
                }
                result = result + "\n";
            }

            return result;
        }
    }
}