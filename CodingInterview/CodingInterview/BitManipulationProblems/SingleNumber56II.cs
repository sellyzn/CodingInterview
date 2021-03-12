using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.BitManipulationProblems
{
    public class SingleNumber56II
    {
        public int singleNumber(int[] nums)
        {
            //if (nums == null || nums.Length == 0)
            //    return -1;

            var bitSum = new int[32];
            foreach(var num in nums)
            {
                var bitMask = 1;
                for(var i = 31; i >= 0; i--)
                {
                    if((bitMask & num) != 0)
                    {
                        bitSum[i]++;
                    }
                    bitMask <<= 1;
                }
            }

            var res = 0;
            for(var i = 0; i < 32; i++)
            {
                res <<= 1;
                res += bitSum[i] % 3;
            }
            return res;
        }
    }
}
