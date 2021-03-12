using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.BitManipulationProblems
{
    public class SingleNumbers56I
    {
        public int[] singleNumbers(int[] nums)
        {
            var xor = 0;  //初始化异或结果位0
            foreach(var num in nums)
            {
                xor ^= num;    //求数组中所有元素异或结果
            }
            var mask = 1;  //定位，异或结果的从最低位起第一位为1的那一位，初始化值为1
            while((xor & mask) == 0)   //判断某位是否位1，若不为1，则向左移一位
            {
                mask <<= 1;
            }
            var a = 0;  //初始化不相同的两个数都为0
            var b = 0;
            foreach(var num in nums)
            {
                //分组
                //两个只出现一次的数字在不同的组中
                //相同的数字会被分到相同的组中。
                if ((mask & num) == 0)  //类似于奇偶分组，以mask位奇偶分组，将只出现一次的这两个数分到两个不同的组（相等的数肯定分到同一组，所以在同一组异或结果位0）
                {
                    a ^= num;
                }
                else
                {
                    b ^= num;
                }
            }
            return new int[] { a, b };
        }
    }
}
