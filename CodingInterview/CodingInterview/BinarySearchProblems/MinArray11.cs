﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.BinarySearchProblems
{
    public class MinArray11
    {
        public int minArray(int[] numbers)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while(left <= right)
            {
                var middle = left + (right - left) / 2;
                if (numbers[middle] > numbers[right])
                    left = middle + 1;
                else if (numbers[middle] < numbers[right])
                    right = middle - 1;
                else
                    right--;
            }
            return numbers[left];
        }

        //正确
        public int minArray1(int[] numbers)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
            {
                var middle = left + (right - left) / 2;
                if (numbers[middle] > numbers[right])
                    left = middle + 1;
                else if (numbers[middle] < numbers[right])
                    right = middle;
                else
                    right--;
            }
            return numbers[left];
        }
    }
}
