using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.MathematicsProblems
{
    public class PrintNumbers17
    {       
        public int[] printNumbers(int n)
        {
            var end = (int)Math.Pow(10, n) - 1;
            var res = new int[end];
            for(var i = 0; i < end; i++)
            {
                res[i] = i + 1;
            }
            return res;
        }
    }
}
