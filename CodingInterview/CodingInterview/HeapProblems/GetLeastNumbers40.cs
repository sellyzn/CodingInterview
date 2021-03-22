using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.HeapProblems
{
    public class GetLeastNumbers40
    {        
        //快速选择算法
        //堆

        public  int[] GetLessNumbersQS(int[] arr, int k)
        {
            int[] res = new int[k];
            if (k == 0)
                return res;            
            return QuickSearch(arr, 0, arr.Length - 1,  k);
        }
        public int[] QuickSearch(int[] nums, int left, int right, int k)
        {
            //每次快排切分 1 次， 找到排序后下标为 j 的元素， 如果 j 恰好等于 k ,就返回 j 以及 j 左边所有的数
            int j = Partition(nums, left, right);
            int[] res = new int[k];
            if(j == k - 1)    //注意 j 为下标，应为 j == k - 1 ，而非 j == k
            {
                for (int i = 0; i < k; i++)
                {
                    res[i] = nums[i];
                }
                return res;
            }
            // 同上，j > k - 1 而非 j > k
            return j > k - 1 ? QuickSearch(nums, left, j - 1, k) : QuickSearch(nums, j + 1, right, k);
        }
        //快排切分，返回下标 j ，使得比 nums[j] 小的数都在 j 的左边，比 nums[j] 大的数都在 j 的右边
        public int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[left];
            int l = left, r = right + 1;
            while (true)
            {
                //while (nums[++l] <= pivot && l < r) ;
                //while (nums[--r] >= pivot && l < r) ;
                //int tmp = nums[l];
                //nums[l] = nums[r];
                //nums[r] = tmp;
                while (++l <= right && nums[l] < pivot) ;
                while (--r >= left && nums[r] > pivot) ;
                if(l < r)
                {
                    int tmp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = tmp;
                }
                else
                {
                    break;
                }
            }
            //nums[left] = nums[l];
            //nums[l] = pivot;
            //return l;
            nums[left] = nums[r];
            nums[r] = pivot;
            return r;
        }


        public int PartitionO(int[] nums, int left, int right)
        {
            int pivot = nums[left];
            int l = left, r = right;
            while (true)
            {
                //也可以
                //while (l < r && nums[l] <= pivot)
                //    l++;
                //while ( l < r && nums[r] >= pivot)
                //    r--;
                
                //int tmp = nums[l];
                //nums[l] = nums[r];
                //nums[r] = tmp;
                
                while (l <= right && nums[l] <= pivot)
                    l++;
                while (r >= left && nums[r] >= pivot)
                    r--;
                if (l < r)
                {
                    int tmp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = tmp;
                }
                else
                {
                    break;
                }

            }
            nums[left] = nums[r];
            nums[r] = pivot;
            return r;
        }


    }
}
