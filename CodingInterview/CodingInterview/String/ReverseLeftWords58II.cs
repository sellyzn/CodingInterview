using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.String
{
    public class ReverseLeftWords58II
    {
        //StringBuilder
        public string reverseLeftWords(string s, int n)
        {
            var sb = new StringBuilder();
            for(var i = n; i < s.Length; i++)
            {
                sb.Append(s[i]);  //仅需在列表尾部添加元素，仅申请一次内存
            }
            for(var i = 0; i < n; i++)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        //String
        public string reverseLeftWords1(string s, int n)
        {
            var res = "";
            for(var i = n; i < s.Length; i++)
            {
                res += s[i];   //每次拼接都需要新建一个字符串， 总需要申请N次内存
            }
            for(var i = 0; i < n; i++)
            {
                res += s[i];
            }
            return res;
        }

        //substring
        public string reverseLeftWord2(string s, int n)
        {
            return s.Substring(n, s.Length) + s.Substring(0, n);
        }

        ////no extra space
        //public string reverseLeftWords3(string s, int n)
        //{
        //    reverse(s, 0, n - 1);
        //    reverse(s, n, s.Length - 1);
        //    reverse(s, 0, s.Length - 1);
        //    return s;
        //}
        //public string reverse(string s, int begin, int end)
        //{
        //    while(begin <= end)
        //    {
        //        //swap(s[begin], s[end]);
        //        var temp = s[begin];
        //        s[begin] = s[end];
        //        s[end] = temp;
        //        begin++;
        //        end--;
        //    }
        //    return s;
        //}
        //public void swap(char s1, char s2)
        //{
        //    var temp = s1;
        //    s1 = s2;
        //    s2 = temp;
        //}
    }
}
