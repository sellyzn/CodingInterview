using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DynamicProgrammingProblems
{
    public class MaxSubArray42
    {
        //divide and conquer
        //public int maxSubArray(int[] nums)
        //{

        //}
        //dynamic programming   
        //No change original array
        //dp[i] = dp[i-1] + nums[i], dp[i-1] >0
        //dp[i] = nums[i], dp[i-1] <= 0
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
