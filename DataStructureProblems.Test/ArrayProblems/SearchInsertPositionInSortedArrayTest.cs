using System;
using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class SearchInsertPositionInSortedArrayTest
    {
        [TestMethod]
        public void TestItemExistsInArray()
        {
            int[] dataArray = new int[] { 1, 3, 5, 6 };
            SearchInsertPositionInSortedArray searchInsertPositionInSortedArray = new SearchInsertPositionInSortedArray();
            int intResult =
                searchInsertPositionInSortedArray.HandleSearchInsertPositionInSortedArray(dataArray, 5);
            Assert.AreEqual(2, intResult);
        }

        [TestMethod]
        public void TestItemAtTheEndOfArray()
        {
            int[] dataArray = new int[] { 1, 3, 5, 6 };
            SearchInsertPositionInSortedArray searchInsertPositionInSortedArray = new SearchInsertPositionInSortedArray();
            int intResult =
                searchInsertPositionInSortedArray.HandleSearchInsertPositionInSortedArray(dataArray, 7);
            Assert.AreEqual(4, intResult);
        }

        [TestMethod]
        public void TestItemAtTheBeginningOfArray()
        {
            int[] dataArray = new int[] { 1, 3, 5, 6 };
            SearchInsertPositionInSortedArray searchInsertPositionInSortedArray = new SearchInsertPositionInSortedArray();
            int intResult =
                searchInsertPositionInSortedArray.HandleSearchInsertPositionInSortedArray(dataArray, 0);
            Assert.AreEqual(0, intResult);
        }

        [TestMethod]
        public void TestItemInTheMiddleOfArray()
        {
            int[] dataArray = new int[] { 1, 3, 5, 6 };
            SearchInsertPositionInSortedArray searchInsertPositionInSortedArray = new SearchInsertPositionInSortedArray();
            int intResult =
                searchInsertPositionInSortedArray.HandleSearchInsertPositionInSortedArray(dataArray, 2);
            Assert.AreEqual(1, intResult);
        }
    }
}
