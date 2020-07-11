using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{

    public class SetZeroesClass
    {
        public void SetZeroes(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return;
            }

            var row = matrix.Length;
            var col = matrix[0].Length;
            var list = new List<Tuple<int, int>>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        list.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            foreach (var item in list)
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[i][item.Item2] = 0;
                }

                for (int j = 0; j < col; j++)
                {
                    matrix[item.Item1][j] = 0;
                }
            }

        }
    }
}
