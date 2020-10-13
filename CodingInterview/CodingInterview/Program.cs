using CodingInterview.LinkedList;
using System;

namespace CodingInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var k = 2;
            var li = new MyLinkedList(arr);
            var res = GetKthFromEnd(li.head, k);
            var r = res;
            while(r != null)
            {
                Console.WriteLine(r.val);
                r = r.next;
            }
        }

        public static ListNode GetKthFromEnd(ListNode head, int k)
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
