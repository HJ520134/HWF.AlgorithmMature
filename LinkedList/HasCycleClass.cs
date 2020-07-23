using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.LinkedList
{
    public class HasCycleClass
    {
        public bool HasCycle(ListNode head)
        {
            var node = head;
            var nodeNext = head;
            while (true)
            {
                if (node == null || nodeNext.next == null)
                {
                    return false;
                }

                node = node.next;
                nodeNext = nodeNext.next.next;
                if (node.Equals(nodeNext))
                {
                    return true;
                }

            }
        }

        public ListNode DetectCycle(ListNode head)
        {
            var hashSet = new HashSet<ListNode>();
            var node = head;
            hashSet.Add(node);

            while (true)
            {
                if (node == null)
                {
                    return null;
                }
                node = node.next;
                if (hashSet.Contains(node))
                {
                    return node;
                }
                hashSet.Add(node);
            }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var nodeA = headA;
            var nodeB = headB;
            while (nodeA!= nodeB)
            {
                if (nodeA == null)
                {
                    nodeA = headB;
                }
                else 
                {
                    nodeA = nodeA.next;
                }

                if (nodeB == null)
                {
                    nodeB = headA;
                }
                else
                {
                    nodeB = nodeB.next;
                }
            }

            return nodeA;
        }
    }
}


public class ListNode
{
    public ListNode(int val)
    {
        this.val = val;
    }
    public int val;
    public ListNode next;
}
