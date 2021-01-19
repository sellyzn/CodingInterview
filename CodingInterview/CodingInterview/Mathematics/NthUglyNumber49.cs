using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Mathematics
{
    public class NthUglyNumber49
    {
        public int nthUglyNumber(int n)
        {
            var a = 0;
            var b = 0;
            var c = 0;
            var dp = new int[n];
            dp[0] = 1;
            for(var i = 1; i < n; i++)
            {
                var n2 = dp[a] * 2;
                var n3 = dp[b] * 3;
                var n5 = dp[c] * 5;
                dp[i] = Math.Min(Math.Min(n2, n3), n5);
                if (dp[i] == n2)
                    a++;
                if (dp[i] == n3)
                    b++;
                if (dp[i] == n5)
                    c++;
            }
            return dp[n - 1];
        }
    }
}
