using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedListProblems
{
    public class ReversePrint06
    {
        public int[] reversePrint(ListNode head)
        {
            if (head == null)
                return new int[0];
            var temp = head;
            var len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }
            var resArr = new int[len];
            var cur = head;
            for (var i = len - 1; i >= 0 && cur != null; i--)
            {
                resArr[i] = cur.val;
                cur = cur.next;
            }
            return resArr;
        }

        //use stack
        public int[] reversePrint1(ListNode head)
        {            
            Stack<int> s = new Stack<int>();
            while (head != null)
            {
                s.Push(head.val);
                head = head.next;
            }
            int[] ans = new int[s.Count];   //no need to specify the situation: head == null
            int len = s.Count;
            for (int i = 0; i < len; i++)
            {
                ans[i] = s.Pop();
            }
            return ans;
        }
    }
}
