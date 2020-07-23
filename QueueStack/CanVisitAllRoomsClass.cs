using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    public class CanVisitAllRoomsClass
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            if (rooms.Count == 0)
            {
                return false;
            }

            var tempStack = new Stack<int>();
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < rooms[0].Count; i++)
            {
                if (!tempStack.Contains(rooms[0][i]))
                {
                    tempStack.Push(rooms[0][i]);
                }
            }

            while (tempStack.Count > 0)
            {
                if (!dic.ContainsKey(tempStack.Peek()))
                {
                    dic.Add(tempStack.Peek(), 0);
                }
                else
                {
                    tempStack.Pop();
                    continue;
                }

                if (tempStack.Peek() >= rooms.Count)
                {
                    dic.Add(tempStack.Pop(), 0);
                    continue;
                }

                var templength = tempStack.Pop();
                for (int i = 0; i < rooms[templength].Count; i++)
                {
                    tempStack.Push(rooms[templength][i]);
                }
            }
            for (int i = 1; i < rooms.Count; i++)
            {
                if (rooms[i] != null && !dic.ContainsKey(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
