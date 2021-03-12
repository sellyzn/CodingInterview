using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.ArrayProblems
{
    public class Search53
    {        
        public int search1(int[] nums, int target)
        {
            //search right boundary
            var i = 0;
            var j = nums.Length - 1;
            
            while(i <= j)
            {
                var middle = i + (j - i) / 2;
                if (nums[middle] < target)
                    i = middle + 1;
                else
                    j = middle - 1;
            }
            var right = i;
            //no target in array
            if (j >= 0 && nums[j] != target)
                return 0;
            //search leftboundary
            i = 0;
            j = nums.Length - 1;
            while(i <= j)
            {
                var middle = i + (j - 1) / 2;
                if (nums[middle] < target)
                    i = middle + 1;
                else
                    j = middle - 1;
            }
            var left = j;
            return right - left - 1;
        }



        public int search(int[] nums, int target)
        {
            return helper(nums, target) - helper(nums, target - 1);
        }
        public int helper(int[] nums, int target)
        {
            var i = 0;
            var j = nums.Length - 1;

            while (i <= j)
            {
                var middle = i + (j - i) / 2;
                if (nums[middle] <= target)
                    i = middle + 1;
                else
                    j = middle - 1;
            }
            return i;
        }

    }
}
