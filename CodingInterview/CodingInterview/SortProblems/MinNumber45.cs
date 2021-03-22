using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.SortProblems
{
    public class MinNumber45
    {
        /*剑指offer 45、把数组排成最小的数
        输入一个非负整数数组，把数组里所有数字拼接起来排成一个数，
        打印能拼接出的所有数字中最小的一个。

        示例 1:
        输入: [10,2]
        输出: "102"

        示例 2:
        输入: [3,30,34,5,9]
        输出: "3033459"

         */
        public string MinNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return "";
            //if (nums.Length == 1)
            //    return nums[0].ToString();
            string[] strs = new string[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                strs[i] = nums[i].ToString();
            }
            //QSort(strs, 0, strs.Length - 1);
            QuickSort(strs, 0, strs.Length - 1);
            StringBuilder sb = new StringBuilder();
            foreach(string s in strs)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        //pivot为strs[left]
        public void QuickSort(string[] strs, int left, int right)
        {
            if (left >= right)
                return;
            int l = left, r = right;
            string tmp = strs[l];
            while(l < r)
            {
                while ((strs[r] + strs[left]).CompareTo(strs[left] + strs[r]) >= 0 && l < r)
                    r--;
                while ((strs[l] + strs[left]).CompareTo(strs[left] + strs[l]) <= 0 && l < r)
                    l++;
                tmp = strs[l];
                strs[l] = strs[r];
                strs[r] = tmp;
            }
            strs[l] = strs[left];
            strs[left] = tmp;
            QuickSort(strs, left, l - 1);
            QuickSort(strs, l + 1, right);
        }

        public void Swap(string a, string b)
        {
            string temp = a;
            a = b; 
            b = temp;
        }
        public string Median3(string[] strs, int left, int right)
        {
            var center = (left + right) / 2;
            //if (strs[left].CompareTo(strs[center]) > 0)
            if ((strs[left] + strs[center]).CompareTo(strs[center] + strs[left]) > 0)
                Swap(strs[left], strs[center]);
            //if (strs[center].CompareTo(strs[right]) > 0)
            if ((strs[center] + strs[right]).CompareTo(strs[right] + strs[center]) > 0)
                Swap(strs[center], strs[right]);
            //if (strs[left].CompareTo(strs[right]) > 0)
            if ((strs[left] + strs[right]).CompareTo(strs[right] + strs[left]) > 0)
                Swap(strs[left], strs[right]);
            Swap(strs[center], strs[right - 1]);
            return strs[right - 1];
        }
        public void QSort(string[] strs, int left, int right)
        {
            if (left >= right)
                return;
            else if (right - left == 1)
            {
                if ((strs[left] + strs[right]).CompareTo(strs[right] + strs[left]) > 0)
                    Swap(strs[left], strs[right]);
            }
            else
            {
                string pivot = Median3(strs, left, right);
                int lowIndex = left + 1;
                int highIndex = right - 2;
                while (true)
                {
                    //while(strs[lowIndex].CompareTo(pivot) < 0)
                    while ((strs[lowIndex] + pivot).CompareTo(pivot + strs[lowIndex]) < 0)
                        lowIndex++;
                    //while (strs[highIndex].CompareTo(pivot) > 0)
                    while ((strs[highIndex] + pivot).CompareTo(pivot + strs[highIndex]) > 0)
                        highIndex--;
                    if (lowIndex < highIndex)
                        Swap(strs[lowIndex], strs[highIndex]);
                    else
                        break;
                }
                Swap(strs[lowIndex], strs[right - 1]);
                QSort(strs, left, lowIndex - 1);
                QSort(strs, lowIndex + 1, right);
            }
        }
    }
}
