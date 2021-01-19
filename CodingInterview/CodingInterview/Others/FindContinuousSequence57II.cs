using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Others
{
    public class FindContinuousSequence57II
    {
        public int[][] findContinuousSequence(int target)
        {
            var res = new List<int[]>();
            var left = 1;
            var right = 2;
            while(left < right)
            {
                var sum = (left + right) * (right - left + 1) / 2;
                if(sum == target)
                {
                    var subList = new int[right - left + 1];
                    var index = 0;
                    for(var i = left; i <= right; i++)
                    {
                        subList[index++] = i;
                    }
                    res.Add(subList);
                    left++;
                }
                else if(sum < target)
                {
                    right++;
                }
                else
                {
                    left++;
                }
            }
            return res.ToArray();
        }
    }
}
