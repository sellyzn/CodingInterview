using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.LinkedListProblems
{
    public class ReverseBetween92Daily
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            //虚拟头节点
            ListNode dummyNode = new ListNode(-1);
            dummyNode.next = head;

            ListNode pre = dummyNode;
            //第 1 步：从虚拟头节点走 left - 1 步，来到 left 节点的前一个节点
            // for 循环
            for(int i = 0; i < left - 1; i++)
            {
                pre = pre.next;
            }

            //第 2 步：从 pre 再走 right - left + 1 步，来到 right 节点
            ListNode rightNode = pre;
            for(int i = 0; i < right - left + 1; i++)
            {
                rightNode = rightNode.next;
            }

            //第 3 步：截取链表
            ListNode leftNode = pre.next;
            ListNode curr = rightNode.next;

            //注意：切断链接
            pre.next = null;
            rightNode.next = null;

            //第 4 步：反转链表的子区间
            ReverseLinkedList(leftNode);

            //第 5 步：接回到原来的链表中
            pre.next = rightNode;
            leftNode.next = curr;

            return dummyNode.next;
        }

        public void ReverseLinkedList(ListNode head)
        {            
            ListNode newHead = null;
            //不改变原来head指针的位置
            ListNode cur = head;
            while (head != null)
            {
                ListNode temp = cur.next;    
                cur.next = newHead;    
                newHead = cur;      
                cur = temp;    
            }            
        }
    }
}
