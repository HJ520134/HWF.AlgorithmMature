using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeLearn.Array
{
    public class ArrayPairSumClass
    {
        public int ArrayPairSum(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            var list = nums.OrderBy(p => p).ToArray();
            var sum = 0;
            for (int i = 0; i < list.Count(); i += 2)
            {
                sum += list[i];
            }

            return sum;
        }


        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 0)
            {
                return new int[2];
            }
            int[] temp = new int[2];
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], i + 1);
                }
                else
                {
                    continue;
                }

                var tempNum = target - numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (tempNum == numbers[j])
                    {
                        temp[0] = i + 1;
                        temp[1] = j + 1;
                        return temp;
                    }
                }
            }

            return new int[2];
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            var startIndex = 0;
            var endIndex = nums.Length;
            while (startIndex < endIndex)
            {
                if (nums[startIndex] == val)
                {
                    nums[startIndex] = nums[endIndex - 1];
                    endIndex--;
                }
                else
                {
                    startIndex++;
                }
            }
            return startIndex;
        }

    }
}
