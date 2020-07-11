using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Recursive
{
    public class KthGrammarClass
    {
        public int KthGrammar(int N, int K)
        {
            var result = "0";
            for (int i = 0; i < N; i++)
            {
                result = KthGrammar(result);
            }
            return int.Parse(result.ToCharArray()[K].ToString());
        }

        public string KthGrammar(string rowRes)
        {
            var result = string.Empty;
            var array = rowRes.ToCharArray();
            foreach (var item in array)
            {
                if (item == '0')
                {
                    result += "01";
                }
                else
                {
                    result += "10";
                }
            }
            return result;
        }

        public int kthGrammar(int N, int K)
        {
            if (N == 1) return 0;
            if (K <= 1 << N - 2)
            {
                return kthGrammar(N - 1, K);
            }
            return kthGrammar(N - 1, K - (1 << N - 2)) ^ 1;
        }
    }
}
