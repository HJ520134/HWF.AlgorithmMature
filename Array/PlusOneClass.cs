using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{
    public class PlusOneClass
    {
        public static int[] PlusOne(int[] digits)
        {
            if (digits.Length <= 0)
            {
                return digits;
            }

            return PlusRecursiveOne(digits, digits.Length - 1);
        }

        public static int[] PlusRecursiveOne(int[] digits, int index)
        {
            if (index == 0 && digits[index] + 1 >= 10)
            {
                var tempAyyay = new int[digits.Length + 1];
                tempAyyay[0] = 1;
                return tempAyyay;
            }

            if (digits[index] + 1 >= 10)
            {
                digits[index] = 0;
                return PlusRecursiveOne(digits, index - 1);
            }
            else
            {
                digits[index] += 1;
                return digits;
            }
        }

    }
}
