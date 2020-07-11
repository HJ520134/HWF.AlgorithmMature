using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.Recursive
{
    /// <summary>
    /// 合并链表
    /// </summary>
    public class MergeTwoListsClass
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            return ConnectTwoLists(l1, l2);
        }

        public ListNode ConnectTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = ConnectTwoLists(l1.next, l2);
                return l1;
            }
            else 
            {
                l2.next = ConnectTwoLists(l1, l2.next);
                return l2;
            }
        }

    }
}
