using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    public class GetKthFromEnd22
    {
        public ListNode getKthFromEnd(ListNode head, int k)
        {
            var fast = head;
            var slow = head;
            for (var i = 0; i < k; i++)
            {
                if (fast == null)   //if k > the length of linked list, return null
                {
                    return null;
                }
                else
                {
                    fast = fast.next;
                }
            }
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
    }
}
