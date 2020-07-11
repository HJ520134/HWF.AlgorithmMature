using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var dic = new Dictionary<string, int>();
            var firstStr = strs[0];
            for (int i = 0; i < firstStr.Length; i++)
            {
                dic.Add(firstStr.Substring(0, i + 1), i);
            }
            var resSrt = string.Empty;
            foreach (var item in dic)
            {
                foreach (var childSrt in strs)
                {
                    if (item.Value >= childSrt.Length)
                    {
                        return resSrt;
                    }

                    if (childSrt.Substring(0, item.Value + 1) != item.Key)
                    {
                        return resSrt;
                    }
                }
                resSrt = item.Key;
            }

            return resSrt;
        }
    }
}
