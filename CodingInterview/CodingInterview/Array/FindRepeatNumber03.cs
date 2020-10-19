using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Array
{
    public class FindRepeatNumber03
    {
        public int findRepeatNumber(int[] nums)
        {
            var set = new HashSet<int>();
            foreach(var num in nums)
            {
                if (set.Contains(num))
                    return num;
                else
                    set.Add(num);
            }
            return -1;
        }

        public int findRepeatNumberrr(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i)
                {
                    if (nums[i] == nums[nums[i]])
                    {
                        return nums[i];
                    }
                    temp = nums[i];
                    nums[i] = nums[temp];
                    nums[temp] = temp;
                }
            }
            return -1;
        }
    }
}
