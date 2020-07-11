using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LeetCodeLearn.Array
{
    public class FindMaxConsecutiveOnesClass
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var resMax = 0;
            var tempMax = 0;
            var lastMax = 0;
            bool isallzero = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    isallzero = true;
                    if (tempMax > resMax)
                    {
                        resMax = tempMax;
                    }
                    tempMax = 0;
                    lastMax = nums.Length - i - 1;
                }
                else
                {
                    tempMax++;
                }
            }

            if (resMax == 0 && lastMax == 0 && !isallzero)
            {
                return nums.Length;
            }
            else
            {
                return Math.Max(resMax, lastMax);
            }

        }

        public int MinSubArrayLen(int s, int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var startValue = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    startValue += nums[j];
                    if (startValue>= s)
                    {
                        list.Add(j - i+1);
                        break;
                    }
                }
            }
            if (list.Count() > 0)
            {
                return list.Min();
            }
            else
            {
                return 0;
            }
        }

    }
}
