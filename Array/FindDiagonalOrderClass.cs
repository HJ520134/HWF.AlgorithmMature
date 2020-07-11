using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{
    public class FindDiagonalOrderClass
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {

            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return new int[0];
            }

            int row = matrix.Length;
            int col = matrix[0].Length;

            var tuple = new Tuple<int, int>(0, 0);
            var dic = new Dictionary<int, List<Tuple<int, int>>>();
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (!dic.ContainsKey(r + c))
                    {
                        dic[r + c] = new List<Tuple<int, int>>();
                    }

                    dic[r + c].Add(new Tuple<int, int>(r, c));
                }
            }
            var result = new int[row * col];
            var index = 0;

            for (int i = 0; i < dic.Count; i++)
            {
                //偶数- 正序
                if (i % 2 == 0)
                {
                    for (int even = 0; even < dic[i].Count; even++)
                    {
                        result[index] = matrix[dic[i][even].Item1][dic[i][even].Item2];
                        index++;
                    }
                }
                else
                {
                    dic[i].Reverse();
                    for (int odd = 0; odd < dic[i].Count; odd++)
                    {
                        result[index] = matrix[dic[i][odd].Item1][dic[i][odd].Item2];
                        index++;
                    }
                }
            }

            return result;
        }
    }
}
