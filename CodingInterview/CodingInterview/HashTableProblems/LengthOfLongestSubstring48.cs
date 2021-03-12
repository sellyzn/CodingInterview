using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.HashTableProblems
{
    public class LengthOfLongestSubstring48
    {
        public int lengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;
            var dict = new Dictionary<char, int>();
            var left = 0;
            var max = 0;
            for(var right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left = Math.Max(left, dict[s[right]] + 1);
                    dict[s[right]] = right;

                }
                else
                {
                    dict.Add(s[right], right);
                }
                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
    }
}
