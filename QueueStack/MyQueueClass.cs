using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class MyQueueClass
    {
        public Stack<int> pushStack;
        public Stack<int> popStack;
        public MyQueueClass()
        {
            pushStack = new Stack<int>();
            popStack = new Stack<int>();
        }

        public void Push(int x)
        {
            pushStack.Push(x);
        }

        public int Pop()
        {
            if (popStack.Count == 0)
            {
                while (pushStack.Count > 0)
                {
                    popStack.Push(pushStack.Peek());
                    pushStack.Pop();
                }
                pushStack = new Stack<int>();
            }
            return popStack.Pop();
        }

        public int Peek()
        {
            var result = this.Pop();
            popStack.Push(result);
            return result;
        }

        public bool Empty()
        {
            return popStack.Count == 0 && pushStack.Count == 0;
        }
    }
}
