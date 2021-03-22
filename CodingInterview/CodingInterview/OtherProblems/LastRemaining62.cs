using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class LastRemaining62
    {
        // 约瑟夫环问题 //

        /*Offer 62、圆圈中最后剩下的数字
        0,1,···,n-1这n个数字排成一个圆圈，从数字0开始，
        每次从这个圆圈里删除第m个数字（删除后从下一个数字开始计数）。
        求出这个圆圈里剩下的最后一个数字。

        例如，0、1、2、3、4这5个数字组成一个圆圈，从数字0开始每次删除第3个数字，
        则删除的前4个数字依次是2、0、4、1，因此最后剩下的数字是3。

        示例 1：
        输入: n = 5, m = 3
        输出: 3

        示例 2：
        输入: n = 10, m = 17
        输出: 2
        
         */

        /*建模：f(n,m)
         * 长度为 n 的序列会先删除第 m % n 个元素，然后剩下一个长度为 n - 1 的序列。
         * 那么，我们可以递归地求解 f(n - 1, m)， 就可以知道对于剩下的 n - 1  个元素，最终会留下第几个元素，我们设答案为 x = f(n -  1, m).
         * 
         * 由于我们删除了第 m % n 个元素，将序列的长度变为 n - 1。
         * 当我们知道了 f(n - 1, m) 对应的答案 x 之后，我们也就可以知道，
         * 长度为 n 的序列最后一个删除的元素，应当是从 m % n 开始数的第 x 个元素。、
         * 因此有 f(n, m) = (m % n + x) % n = (m + x) % n。
         * 
         * f(n-1, m)=x表示的含义，是从索引0开始的第x个数；
         * 而f(n, m)执行一次的索引位置在第m%n个数；
         * 
         * 
         * 
         * 
         */



        /* 动态规划：
         * 输入 n, m ，记此约瑟夫环问题为 「n, m 问题」 ，设解（即最后留下的数字）为 f(n)f(n) ，则有：

           「n, m 问题」：数字环为 0, 1, 2, ..., n - 1 ，解为 f(n) ；
           「n-1, m 问题」：数字环为 0, 1, 2, ..., n - 2 ，解为 f(n-1) ；
            以此类推……

            对于「n, m 问题」，首轮删除环中第 m 个数字后，得到一个长度为 n - 1 的数字环。
            由于有可能 m > n ，因此删除的数字为 (m−1)%n ，删除后的数字环从下个数字（即 m%n ）开始，设 t=m%n ，可得数字环：

            t, t + 1, t + 2, ..., 0, 1, ..., t - 3, t - 2
 
            删除一轮后的数字环也变为一个「n-1, m 问题」，观察以下数字编号对应关系：

           「n-1, m 问题」      -->    「n, m 问题」删除后 
            
                       0       -->         t + 0  
                       1       -->         t + 1
                       ...     -->         ...
                       n−2     -->         t - 2
   
            设「n-1, m 问题」某数字为 x ，则可得递推关系：
                   
            x → (x+t)%n

            换而言之，若已知「n-1, m 问题」的解 f(n - 1) ，则可通过以上公式计算得到「n, m」的解 f(n) ，即：
          
            f(n)
            =(f(n−1)+t)%n
            =(f(n−1)+m%n)%n
            =(f(n−1)+m)%n
​	
         */

        //recursion
        public int LastRemainingRec(int n, int m)
        {
            return Recursive(n, m);
        }
        public int Recursive(int n, int m)
        {
            if (n == 1)
                return 0;
            int x = Recursive(n - 1, m);
            return (m + x) % n;
        }

        //Iteration
        public int LastRemaining(int n, int m)
        {
            if (n == 1)
                return 0;
            int x = 0;
            for (int i = 2; i <= n; i++)
            {
                x = (x + m) % i;
            }
            return x;
        }

        /* 假设当前删除的位置是 idxidx，下一个删除的数字的位置是 idx + m 。
         * 但是，由于把当前位置的数字删除了，后面的数字会前移一位，所以实际的下一个位置是 idx + m - 1。
         * 由于数到末尾会从头继续数，所以最后取模一下，就是 (idx+m−1)(modn)。

         */
        public int LastRemaing1(int n, int m)
        {
            if (n == 1)
                return 0;
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                list.Add(i);
            }
            int idx = 0;
            while(n > 1)
            {

                idx = (idx + m - 1) % n;               
                list.Remove(list[idx]);
                n--;
            }
            return list[0];
        }

    }
}
