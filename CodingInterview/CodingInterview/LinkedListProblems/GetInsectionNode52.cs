using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedListProblems
{
    public class GetInsectionNode52
    {
        public ListNode getIntersectionNode(ListNode headA, ListNode headB)
        {
            var lenA = 0;
            var lenB = 0;
            var tmpA = headA;
            var tmpB = headB;
            while(tmpA != null)
            {
                lenA++;
                tmpA = tmpA.next;
            }
            while (tmpB != null)
            {
                lenB++;
                tmpB = tmpB.next;
            }
            var diff = Math.Abs(lenA - lenB);
            ListNode fast, slow;
            if(lenA > lenB)
            {
                fast = headA;
                slow = headB;
            }
            else
            {
                fast = headB;
                slow = headA;
            }
            while(diff > 0)
            {
                fast = fast.next;
                diff--;
            }
            while(fast != null)
            {
                if(fast == slow)    //wrong: fast.val == slow.val
                {
                    return fast;
                }
                fast = fast.next;
                slow = slow.next;
            }
            return null;

        }
    }
}
