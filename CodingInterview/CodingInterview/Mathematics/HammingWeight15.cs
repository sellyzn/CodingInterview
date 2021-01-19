using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Mathematics
{
    public class HammingWeight15
    {
        //bit manipulation
        public int hammingWeight(uint n)
        {
            uint res = 0;
            while(n != 0)
            {
                res += n & 1;                
                n >>= 1;
            }
            return (int)res;

        }
        // use the property: n & (n - 1)
        public int hammingWeight1(uint n)
        {
            var res = 0;
            while(n != 0)
            {
                res++;
                n = n & (n - 1);
            }
            return res;
        }
    }
}
