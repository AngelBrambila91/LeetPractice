using System;
using static System.Console;
namespace BestTimeToBuyStocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] prices = new int []{2, 4, 1};
            WriteLine(MaxProfit(prices));

        }

        public static int MaxProfit (int [] prices)
        {
            int buy;
            int maxProfit = 0;
            buy = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if(buy > prices[i])
                {
                    buy = prices[i];
                }
                else if (prices[i] - buy > maxProfit)
                {
                    maxProfit = prices[i] - buy;
                }
            }
            return maxProfit;
        }
    }
}