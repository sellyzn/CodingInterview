using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedList
{
    public class ReverseList24
    {
        //双链表
        public ListNode reverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode newHead = null;
            while (head != null)
            {
                var temp = head.next;    //先保存访问节点的下一个节点，保存起来，下一次访问用
                head.next = newHead;    //断开节点，将原链表的当前访问节点指向新链表的头节点
                newHead = head;      //更新新链表的头节点，将当前访问节点作为新链表的头节点。
                head = temp;    //更新原链表的头节点，即当前访问节点，继续访问
            }
            return newHead;
        }
    }
}
