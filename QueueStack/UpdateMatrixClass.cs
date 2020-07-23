using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HWF.AlgorithmMature.QueueStack
{
    public class UpdateMatrixClass
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            var queue = new Queue<Tuple<int, int>>();
            var ylength = matrix.Length;
            var xlength = matrix[0].Length;
            int[][] res = new int[matrix.Length][];
            for (int i = 0; i < ylength; i++)
            {
                res[i] = new int[matrix[i].Length];
                for (int j = 0; j < xlength; j++)
                {
                    queue.Enqueue(new Tuple<int, int>(i, j));
                    res[i][j]= BFS(matrix, queue);
                    queue.Clear();
                }
            }
            return res;
        }

        public int BFS(int[][] matrix, Queue<Tuple<int, int>> queue)
        {
            var deepLength = 0;
            while (queue.Any())
            {
                var count = queue.Count();
                for (int i = 0; i < count; i++)
                {
                    var tupe = queue.Dequeue();
                    if (matrix[tupe.Item1][tupe.Item2] == 0)
                    {
                        return deepLength;
                    }

                    if (tupe.Item1 - 1 >= 0)
                    {
                        queue.Enqueue(new Tuple<int, int>(tupe.Item1 - 1, tupe.Item2));
                    }

                    if (tupe.Item1 + 1 < matrix.Length)
                    {
                        queue.Enqueue(new Tuple<int, int>(tupe.Item1 + 1, tupe.Item2));
                    }

                    if (tupe.Item2 - 1 >= 0)
                    {
                        queue.Enqueue(new Tuple<int, int>(tupe.Item1, tupe.Item2 - 1));
                    }

                    if (tupe.Item2 + 1 < matrix[0].Length)
                    {
                        queue.Enqueue(new Tuple<int, int>(tupe.Item1, tupe.Item2 + 1));
                    }
                }
                deepLength++;

            }

            return deepLength;
        }

    }
}
