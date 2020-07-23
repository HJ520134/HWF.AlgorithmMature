using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    /// <summary>
    /// 循环队列
    /// </summary>
    public class MyCircularQueue
    {
        private int[] queue;
        private int rear;
        private int front;
        private int count;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            queue = new int[k];
            rear = 0;
            front = 0;
            count = 0;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            queue[rear] = value;
            count++;
            if (rear == queue.Length-1)
            {
                rear = 0;
            }
            else
            {
                rear++;
            }
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            if (front == queue.Length-1)
            {
                front = 0;
            }
            else
            {
                front++;
            }
            count--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (count == 0)
            {
                return -1;
            }

            return queue[front];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (count == 0)
            {
                return -1;
            }

            return rear == 0 ? queue[queue.Length - 1] : queue[rear-1];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return this.count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return this.count == this.queue.Length;
        }
    }
}
