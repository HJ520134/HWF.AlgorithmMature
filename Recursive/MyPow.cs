using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Recursive
{
  public  class MyPowClass
    {
        public double MyPow(double x, int n)
        {
            return MyPowCal(x, n, 1);
        }

        public double MyPowCal(double x, int n, int count)
        {
            if (count>Math.Abs(n))
            {
                return 1;
            }

            if (n > 0)
            {
                return MyPowCal(x, n, ++count) * x;
            }
            else
            {
                return MyPowCal(x, n, ++count) / x;
            }
        }

        public double myPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            double current_product = x;
            for (long i = N; i > 0; i /= 2)
            {
                if ((i % 2) == 1)
                {
                    ans = ans * current_product;
                }
                current_product = current_product * current_product;
            }
            return ans;
        }
    }
}
