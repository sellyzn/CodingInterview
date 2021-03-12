using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class TwoSum57
    {
        //two pointers
        public int[] twoSum(int[] nums, int target)
        {
            var i = 0;
            var j = nums.Length - 1;
            while(i < j)
            {
                var sum = nums[i] + nums[j];
                if (sum > target)
                    j--;
                else if (sum < target)
                    i++;
                else
                    return new int[] { nums[i], nums[j] };
            }
            return new int[0];
        }
                
    }
}
