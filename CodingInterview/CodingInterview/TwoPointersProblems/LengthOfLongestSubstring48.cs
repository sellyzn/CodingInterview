using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TwoPointersProblems
{
    public class LengthOfLongestSubstring48
    {
        public int lengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;            
            var dict = new Dictionary<char,int>();
            var left = 0;
            var max = 0;
            for(var right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left = Math.Max(left, dict[s[right]] + 1);
                }
                dict.Add(s[right], right);  //report ArgumentException: An item with the same key has already been added.
                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
        public int lengthOfLongestSubstringRelease(string s)
        {
            if (s.Length == 0)
                return 0;
            var dict = new Dictionary<char, int>();
            var left = 0;
            var max = 0;
            for (var right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left = Math.Max(left, dict[s[right]] + 1);
                    dict[s[right]] = right;  //update the index value
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
