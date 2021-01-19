using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Others
{
    public class IsStraight61
    {
        public bool isStraight(int[] nums)
        {
            //求数组中最大值和最小值
            var set = new HashSet<int>();
            var min = 13;
            var max = 0;
            foreach (var num in nums)
            {
                if (num == 0)
                    continue;
                max = Math.Max(num, max);
                min = Math.Min(num, min);
                if (set.Contains(num))
                    return false;
                set.Add(num);
            }
            return max - min < 5;
        }
    }
}
