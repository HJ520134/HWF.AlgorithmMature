using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class SearchInsertClass
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    return i;
                }

                if (nums[i] == target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
