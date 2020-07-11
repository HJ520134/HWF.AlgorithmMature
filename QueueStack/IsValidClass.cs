using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class IsValidClass
    {
        public bool IsValid(string s)
        {
            if (s.Length == 1)
            {
                return false;
            }

            var stackLeft = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stackLeft.Push(s[i]);
                }
                else
                {
                    if (stackLeft.Count == 0)
                    {
                        return false;
                    }
                    var temp = stackLeft.Peek();
                    stackLeft.Pop();
                    var current = $"{temp}{s[i]}";
                    if (current == "()" || current == "{}" || current == "[]")
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stackLeft.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
