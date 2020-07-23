using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    public class OpenLockClass
    {
        public int OpenLock(string[] deadends, string target)
        {
            var deadSet = new HashSet<string>();
            var visitSet = new HashSet<string>();
            foreach (var item in deadends)
            {
                deadSet.Add(item);
            }
            var queue = new Queue<string>();
            queue.Enqueue("0000");
            var level = 0;
            while (queue.Count > 0)
            {
                var len = queue.Count;
                for (int x = 0; x < len; x++)
                {
                    var currentNum = queue.Dequeue();
                    if (deadSet.Contains(currentNum))
                    {
                        continue;
                    }
                    if (target == currentNum)
                    {
                        return level;
                    }

                    for (int j = 0; j < 4; j++)
                    {
                        var tempLeftSrt = turnLeft(currentNum, j);
                        if (!visitSet.Contains(tempLeftSrt))
                        {
                            visitSet.Add(tempLeftSrt);
                            queue.Enqueue(tempLeftSrt);
                        }

                        var tempRightSrt = turnRight(currentNum, j);
                        if (!visitSet.Contains(tempRightSrt))
                        {
                            visitSet.Add(tempRightSrt);
                            queue.Enqueue(tempRightSrt);
                        }
                    }
                }
                level++;
            }

            return -1;
        }


        private string turnLeft(string srt, int index)
        {
            var temparray = srt.ToCharArray();
            if (temparray[index] == '9')
            {
                temparray[index] = '0';
            }
            else
            {
                temparray[index]++;
            }

            return new string(temparray);
        }

        private string turnRight(string srt, int index)
        {
            var temparray = srt.ToCharArray();
            if (temparray[index] == '0')
            {
                temparray[index] = '9';
            }
            else
            {
                temparray[index]--;
            }

            return new string(temparray);
        }
 
    }
}
