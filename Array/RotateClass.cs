using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Array
{
    /// <summary>
    /// 矩阵旋转
    /// </summary>
    public class RotateClass
    {
        public void Rotate(int[][] matrix)
        {
            var row = matrix.Length;
            var col = matrix[0].Length;
            for (int i = 0; i < row / 2; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[row - i - 1][j];
                    matrix[row - i - 1][j] = temp;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }
    }
}
