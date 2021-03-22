using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.SortProblems
{
    public class QuickSortAlgorithm
    {
        public void QuickSort(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return;
            QSort1(nums, 0, nums.Length - 1);
        }
        public void QSort(int[] nums, int left, int right)
        {
            if (right - left <= 0)
                return;
            else
            {
                int pivot = Median3(nums, left, right);
                int lowIndex = left, highIndex = right;
                while (true)
                {
                    while (nums[++lowIndex] < pivot) ;
                    while (nums[--highIndex] > pivot) ;
                    if(lowIndex < highIndex)
                    {
                        Swap(nums[lowIndex], nums[highIndex]);
                    }
                    else
                    {
                        break;
                    }
                }
                Swap(nums[lowIndex], nums[right - 1]);
                QSort(nums, left, lowIndex - 1);
                QSort(nums, lowIndex + 1, right);
            }
        }
        public int Median3(int[] nums, int left, int right)
        {
            int center = left + (right - left) / 2;
            if (nums[left] > nums[center])
                Swap(nums[left], nums[center]);
            if (nums[center] > nums[right])
                Swap(nums[center], nums[right]);
            if (nums[left] > nums[right])
                Swap(nums[left], nums[right]);
            Swap(nums[center], nums[right - 1]);
            return nums[right - 1];
        }
        public void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void QSort1(int[] nums, int left, int right)
        {
            if (left >= right)
                return;
            //else
            //{
                //int pivot = nums[left];
                int lowIndex = left, highIndex = right;
                int tmp = nums[lowIndex];
                while(lowIndex < highIndex)
                {
                    while(nums[lowIndex] <= nums[left] && lowIndex < highIndex)
                    {
                        lowIndex++;
                    }
                    while(nums[highIndex] >= nums[left] && lowIndex < highIndex)
                    {
                        highIndex--;
                    }
                    //if(lowIndex < highIndex)
                    //{
                        tmp = nums[lowIndex];
                        nums[lowIndex] = nums[highIndex];
                        nums[highIndex] = tmp;
                    //}
                    //else
                    //{
                    //    break;
                    //}
                }
                
                nums[lowIndex] = nums[left];
                nums[left] = tmp;
                QSort1(nums, left, lowIndex - 1);
                QSort1(nums, lowIndex - 1, right);

            //}
        }
    }
}
