using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.HashTable
{
    public class FirstUniqChar50
    {
        //Dictionary
        public char firstUniqChar(string s)
        {
            //var res = ' ';
            if (s == null || s.Length == 0)
                return ' ';
            var dict = new Dictionary<char, int>();
            for(var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict.Add(s[i], 1);
            }
            foreach(var item in dict)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return ' ';
        }

        //Array
        public char firstUniqChar1(string s)
        {
            var count = new int[26];
            foreach(char c in s){
                count[c - 'a']++;
            }
            foreach(var c in s)
            {
                if (count[c - 'a'] == 1)
                    return c;
            }
            return ' ';
        }
    }
}
