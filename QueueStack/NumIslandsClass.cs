using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class NumIslandsClass
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }
            var ylength = grid.Length;
            var xlength = grid[0].Length;

            var islandNum = 0;
            for (int i = 0; i < ylength; i++)
            {
                for (int j = 0; j < xlength; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandNum++;
                        dfs(grid, i, j);
                    }
                }
            }

            return islandNum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="xIndex"></param>
        /// <param name="yIndex"></param>
        private void dfs(char[][] grid, int xIndex, int yIndex)
        {
            var xlength = grid[0].Length;
            var ylength = grid.Length;

            if (xIndex < 0 || yIndex < 0 || xIndex >= ylength || yIndex >= xlength || grid[xIndex][yIndex] == '0')
            {
                return;
            }

            grid[xIndex][yIndex] = '0';
            dfs(grid, xIndex - 1, yIndex);
            dfs(grid, xIndex + 1, yIndex);
            dfs(grid, xIndex, yIndex - 1);
            dfs(grid, xIndex, yIndex + 1);
        }

    }
}
