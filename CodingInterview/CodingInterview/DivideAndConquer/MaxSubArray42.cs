using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DivideAndConquer
{
    public class MaxSubArray42
    {
        //divide and conquer
        //public int maxSubArray(int[] nums)
        //{

        //}
        //dynamic programming        
        public int maxSubArray1(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            var maxSum = nums[0];
            var sum = nums[0];
            for(var i = 1; i < nums.Length; i++)
            {
                if(sum > 0)
                {
                    sum += nums[i];
                }
                else
                {
                    sum = nums[i];
                }
                if (sum > maxSum)
                    maxSum = sum;
            }
            return maxSum;
        }
        //Greedy
        public int maxSubArray2(int[] nums)
        {
            var maxSum = nums[0];
            var sum = nums[0];
            for(var i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                maxSum = Math.Max(maxSum, sum);
            }
            return maxSum;
        }
    }
}
