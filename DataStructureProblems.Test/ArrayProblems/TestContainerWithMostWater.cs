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
    public class TestContainerWithMostWater
    {
        [TestMethod]
        public void TestArrayWithOnlyTwoItem()
        {
            int[] dataArray = { 2, 8 };
            int area = new ContainerWithMostWater().GetContainerWithMostWater(dataArray);
            Assert.AreEqual(2, area);
        }

        [TestMethod]
        public void TestStandardCase()
        {
            int[] dataArray = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int area = new ContainerWithMostWater().GetContainerWithMostWater(dataArray);
            Assert.AreEqual(49, area);
        }
    }
}
