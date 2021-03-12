using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DivideAndConquerProblems
{
    public class MergeTwoLists25
    {
        public ListNode mergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(0);
            var cur = dummy;
            while(l1 != null && l2 != null)
            {
                if(l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            cur.next = l1 != null ? l1 : l2;
            return dummy.next;
        }
    }
}
