using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.ArrayProblems
{
    public class MissingNumber53II
    {
        public int missingNumber(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left <= right)
            {
                var middle = left + (right - left) / 2;
                if (nums[middle] == middle)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return left;
        }
    }
}
