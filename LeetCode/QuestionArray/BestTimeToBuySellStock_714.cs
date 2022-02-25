using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/
    /// Explain: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/discuss/108870/Most-consistent-ways-of-dealing-with-the-series-of-stock-problems
    /// </summary>
    internal class BestTimeToBuySellStock_714
    {
        public BestTimeToBuySellStock_714()
        {
            int[] arr = new int[] { 1, 3, 2, 8, 4, 9 };
            Console.WriteLine(MaxProfit(arr, 2));
        }

        public int MaxProfit(int[] price, int fee)
        {
            int result = 0;
            int minPrice = price[0];
            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] < minPrice) minPrice = price[i]; 

                if (price[i] > minPrice + fee)
                {
                    result += price[i] - minPrice - fee;
                    minPrice = price[i] - fee;
                }
            }

            return result;
        }
    }
}
