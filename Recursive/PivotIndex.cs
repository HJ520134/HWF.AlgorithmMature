using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Recursive
{
    public class PivotIndexClass
    {
        public static int PivotIndex(int[] nums)
        {
            var leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var rightSum = 0;
                for (int j = nums.Length - 1; j > i; j--)
                {
                    rightSum += nums[j];
                }

                if (leftSum == rightSum)
                {
                    return i;
                }

                leftSum += nums[i];
            }
            return -1;
        }


        /// <summary>
        /// 至少是其他数字两倍的最大数
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int DominantIndex(int[] nums)
        {
            var max = 0;
            var index = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (max < nums[j])
                {
                    max = nums[j];
                    index = j;
                }
            }

            var second = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (second < nums[j] && nums[j] != max)
                {
                    second = nums[j];
                }
            }

            if (max >= second * 2)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
