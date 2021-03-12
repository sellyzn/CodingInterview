using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.ArrayProblems
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

        public int findRepeatNumberR(int[] nums)
        {            
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i) //不能用if，因为如果只是if，只进行了单次交换。只能够使得nums[i]回到了nums[i]位置，但是交换来的值并不能保证归位了，也就是nums[i] 不一定不等于 i，随着i++，那么这个位置的值就不再被访问，就有可能出错。所以我们需要用while达到nums[i] = i才结束，确保每到一个位置，都能使得当前位置的值归位
                {
                    if (nums[i] == nums[nums[i]])
                    {
                        return nums[i];
                    }
                    var temp = nums[i];
                    nums[i] = nums[temp];
                    nums[temp] = temp;
                }
            }
            return -1;
        }       

    }
}
