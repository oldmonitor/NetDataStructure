using System;
using DataStructureProblems.DecisionTreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.DecisionTreeProblems
{
    [TestClass]
    public class ClimbStairsTest
    {
        [TestMethod]
        public void TestWithOnlyOneStep()
        {
            ClimbStairs c = new ClimbStairs();
            int numberOfWay = c.FindNumberOfWayOfClimbingStairs(1);
            Assert.AreEqual(1, numberOfWay);
        }

        [TestMethod]
        public void TestWithOnlyTwoStep()
        {
            ClimbStairs c = new ClimbStairs();
            int numberOfWay = c.FindNumberOfWayOfClimbingStairs(2);
            Assert.AreEqual(2, numberOfWay);
        }

        [TestMethod]
        public void TestWithOnlyThreeStep()
        {
            ClimbStairs c = new ClimbStairs();
            int numberOfWay = c.FindNumberOfWayOfClimbingStairs(3);
            Assert.AreEqual(3, numberOfWay);
        }

    }
}
