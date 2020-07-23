using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    public class NumSquaresClass
    {
        public int NumSquares(int n)
        {
            var queue = new Queue<int>();
            var hashSet = new HashSet<int>();
            queue.Enqueue(n);
            hashSet.Add(n);
            var deepLevel = 0;
            while (queue.Count > 0)
            {
                var sqrtlength = queue.Count;
                deepLevel++;
                for (int i = 0; i < sqrtlength; i++)
                {
                    var currntNum = queue.Dequeue();
                    for (int j = 1; j * j <= currntNum; j++)
                    {
                        var next = currntNum - j * j;
                        if (next == 0)
                        {
                            return deepLevel;
                        }

                        if (!hashSet.Contains(next))
                        {
                            hashSet.Add(next);
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            return deepLevel;
        }
    }
}
