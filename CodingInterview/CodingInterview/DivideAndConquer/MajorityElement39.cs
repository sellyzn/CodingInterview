using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DivideAndConquer
{
    public class MajorityElement39
    {
        //HashMap
        public int majorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (i > nums.Length / 2 && dict[nums[i]] > nums.Length / 2)
                    return nums[i];
            }
            return 0;
        }

        //Sorted Array
        public int majorityElement1(int[] nums)
        {
            quickSort(nums,nums.Length);
            return nums[nums.Length / 2];
        }
        public void swap(int a, int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        public int Median3(int[] sourceArray, int left, int right)
        {
            var center = (left + right) / 2;
            if (sourceArray[left] > sourceArray[center])
                swap(sourceArray[left], sourceArray[center]);
            if (sourceArray[left] > sourceArray[right])
                swap(sourceArray[left], sourceArray[right]);
            if (sourceArray[center] > sourceArray[right])
                swap(sourceArray[center], sourceArray[right]);
            /*now, sourceArray[Left] < sourceArray[Center] < sourceArray[Right]*/
            swap(sourceArray[center], sourceArray[right - 1]);    //put the pivot to the right side
            /*we only need to consider sourceArray[Left+1]...sourceArray[Right -2]*/
            return sourceArray[right - 1];    //return the pivot
        }

        public void qSort(int[] sourceArray, int left, int right)
        {/*key recursive function*/
            //int pivot, Cutoff, lowIndex, highIndex;
            //if (Cutoff <= Right - Left)    // If the elements are enough, use quick sort algorithm 
            //{
            var pivot = Median3(sourceArray, left, right);    // select pivot
            var lowIndex = left;
            var highIndex = right - 1;    // two pointers, the LowIndex if beginning from Left, LowIndex++. the HighIndex is begining from Right-1, HighIndex--
            while (true)       // compare sequence elements with pivot, put the smaller elements to the left of the pivot, put the larger elements to the right of the pivot.
            {
                while (sourceArray[++lowIndex] < pivot) ;    //If the element is smaller than pivot, shift right, LowIndex++
                while (sourceArray[--highIndex] > pivot) ;    //If the element is larger than pivot, shift left, HighIndex--

                if (lowIndex < highIndex)    //Jump out of the above two loop, if LowIndex < HighIndex, than swap the two element
                    swap(sourceArray[lowIndex], sourceArray[highIndex]);
                else
                    break;
            }
            swap(sourceArray[lowIndex], sourceArray[right - 1]);    //put the pivot to the correct place
            qSort(sourceArray, left, lowIndex - 1);    //recursively resolve the left sub-sequence
            qSort(sourceArray, lowIndex + 1, right);    //recursively resolve the right sub-sequence
            //}
            //else
            //    InsertionSort(sourceArray + Left, Right - Left + 1);    //If the elements are two less, than use simple sort algrithm
        }

        public void quickSort(int[] sourceArray, int n)
        {/*Unified interface*/
            qSort(sourceArray, 0, n - 1);
        }

        //Morl Vote
        public int majorityElement2(int[] nums)
        {
            var x = 0;
            var votes = 0;
            foreach(var num in nums)
            {
                if (votes == 0)
                    x = num;
                votes += num == x ? 1 : -1;
            }
            return x;
        }
    }
}
