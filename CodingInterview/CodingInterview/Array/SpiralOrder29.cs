using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Array
{
    public class SpiralOrder29
    {
        public int[] spiralOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return new int[0];

            var left = 0;
            var top = 0;
            var right = matrix[0].Length - 1;
            var bottom = matrix.Length - 1;
            var res = new int[(right + 1) * (bottom + 1)];
            var k = 0;

            while(left <= right && top <= bottom)
            {
                // 从左到右
                for(var i = left; i <= right; i++)
                {
                    res[k++] = matrix[top][i];
                }
                top++;
                //从上到下
                for(var i = top; i <= bottom; i++)
                {
                    res[k++] = matrix[i][right];
                }
                right--;
                //从右到左
                for(var i = right; i >= left && top <= bottom; i--)
                {
                    res[k++] = matrix[bottom][i];
                }
                bottom--;
                //从下到上
                for(var i = bottom; i >= top && left <= right; i--)
                {
                    res[k++] = matrix[i][left];
                }
                left++;
            }
            return res;

        }
    }
}
