using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Heap
{
    public class GetLeastNumbers40
    {
        public int[] GetLessNumbers(int[] arr, int k)
        {
            if (k == 0 || arr.Length == 0)
                return new int[0];
            //最后一个参数表示我们要找的下标为k-1的数
            return QuickSearch(arr, 0, arr.Length - 1, k - 1);

        }
        public int[] QuickSearch(int[] nums, int lo, int hi, int k)
        {
            //
            int j = Partition(nums, lo, hi);
            if(j == k)
            {
                return Arrays.CopyOf(nums, j + 1);
            }
            return j > k ? QuickSearch(nums, lo, j - 1, k) : QuickSearch(nums, j + 1, hi, k);
        }

        private int Partition(int[] nums, int lo, int hi)
        {
            int v = nums[lo];
            int i = lo, j = hi + 1;
            while (true)
            {
                while()
            }
        }
    }
}
