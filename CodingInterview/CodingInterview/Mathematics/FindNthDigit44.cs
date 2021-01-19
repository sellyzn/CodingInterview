using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Mathematics
{
    public class FindNthDigit44
    {
        //public int findNthDigit(int n)
        //{
        //    var digit = 1;
        //    var start = 1;
        //    var count = 9;
        //    while(n > count)
        //    {
        //        n -= count;
        //        digit += 1;
        //        start *= 10;
        //        count = digit * start * 9;
        //    }
        //    var num = start + (n - 1) / digit;
        //    return num.ToString().IndexOf((n - 1) % digit) - '0';
        //}

        public int findNthDigit1(int n)
        {
            if (n == 0) return 0;
            //由于是n=0时对应开始的0，这里不需要进行减操作n--;，但是如果n=1对应开始的0则需要减操作
            //排除n=0后，后面n从1开始。
            var digit = 1;  //数字的位数
            var start = 1;  //每digit位数的起始数字
            long count = 9; //count的值有可能会超出int的范围，所以变量类型取为long

            /*确定n所在数字的位数digit*/
            while (n > count)
            {//不能带=号，此时n从1开始，n=count时，属于上一个循环的最后一个数字
                n = (int)(n - count);//这里(int)不能省略
                digit++;
                start = start * 10;
                count = (long)start * 9 * digit;
                //这里的long不能省略，否则，会先按照int类型进行计算，然后赋值给long型的count，超过int大小限制时，会出现负数
            }

            /*确定n所在的数字，记为num*/
            var num = start + (n - 1) / digit;

            /*确定n是数字num中的哪一位，并返回结果*/
            var index = (n - 1) % digit;//index最大取digit-1,即此时num坐标从左到右为0,1,...,digit-1,共digit位
            while (index < (digit - 1))
            {
                //最后的结果是num中的第index个数字，index从左到右从0开始递增，考虑到踢出右侧末尾的数字比较简单，我们从右侧开始依次踢出数字
                num = num / 10;
                digit--;
            }
            return num % 10;//此时num的右侧末尾数字即为结果
        }
    }
}
