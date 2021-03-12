using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class Exchange21
    {
        public int[] exchange(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            while(left < right)
            {
                if(nums[left] % 2 == 0)
                {
                    //swap(nums[left], nums[right]);
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return nums;
        }
        public void swap(int a, int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
