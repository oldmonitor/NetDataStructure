using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class BestTimeToBuyAndSellStockTest
    {
        [TestMethod]
        public void TestArrayWithJustOneItem()
        {
            int[] dataArray = new int[] { 1 };
            BestTimeToBuyAndSellStock c = new BestTimeToBuyAndSellStock();
            int profit = c.GetMaxProfit(dataArray);
            Assert.AreEqual(0, profit);
        }

        [TestMethod]
        public void TestArrayWithTwoItem()
        {
            int[] dataArray = new int[] { 1, 4 };
            BestTimeToBuyAndSellStock c = new BestTimeToBuyAndSellStock();
            int profit = c.GetMaxProfit(dataArray);
            Assert.AreEqual(3, profit);
        }

        [TestMethod]
        public void TestArray()
        {
            int[] dataArray = new int[] { 7, 1, 5, 3, 6, 4 };
            BestTimeToBuyAndSellStock c = new BestTimeToBuyAndSellStock();
            int profit = c.GetMaxProfit(dataArray);
            Assert.AreEqual(5, profit);
        }
    }
}
