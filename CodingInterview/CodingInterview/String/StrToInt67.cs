using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.String
{
    public class StrToInt67
    {
        //官方解法
        public int strToInt(string str)
        {
            var res = 0;
            var bndry = int.MaxValue / 10;
            var i = 0;
            var sign = 1;
            var length = str.Length;
            if (length == 0)
                return 0;
            while(str[i] == ' ')
            {
                if (++i == length)
                    return 0;
            }
            if (str[i] == '-')
                sign = -1;
            if (str[i] == '-' || str[i] == '+')
                i++;
            for(var j = i; j < length; j++)
            {
                if (str[j] < '0' || str[j] > '9')
                    break;
                if (res > bndry || res == bndry && str[i] > '7')
                    return sign == 1 ? int.MaxValue : int.MinValue;
                res = res * 10 + (str[i] - '0');
            }
            return sign * res;
        }


        public int strToInt1(string str)
        {
            char[] cs = str.Trim().ToCharArray();//这个必须在前，否则" "输入在第二个if处会报错
            if (cs.Length == 0) return 0;//字符串为空或字符串仅包含空白字符时,返回0;
            int i = 0;
            int flag = 1;//默认输出的数为正数
                         //确定是否存在符号位
            if (cs[i] == '+') i++;
            else if (cs[i] == '-')
            {//这里else不能少,否则"+"或者"+-"输入会报错
                i++;
                flag = -1;
            }
            long res = 0;//这里必须是long，否则后面的判断临界值时计算会越界，无法判断出正确的结果，如输入"-91283472332"时
            while (i < cs.Length)
            {//尽量取更多的数字
                if (cs[i] > '9' || cs[i] < '0') break;
                if (flag == 1 && res * 10 + flag * (cs[i] - '0') > int.MaxValue) return int.MaxValue;
                if (flag == -1 && res * 10 + flag * (cs[i] - '0') < int.MinValue) return int.MinValue;
                res = res * 10 + flag * (cs[i] - '0');
                i++;
            }
            return (int)res;//这里强转不能省略;
        }

        public int strToInt2Mine(string str)
        {
            //str = str.Trim();
            //if (str.Length == 0)
            //    return 0;
            
            var i = 0;
            var flag = 1;
            for (i = 0; i < str.Length && str[i] == ' '; i++) ;
            if(i == str.Length)
            {
                return 0;
            }else if (str[i] == '+')
            {
                i++;
            }
            else if(str[i] == '-')
            {
                i++;
                flag = -1;
            }
            double res = 0;  //long不够
            while(i < str.Length)
            {
                if (str[i] < '0' || str[i] > '9')
                    break;
                if (flag == 1 && res * 10 + flag * (str[i] - '0') > int.MaxValue)
                    return int.MaxValue;
                if (flag == -1 && res * 10 + flag * (str[i] - '0') < int.MinValue)
                    return int.MinValue;
                res = res * 10 + flag * (str[i] - '0');
                i++;
            }
            return (int)res;
        }
    }
}
