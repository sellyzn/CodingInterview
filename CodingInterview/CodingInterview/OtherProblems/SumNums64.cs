using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class SumNums64
    {     
        //平均计算
        public int sumNums1(int n)
        {
            return (1 + n) * n / 2;
        }
        //迭代iteration
        public int sumNums2(int n)
        {
            var res = 0;
            for(var i = 1; i <= n; i++)
            {
                res += i;
            }
            return res;
        }
        //递归recurtion
        public int sumNums3(int n)
        {
            
            if (n == 1)
                return 1;
            n += sumNums3(n - 1);
            return n;
        }
        public int sumNums4(int n)
        {
            return n == 1 ? 1 : n + sumNums4(n - 1);
        }
        //逻辑运算符的短路效应
        int res = 0;
        public int sumNums(int n)
        {
            bool x = n > 1 && sumNums(n - 1) > 0;
            res += n;
            return res;
        }
    }
}
