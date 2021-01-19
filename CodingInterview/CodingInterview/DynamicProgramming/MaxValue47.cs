using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DynamicProgramming
{
    public class MaxValue47
    {
        public int maxValue(int[][] grid)
        {
            var row = grid.Length;
            var column = grid[0].Length;
            var dp = new int[row,column];
            for(var i = 0; i < row; i++)
            {
                for(var j = 0; j < column; j++)
                {
                    if (i == 0 && j == 0)
                        dp[i,j] = grid[i][j];
                    else if(i == 0)
                    {
                        dp[i, j] = grid[i][j] + dp[i, j - 1];
                    }
                    else if(j == 0)
                    {
                        dp[i, j] = grid[i][j] + dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = grid[i][j] + Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }
            return dp[row - 1,column - 1];
        }
    }
}
