using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TwoPointers
{
    public class FindNumberInTwoDArray04
    {
        public static bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            var x = matrix.Length - 1;
            var y = 0;
            while (x >= 0 && y <= matrix[0].Length - 1)
            {
                if(matrix[x][y] > target)
                {
                    x--;
                }else if(matrix[x][y] < target)
                {
                    y++;
                }else if(matrix[x][y] == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
