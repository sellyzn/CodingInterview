using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedListProblems
{
    public class MyLinkedList
    {
        public ListNode head;
        public MyLinkedList()
        {
            head = null;
        }
        public MyLinkedList(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
                return;
            head = new ListNode(arr[0]);
            ListNode temp = head;
            for(var i = 1; i < arr.Length; i++)
            {
                temp.next = new ListNode(arr[i]);
                temp = temp.next;
            }
        }
    }
}
