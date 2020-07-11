using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn
{
    /// <summary>
    /// 反转 链表
    /// </summary>
    public static class ReverseList
    {
        public static ListNode ReverseListTwo(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode tempNode = ReverseListTwo(head.next);
            head.next.next = head;
            head.next = null;
            return tempNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode tempNode = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return tempNode;
        }
    }
}
