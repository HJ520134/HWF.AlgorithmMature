using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace LeetCodeLearn.QueueStack
{
    public class DecodeStringClass
    {
        public string DecodeString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var allstack = new Stack<string>();
            var Stack = new Stack<string>();
            foreach (var item in s)
            {
                var itemSrt = item.ToString();
                if (itemSrt == "]")
                {
                    var tcount = allstack.Count;
                    for (int i = 0; i < tcount; i++)
                    {
                        if (allstack.Peek() == "[")
                        {
                            allstack.Pop();
                            break;
                        }
                        else
                        {
                            Stack.Push(allstack.Pop());
                        }
                    }
                    var srt = string.Empty;
                    while (Stack.Count > 0)
                    {
                        srt += Stack.Pop();
                    }
                    var numStack = new Stack<int>();
                    var numberL = allstack.Count;
                    var number = 0;
                    for (int i = 0; i < numberL; i++)
                    {
                        if (int.TryParse(allstack.Peek(), out number))
                        {
                            allstack.Pop();
                            numStack.Push(number);
                        }
                        else
                        {
                            break;
                        }
                    }

                    var numberSrt = string.Empty;
                    while (numStack.Count > 0)
                    {
                        numberSrt += numStack.Pop();
                    }

                    var templength = int.Parse(numberSrt);
                    for (int i = 0; i < templength; i++)
                    {
                        foreach (var citem in srt)
                        {
                            allstack.Push(citem.ToString());
                        }
                    }

                }
                else
                {
                    allstack.Push(itemSrt);
                }
            }
            var res = string.Empty;
            while (allstack.Count > 0)
            {
                res += allstack.Pop();
            }
            return string.Join("", res.Reverse());
        }
    }
}
