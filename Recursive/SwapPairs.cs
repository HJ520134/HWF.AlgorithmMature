using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn
{
    /// <summary>
    /// 交换链表数据
    /// </summary>
    class SwapPairsC
    {
        public ListNode SwapPairs(ListNode head)
        {
            SwapPairsList(head);
            return head;
        }

        public void SwapPairsList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return;
            }

            var temp = head.val;
            head.val = head.next.val;
            head.next.val = temp;
            SwapPairsList(head.next.next);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
