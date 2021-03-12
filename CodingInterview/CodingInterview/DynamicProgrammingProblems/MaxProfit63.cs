using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DynamicProgrammingProblems
{
    public class MaxProfit63
    {
        public int maxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            var minPrice = prices[0];
            var maxPro = 0;
            foreach(var price in prices)
            {
                minPrice = Math.Min(minPrice, price);
                maxPro = Math.Max(maxPro, price - minPrice);
            }
            return maxPro;
        }
    }
}
