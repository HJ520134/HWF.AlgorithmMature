using System;

namespace LeetCodeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodeList = new ListNode(1);
            nodeList.next = new ListNode(2);
            nodeList.next.next = new ListNode(3);
            nodeList.next.next.next = new ListNode(4);
            nodeList.next.next.next.next = new ListNode(5);
            ReverseList.ReverseListTwo(nodeList); 


            var yanghuiList = YangHuiSanJiao.Generate(5);
            foreach (var item in yanghuiList)
            {
                foreach (var itemValue in item)
                {
                    Console.Write(itemValue);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void ReverseString(char[] s)
        {
            var lastIndex = s.Length - 1;
            var start = 0;
            Swap(s, start, lastIndex);
        }

        public static void Swap(char[] s, int startIndex, int lastIndex)
        {
            if (startIndex >= lastIndex)
            {
                return;
            }
            var temp = s[startIndex];
            s[startIndex] = s[lastIndex];
            s[lastIndex] = temp;
            startIndex++;
            lastIndex--;
            Swap(s, startIndex, lastIndex);
        }




    }
}
