using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn
{
    /// <summary>
    /// 杨辉三角
    /// </summary>
    public static class YangHuiSanJiao
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> yanghuiTraList = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                var yanghuiTraTemp = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        yanghuiTraTemp.Add(1);
                    }
                    else
                    {
                        yanghuiTraTemp.Add(yanghuiTraList[i - 1][j - 1] + yanghuiTraList[i - 1][j]);
                    }
                }
                yanghuiTraList.Add(yanghuiTraTemp);
            }

            return yanghuiTraList;
        }

        /// <summary>
        /// 杨辉三角II
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static IList<int> GenerateII(int numRows)
        {
            IList<IList<int>> yanghuiTraList = new List<IList<int>>();
            IList<int> result = new List<int>();
            for (int i = 0; i < numRows; i++)
            {
                var yanghuiTraTemp = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        yanghuiTraTemp.Add(1);
                    }
                    else
                    {
                        yanghuiTraTemp.Add(yanghuiTraList[i - 1][j - 1] + yanghuiTraList[i - 1][j]);
                    }
                }
                result = yanghuiTraTemp;
                yanghuiTraList.Add(yanghuiTraTemp);
            }
            return result;
        }
    }
}


public class Solution
{
    public IList<int> GetRow(int numRows)
    {
        IList<IList<int>> yanghuiTraList = new List<IList<int>>();
        IList<int> result = new List<int>();
        for (int i = 0; i <= numRows; i++)
        {
            var yanghuiTraTemp = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    yanghuiTraTemp.Add(1);
                }
                else
                {
                    yanghuiTraTemp.Add(yanghuiTraList[i - 1][j - 1] + yanghuiTraList[i - 1][j]);
                }
            }
            result = yanghuiTraTemp;
            yanghuiTraList.Add(yanghuiTraTemp);
        }
        return result;
    }
}