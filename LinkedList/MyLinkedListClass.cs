using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.LinkedList
{
    //public class MyLinkedList
    //{
    //    int Count;
    //    ListNode head;
    //    /** Initialize your data structure here. */
    //    public MyLinkedList()
    //    {
    //        Count = 0;
    //        head = new ListNode(0);
    //    }

    //    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    //    public int Get(int index)
    //    {
    //        if (index < 0 || index >= Count)
    //        {
    //            return -1;
    //        }

    //        ListNode node = head;
    //        for (int i = 0; i < index + 1; i++)
    //        {
    //            node = node.Next;
    //        }

    //        return node.val;
    //    }

    //    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    //    public void AddAtHead(int val)
    //    {
    //        AddAtIndex(0, val);
    //    }

    //    /** Append a node of value val to the last element of the linked list. */
    //    public void AddAtTail(int val)
    //    {
    //        AddAtIndex(Count, val);
    //    }

    //    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    //    public void AddAtIndex(int index, int val)
    //    {
    //        if (index > Count)
    //        {
    //            return;
    //        }

    //        if (index < 0)
    //        {
    //            index = 0;
    //        }

    //        ++Count;
    //        ListNode preNode = head;

    //        for (int i = 0; i < index; i++)
    //        {
    //            preNode = preNode.Next;
    //        }

    //        var addNode = new ListNode(val);
    //        addNode.Next = preNode.Next;
    //        preNode.Next = addNode;
    //    }

    //    /** Delete the index-th node in the linked list, if the index is valid. */
    //    public void DeleteAtIndex(int index)
    //    {
    //        if (index < 0 || index >= Count)
    //        {
    //            return;
    //        }
    //        Count--;
    //        var node = head;
    //        for (int i = 0; i < index; i++)
    //        {
    //            node = node.Next;
    //        }
    //        node.Next = node.Next.Next;
    //    }
    //}

    //public class ListNode
    //{
    //    public ListNode(int val)
    //    {
    //        this.val = val;
    //    }
    //    public int val;
    //    public ListNode Next;
    //}

}
