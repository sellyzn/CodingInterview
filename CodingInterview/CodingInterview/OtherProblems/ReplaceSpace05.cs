using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.OtherProblems
{
    public class ReplaceSpace05
    {
        public string replaceSpace(string s)
        {
            var sb = new StringBuilder();
            foreach(var c in s)
            {
                if (c == ' ')
                    sb.Append("%20");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
