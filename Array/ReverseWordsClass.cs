using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LeetCodeLearn.Array
{
    public class ReverseWordsClass
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var arraySrt = s.Split(" ");
            var listSrt = new List<string>();

            foreach (var item in arraySrt)
            {
                var tempRes = item.Reverse();
                listSrt.Add(string.Join("", tempRes));
            }

            return string.Join(" ", listSrt);
        }

        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            return nums.Min();
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[index])
                {
                    nums[++index] = nums[i];
                }
            }

            return index;
        }

        //public int RemoveDuplicates(int[] nums)
        //{
        //    var len = nums.Length;
        //    if (len == 0) return 0;
        //    var curr = 0;
        //    for (var i = 1; i < len; i++)
        //    {
        //        if (nums[i] > nums[curr])
        //        {
        //            nums[++curr] = nums[i];
        //        }
        //    }
        //    return curr + 1;
        //}

        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            };
            var lastIndex = nums.Length;
            for (int i = 0; i < lastIndex; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < lastIndex - 1;)
                    {
                        nums[j] = nums[++j];
                    }
                    i--;
                    nums[lastIndex - 1] = 0;
                    lastIndex--;
                }
            }
        }

        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            bool[,] P = new bool[n, n];
            string result = "";
            //遍历所有的长度
            for (int len = 1; len <= n; len++)
            {
                for (int start = 0; start < n; start++)
                {
                    int end = start + len - 1;
                    if (end >= n) //下标已经越界，结束本次循环
                        break;
                    //长度为 1 和 2 的单独判断下
                    P[start, end] = (len == 1 || len == 2 || P[start + 1, end - 1]) && s[start] == s[end];
                    
                    if (P[start, end] && len > result.Length)
                    {
                        result = s.Substring(start, len);
                    }
                }
            }
            return result;
        }

    }
}
