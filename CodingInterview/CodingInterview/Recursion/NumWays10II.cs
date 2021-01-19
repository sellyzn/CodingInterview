using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Recursion
{
    public class NumWays10II
    {
        public int numWays(int n)
        {
            if (n == 0)
                return 1;
            var dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 1000000007;
            }
            return dp[n];
        }
    }
}
