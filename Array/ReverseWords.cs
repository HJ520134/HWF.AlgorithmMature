using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeLearn.Array
{

    /// <summary>
    /// 单词反转
    /// </summary>
    public class ReverseWordscClass
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var arrays = s.Split(" ").Reverse();
            arrays = arrays.Where(p => p != "").ToList();
            var result = string.Join(" ", arrays);
            return result.TrimStart(' ').TrimEnd(' ');
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(haystack) || haystack.Length < needle.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                {
                    return -1;
                }

                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
