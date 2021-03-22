using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class ConstructArr66
    {
        //表格分区，动态规划，dp

        /*剑指offer 66、构建乘积数组
        给定一个数组 A[0,1,…,n-1]，请构建一个数组 B[0,1,…,n-1]，
        其中 B[i] 的值是数组 A 中除了下标 i 以外的元素的积, 
        即 B[i]=A[0]×A[1]×…×A[i-1]×A[i+1]×…×A[n-1]。不能使用除法。

        示例:
        输入: [1,2,3,4,5]
        输出: [120,60,40,30,24]

         */
        public int[] ConstructArr(int[] a)
        {
            //特例
            if (a == null || a.Length == 0)
                return new int[0];

            int[] b = new int[a.Length];
            int[] left = new int[a.Length];
            int[] right = new int[a.Length];

            //计算left[i]
            left[0] = 1;
            for(int i = 1; i < a.Length; i++)
            {
                left[i] = left[i - 1] * a[i - 1];
            }
            //计算right[i]
            right[a.Length - 1] = 1;
            for(int i = a.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * a[i + 1];
            }
            //计算b[i]
            for(int i = 0; i < a.Length; i++)
            {
                b[i] = left[i] * right[i];
            }
            return b;
        }
    }
}
