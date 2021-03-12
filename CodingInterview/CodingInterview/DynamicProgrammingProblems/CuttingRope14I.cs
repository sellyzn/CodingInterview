using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DynamicProgrammingProblems
{
    public class CuttingRope14I
    {
        //Math
        public int CuttingRope(int n)
        {
            //int res = 0;
            //if(n <= 3)
            //{
            //    res = n - 1;
            //}
            //else
            //{
            //    int a = n / 3;
            //    int b = n % 3;
            //    if (b == 0)                
            //        res = (int)Math.Pow(3, a);
            //    if (b == 1)
            //        res = (int)Math.Pow(3, a - 1) * 4;
            //    if (b == 2)
            //        res = (int)Math.Pow(3, a) * 2;
            //}
            //return res;


            if (n <= 3)
                return n - 1;

            int a = n / 3;
            int b = n % 3;
            if (b == 0)
            {
                return (int)Math.Pow(3, a);
            }else if (b == 1)
            {
                return (int)Math.Pow(3, a - 1) * 4;
            }
            else
            {
                return (int)Math.Pow(3, a) * 2;                
            } 
        }

        //Dynamic Programming
        public int CuttingRope1(int n)
        {
            int[] dp = new int[n + 1];
            //初始状态
            dp[2] = 1;
            //状态转移方程
            for(int i = 2; i <= n; i++)
            {                
                for(int j = 1; j < i; j++)
                {
                    dp[i] = (int)Math.Max(dp[i], Math.Max(j * (i - j), j * dp[i - j]));
                }
            }
            //返回值
            return dp[n];
        }

        //Recursive
        public int CuttingRope2(int n)
        {
            if (n == 2)
                return 1;
            int res = 0;
            for(int i = 2; i < n; i++)
            {
                res = (int)Math.Max(res, Math.Max(i * (n - i), i * CuttingRope2(n - i)));
            }
            return res;
        }
    }
}
