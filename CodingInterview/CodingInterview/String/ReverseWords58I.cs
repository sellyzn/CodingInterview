using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.String
{
    public class ReverseWords58I
    {
        //利用“字符串分割”、“列表倒序”的内置函数（面试时不建议使用）
        public string reverseWords(string s)
        {
            string[] strs = s.Trim().Split(" ");   //删除首尾空格，分割字符串
            var res = new StringBuilder();
            for(var i = strs.Length - 1; i>= 0; i--)   //倒叙遍历单词列表
            {
                if (strs[i].Equals(""))  //遇到空单词则跳过
                    continue;
                res.Append(strs[i] + " "); //将单词拼接至StringBuilder
            }
            return res.ToString().Trim();  //转化为字符串，删除尾部空格，并返回
        }

        //双指针
        public string reverseWords1(string s)
        {
            s = s.Trim();
            var j = s.Length - 1;
            var i = j;
            var res = new StringBuilder();
            while(i >= 0)
            {
                while (i >= 0 && s[i] != ' ')  //搜索首个空格
                    i--;
                res.Append(s.Substring(i + 1, j - i) + " ");  //添加单词
                while (i >= 0 && s[i] == ' ')  //跳过单词间空格
                    i--;
                j = i;  //j之子昂下个单词的尾字符
            }
            return res.ToString().Trim();
        }
    }
}
