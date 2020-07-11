using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class EvalRPNClass
    {
        /// <summary>
        /// 逆波兰表达式
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public int EvalRPN(string[] tokens)
        {
            if (tokens.Length == 0)
            {
                return 0;
            }

            var stacks = new Stack<int>();
            var result = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                var temp = 0;
                if (int.TryParse(tokens[i], out temp))
                {
                    stacks.Push(temp);
                    continue;
                };

                var v2 = stacks.Pop();
                var v1 = stacks.Pop();

                if (tokens[i] == "+")
                {
                    stacks.Push(v1 + v2);
                }
                else if (tokens[i] == "-")
                {
                    stacks.Push(v1 - v2);
                }
                else if (tokens[i] == "*")
                {
                    stacks.Push(v1 * v2);
                }
                else if (tokens[i] == "/")
                {
                    stacks.Push(v1 / v2);
                }
            }

            return stacks.Pop();
        }
  
    }
}
