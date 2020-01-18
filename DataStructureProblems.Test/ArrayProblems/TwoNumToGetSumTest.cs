using System;
using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class TwoNumToGetSumTest
    {
        [TestMethod]
        public void NormalSuccessTest()
        {
            TwoNumToGetSum twoNumToGetSum = new TwoNumToGetSum();
            int[] intArray1 = new int[] { 2, 7, 11, 15 };
            var index = twoNumToGetSum.GetIndicesForSumValue(intArray1, 9);
            Assert.AreEqual(0, index[0]);
            Assert.AreEqual(1, index[1]);
        }


    }
}
