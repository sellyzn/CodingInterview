using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Others
{
    public class Add65
    {
        public int add(int a, int b)
        {
            while(b != 0)  //当进位为0 时跳出
            {
                var c = (a & b) << 1;  //c = 进位
                a ^= b;  //a = 非进位和
                b = c;  //b = 进位
            }
            return a;
        }

        public int add1(int a, int b)
        {
            if (b == 0)
                return a;
            return add(a ^ b, (a & b) << 1);
        }
        public int add2(int a, int b)
        {
            var c = (a & b) << 1;
            var n = a ^ b;
            var r = c + n;
            return r;
        }

    }
}
