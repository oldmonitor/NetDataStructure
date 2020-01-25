using System;
using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class RemoveDuplicateInSortedArrayTest
    {
        [TestMethod]
        public void TestOneDuplicateIntArray()
        {
            int[] data = new int[] { 5, 5 };
            RemoveDuplicateInSortedArray c = new RemoveDuplicateInSortedArray();
            int[] result = c.HandleRemoveDuplicateInSortedArray(data);
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(5, result[0]);
        }

        [TestMethod]
        public void TestMultipleDuplicateIntArray()
        {
            int[] data = new int[] { 5, 5 , 7, 7, 7, 10};
            RemoveDuplicateInSortedArray c = new RemoveDuplicateInSortedArray();
            int[] result = c.HandleRemoveDuplicateInSortedArray(data);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(7, result[1]);
            Assert.AreEqual(10, result[2]);

        }
    }
}
