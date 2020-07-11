using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class MyStack
    {
        public Queue<int> popQueue;
        public MyStack()
        {
            popQueue = new Queue<int>();
        }

        public void Push(int x)
        {
            var tempQueue = popQueue.ToArray();
            popQueue.Clear();
            popQueue.Enqueue(x);
            foreach (var item in tempQueue)
            {
                popQueue.Enqueue(item);
            }
        }

        public int Pop()
        {
            return popQueue.Dequeue();
        }

        public int Top()
        {
            return popQueue.Peek();
        }

        public bool Empty()
        {
            return popQueue.Count == 0;
        }
    }
}
