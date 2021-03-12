using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedListProblems
{
    public class DeleteNode18
    {
        public ListNode deleteNode(ListNode head, int val)
        {
            if (head == null)
                return null;
            if (head.next == null && head.val == val)
                return null;
            if (head.next != null && head.val == val)
                return head.next;
            var temp = head;
            var cur = head.next;
            while (cur != null)
            {
                if (cur.val == val)
                {
                    head.next = cur.next; ;
                }
                head = head.next;
                cur = cur.next;
            }
            return temp;
        }
        public ListNode deleteNode1(ListNode head, int val)
        {
            if (head != null)
            {
                if (head.val == val)
                {
                    head = head.next;
                    return head;
                }

                ListNode node = head;
                while (node != null)
                {
                    if (node.next.val == val)
                    {
                        node.next = node.next.next;
                        break;
                    }

                    node = node.next;
                }
            }

            return head;
        }

        //report error:
        //public static ListNode deleteNode(ListNode head, int val)
        //{
        //    if (head == null)
        //        return null;
        //    if (head.next == null && head.val == val)
        //        return null;
        //    if (head.next != null && head.val == val)
        //        return head.next;
        //    var cur = head;
        //    while (cur != null)
        //    {
        //        if (cur.next.val == val)
        //        {
        //            cur.next = cur.next.next;
        //        }
        //        cur = cur.next;
        //    }
        //    return head;
        //}

    }
}
