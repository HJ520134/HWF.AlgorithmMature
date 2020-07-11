using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeLearn.QueueStack
{
    public class MinStackClass
    {
        private List<int> data;
        /** initialize your data structure here. */
        public MinStackClass()
        {
            data = new List<int>();
        }

        public void Push(int x)
        {
            data.Add(x);
        }

        public void Pop()
        {
            data.RemoveAt(data.Count - 1);
        }

        public int Top()
        {
            if (data != null && data.Count > 0)
            {
                return data[data.Count - 1];
            }

            return 0;
        }

        public int GetMin()
        {
            if (data != null && data.Count > 0)
            {
                return data.Min();
            }

            return 0;
        }
    }
}
