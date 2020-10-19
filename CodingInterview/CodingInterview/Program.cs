using CodingInterview.Array;
using CodingInterview.BinarySearch;
using CodingInterview.LinkedList;
using System;
using System.Collections.Generic;

namespace CodingInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var arr = new int[] { 1, 2, 3, 4, 5 };
            //var li = new MyLinkedList(arr);
            ////var k = 2;
            ////var res = getKthFromEnd(li.head, k);
            ////var r = res;
            ////while(r != null)
            ////{
            ////    Console.WriteLine(r.val);
            ////    r = r.next;
            ////}
            //ListNode li1 = null;
            //var tmp = new ReversePrint06();
            //var resArr = tmp.reversePrint(li1);
            ////var res1 = ReversePrint06.reversePrint(li1);
            ////if (resArr == null)
            ////    Console.WriteLine("the list is null");
            ////else
            ////{
            //    foreach (var num in resArr)
            //    {
            //        Console.WriteLine(num);
            //    }
            ////}

            //var rl = reverseList(li.head);
            //var resl = rl;
            //while (resl != null)
            //{
            //    Console.WriteLine(resl.val);
            //    resl = resl.next;
            //}


            //var arrA = new int[] { 4, 1 ,8 ,4, 5 };
            //var arrB = new int[] { 5, 0, 1, 8, 4, 5 };

            //var liA = new MyLinkedList(arrA);
            //var liB = new MyLinkedList(arrB);
            //var resLi = getIntersectionNode(liA.head, liB.head);
            //Console.WriteLine(resLi.val);

            //while(resLi != null)
            //{
            //    Console.WriteLine(resLi.val);
            //    resLi = resLi.next;
            //}


            //var arr = new int[] { 1, 2, 5, 9 };
            //var li = new MyLinkedList(arr);
            //var res = deleteNode1(li.head, 5);
            //while(res != null)
            //{
            //    Console.WriteLine(res.val);
            //    res = res.next;
            //}


            //var arr = new int[] { 1, 3, 3, 3, 4, 6 };
            ////var fi = new findRepeatNumber03();
            ////var res = fi.findRepeatNumber(arr);
            //var se = new Search53();
            //var res = se.search(arr,5);
            //Console.WriteLine(res);

            //var arr = new int[][]
            //{
            //    new int[]{1, 2, 3, 4},
            //    new int[]{5, 6, 7, 8},
            //    new int[]{9, 10, 11, 12},
            //};
            //var so = new SpiralOrder29();
            //var res = so.spiralOrder(arr);
            //foreach(var num in res)
            //{
            //    Console.WriteLine(num);
            //}

            //var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 };
            //var arr = new int[] { 0, 1, 3 };
            //var mn = new MissingNumber53II();
            //var res = mn.missingNumber(arr);
            //Console.WriteLine(res);

            //[1, 3, 5]
            //[3, 1, 3]

            var arr = new int[] { 3, 1, 3};
            var ma = new MinArray11();
            var res = ma.minArray1(arr);
            Console.WriteLine(res);
            

        }

       

        

        public static ListNode reverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode cur = null;
            var pre = head;
            while(pre != null)
            {
                var tmp = pre.next;                              
                pre.next = cur;
                cur = pre;
                pre = tmp;

            }
            return cur;
        }

        


        


    }
}
