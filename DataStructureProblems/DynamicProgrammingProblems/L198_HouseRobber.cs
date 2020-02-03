using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.DynamicProgrammingProblems
{
    /*
    You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
    Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.

    Example 1:

    Input: [1,2,3,1]
    Output: 4
    Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
                 Total amount you can rob = 1 + 3 = 4.
    Example 2:

    Input: [2,7,9,3,1]
    Output: 12
    Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
                 Total amount you can rob = 2 + 9 + 1 = 12.
     * */
    public class HouseRobber
    {
        /// <summary>
        /// dynamic problem. The current node holds the max profit.
        /// </summary>
        /// <param name="houses"></param>
        /// <returns></returns>
        public int GetTotalAmountYouCanRob(int[] houses)
        {
            if(houses.Length ==0)
            {
                return 0;
            }

            if (houses.Length == 1)
            {
                return houses[0];
            }

            if (houses.Length == 2)
            {
                return Math.Max(houses[0], houses[1]);
            }

            int[] totalAmount = new int[houses.Length];
            // at each point (going from left to right), determine the max profit. current house plus i-2 or profit at i-1
            for(int i=2; i<houses.Length; i++)
            {
                totalAmount[i] = Math.Max(houses[i] + totalAmount[i - 2], totalAmount[i - 1]);
            }

            return totalAmount[houses.Length - 1];
        }
    }
}
