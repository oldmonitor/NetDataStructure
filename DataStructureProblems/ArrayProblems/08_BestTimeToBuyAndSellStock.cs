using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class BestTimeToBuyAndSellStock
    {
        public int GetMaxProfit(int[] stockPrice)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for(int i=0;i<stockPrice.Length;i++)
            {
                if(stockPrice[i] < minPrice)
                {
                    minPrice = stockPrice[i];
                }
                else
                {
                    if((stockPrice[i] - minPrice) > maxProfit)
                    {
                        maxProfit = stockPrice[i] - minPrice;
                    }
                }
            }

            return maxProfit;

        }
    }
}
