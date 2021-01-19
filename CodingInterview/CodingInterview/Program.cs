using CodingInterview.Array;
using CodingInterview.BinarySearch;
using CodingInterview.DivideAndConquer;
using CodingInterview.DynamicProgramming;
using CodingInterview.HashTable;
using CodingInterview.LinkedList;
using CodingInterview.Mathematics;
using CodingInterview.Others;
using CodingInterview.String;
using CodingInterview.Tree;
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
            //var arr = new int[] { 1, 2, 3, 2 };
            //var fi = new FindRepeatNumber03();
            //var res = fi.findRepeatNumberR(arr);
            //var se = new Search53();
            //var res = se.search(arr, 5);
            //Console.WriteLine(res);

            //var arr = new int[][]
            //{
            //    new int[]{1, 2, 3, 4},
            //    new int[]{5, 6, 7, 8},
            //    new int[]{9, 10, 11, 12},
            //    //new int[]{13, 14, 15, 16}
            //};
            //var so = new SpiralOrder29();
            //var res = so.spiralOrder(arr);
            //foreach (var num in res)
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

            //var arr = new int[] { 3, 1, 3 };
            //var ma = new MinArray11();
            //var res = ma.minArray1(arr);
            //Console.WriteLine(res);

            //var s = "abcdefg";
            //var rl = new ReverseLeftWords58II();
            //var res = rl.reverseLeftWords(s, 2);
            //Console.WriteLine(res);


            //var s = " the sky   is blue  ";
            //var rl = new ReverseWords58I();
            //var res = rl.reverseWords1(s);
            //Console.WriteLine(res);

            //var s = "42";
            //var s = "-42";
            //var s = "4193 with words";
            //var s = "words and 987";
            //var s = "-2147483647";
            //var sti = new StrToInt67();
            //var res = sti.strToInt2(s);
            //Console.WriteLine(res);

            //var s = "abcabcbb";
            //var lls = new LengthOfLongestSubstring48();
            //var res = lls.lengthOfLongestSubstring(s);
            //Console.WriteLine(res);

            //int a = 1000;
            //int b = 1000;
            //Console.WriteLine(a == b);

            //var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //var max = new MaxSubArray42();
            //var res = max.maxSubArray2(nums);
            //Console.WriteLine(res);

            //var grid = new int[][] {new int[] {1,3,1},
            //                        new int[]{1,5,1},
            //                        new int[]{4,2,1}};
            //var maxvalue = new MaxValue47();
            //var res = maxvalue.maxValue(grid);
            //Console.WriteLine(res);

            //var n = 0;
            //var pn = new PrintNumbers17();
            //var res = pn.printNumbers(n);
            //foreach(var num in res)
            //{
            //    Console.WriteLine(num);
            //}
            //var nums = new int[] { 1, 2, 3, 4 };
            //var nums = new int[0] ;
            //var ex = new Exchange21();
            //var res = ex.exchange(nums);
            //foreach(var num in res)
            //{
            //    Console.WriteLine(num);
            //}

            //var nums = new int[] { 4, 1, 4, 6 };
            //var sn = new SingleNumbers56I();
            //var res = sn.singleNumbers(nums);
            //foreach(var num in res)
            //{
            //    Console.WriteLine(num);
            //}

            //var nums = new int[] { 3, 9, 20, 15, 7 };
            //var lo = new LevelOrder32I();
            //var tree = lo.levelOrder(nums);
            var result = new LeverOrder32III();
            result.Test();

        }

       

        

        //public static ListNode reverseList(ListNode head)
        //{
        //    if (head == null || head.next == null)
        //        return head;
        //    ListNode cur = null;
        //    var pre = head;
        //    while(pre != null)
        //    {
        //        var tmp = pre.next;                              
        //        pre.next = cur;
        //        cur = pre;
        //        pre = tmp;

        //    }
        //    return cur;
        //}

        


        


    }
}
