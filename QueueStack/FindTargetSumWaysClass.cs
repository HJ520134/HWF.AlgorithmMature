using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    public class FindTargetSumWaysClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        public int FindTargetSumWays(int[] nums, int S)
        {
            var newNums = new int[nums.Length + 1];
            for (int i = 1; i <= nums.Length; i++)
            {
                newNums[i] = nums[i - 1];
            }

            var list = new List<int>();
            DFS(newNums, 0, S, list, 0, true);
            return list.Count;
        }

        public int DFS(int[] nums, int sum, int target, List<int> count, int index, bool isAdd)
        {
            if (index >= nums.Length)
            {
                return 0;
            }
            if (isAdd)
            {
                sum += nums[index];
            }
            else
            {
                sum -= nums[index];
            }

            DFS(nums, sum, target, count, index + 1, true);
            DFS(nums, sum, target, count, index + 1, false);

            if (index == nums.Length-1 && sum == target)
            {
                count.Add(1);
            }

            return sum;
        }

    }
}
