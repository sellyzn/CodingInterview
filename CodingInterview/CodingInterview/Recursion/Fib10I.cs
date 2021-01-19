using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Recursion
{
    public class Fib10I
    {
        public int fib(int n)
        {
            var a = 0;
            var b = 1;
            for(var i = 0; i < n; i++)
            {
                var sum = (a + b) % 1000000007;
                a = b;
                b = sum;
            }
            return a;
        }
        public int fib1(int n)
        {
            if (n == 0)
                return 0;
            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 1000000007;
            }
            return dp[n];
        }

    }
}
