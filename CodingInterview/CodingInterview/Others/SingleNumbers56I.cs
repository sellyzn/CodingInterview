using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Others
{
    public class SingleNumbers56I
    {
        public int[] singleNumbers(int[] nums)
        {
            var xor = 0;  //用于计算nums的异或和
            foreach(var num in nums)
            {
                xor ^= num;  //计算异或和，并保存到xor
            }

            //设置div为1，则二进制为0001
            //div是一个二进制数，且其中只有一位是1，其他位全是0，
            //比如000010，表示我们用倒数第二位作为分组标准，倒数第二位是0的数字分到一组，倒数第二位是1的分到另一组。            
            var div = 1;  //获得ret中最低位的1


            while((div & xor) == 0)
            {
                div <<= 1;
            }

            var a = 0;
            var b = 0;

            foreach(var num in nums)
            {
                //根据&是否位0区分将两个数字分区，并分别求异或和
                if((div & num) != 0)
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
