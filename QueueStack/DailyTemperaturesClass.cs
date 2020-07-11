using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class DailyTemperaturesClass
    {
        //public int[] DailyTemperatures(int[] T)
        //{
        //    if (T.Length == 0)
        //    {
        //        return new int[] { };
        //    }
        //    var result = new int[T.Length];
        //    for (int i = 0; i < T.Length; i++)
        //    {
        //        var index = 0;
        //        for (int j = i + 1; j < T.Length; j++)
        //        {
        //            if (j == T.Length - 1 && T[j] <= T[i])
        //            {
        //                index = 0;
        //                break;
        //            }
        //            index++;
        //            if (T[j] >= T[i])
        //            {
        //                break;
        //            }
        //        }
        //        result[i] = index;
        //    }
        //    return result;
        //}

        //public int[] DailyTemperatures(int[] T)
        //{
        //    // 记录最短升温的等待天数
        //    var result = new int[T.Length];
        //    // 维护一个单调递减栈，保存的是下标用于计算相差的天数
        //    var descTIndexStack = new Stack<int>();
        //    for (int i = 0; i < T.Length; i++)
        //    {
        //        // 栈中所有比当前温度低的天数最短等待天数就是索引差值，因为中间的温度都更低（递减栈）
        //        while (descTIndexStack.Count > 0 && T[descTIndexStack.Peek()] < T[i])
        //        {
        //            result[descTIndexStack.Peek()] = i - descTIndexStack.Pop();
        //        }
        //        descTIndexStack.Push(i);
        //    }
        //    return result;
        //}

            public int[] DailyTemperatures(int[] T)
            {
                int length = T.Length;
                int[] result = new int[length];
                for (int i = length - 2; i >= 0; i--)
                {
                    for (int j = i + 1; j < length; j += result[j])
                    {
                        if (T[i] < T[j])
                        {
                            result[i] = j - i;
                            break;
                        }
                        else if (result[j] == 0)
                        {
                            result[i] = 0;
                            break;
                        }
                    }
                }
                return result;

            }

    }
}
