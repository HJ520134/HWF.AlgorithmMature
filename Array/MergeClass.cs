using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeLearn.Array
{

    public class MergeClass
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals[0].Length == 0)
            {
                return new int[][] { };
            }
            else if (intervals.Length == 1 || intervals[0].Length == 1)
            {
                return intervals;
            }

            intervals = intervals.OrderBy(prop => prop[0]).ToArray();

            List<int[]> list = new List<int[]>();
            for (int row = 0; row < intervals.Length - 1; row++)
            {
                if (intervals[row + 1][0] >= intervals[row][0] && intervals[row + 1][0] <= intervals[row][1])
                {
                    intervals[row + 1] = new int[2] { intervals[row][0], Math.Max(intervals[row + 1][1], intervals[row][1]) };
                    if (row == intervals.Length - 2)
                    {
                        list.Add(intervals[row + 1]);
                    }
                }
                else
                {
                    list.Add(new int[2] { intervals[row][0], intervals[row][1] });
                }
            }

            if (intervals[intervals.Length - 1][0] >= intervals[intervals.Length - 2][0] && intervals[intervals.Length - 1][0] <= intervals[intervals.Length - 2][1])
            {
            }
            else
            {
                list.Add(new int[2] { intervals[intervals.Length - 1][0], intervals[intervals.Length - 1][1] });
            }

            return list.ToArray();
        }
    }
}
