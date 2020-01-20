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
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void MergeTwoArrayOfDifferntSize()
        {
            MergeSortedArray testClass = new MergeSortedArray();
            int[] array1 = new int[] { 1, 3 };
            int[] array2 = new int[] { 2 };
            int[] array3 = testClass.MergeTwoSortedArray(array1, array2);
            Assert.AreEqual(3, array3.Length);
            Assert.AreEqual(1, array3[0]);
            Assert.AreEqual(3, array3[2]);
        }

        [TestMethod]
        public void MergeTwoArrayOneEmptyArray()
        {
            MergeSortedArray testClass = new MergeSortedArray();
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { };
            int[] array3 = testClass.MergeTwoSortedArray(array1, array2);
            Assert.AreEqual(3, array3.Length);
            Assert.AreEqual(1, array3[0]);
            Assert.AreEqual(3, array3[2]);
        }


        [TestMethod]
        public void TestMethod2MergeTwoArrayOfDifferntSize()
        {

            MergeSortedArray testClass = new MergeSortedArray();
            int[] array1 = new int[] { 1, 3 };
            int[] array2 = new int[] { 2 };
            int[] array3 = testClass.MergeTwoSortedArraySame(array1, array2);
            Assert.AreEqual(3, array3.Length);
            Assert.AreEqual(1, array3[0]);
            Assert.AreEqual(3, array3[2]);
        }


        [TestMethod]
        public void TestMethod2MergeTwoArrayOneEmptyArray()
        {
            MergeSortedArray testClass = new MergeSortedArray();
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { };
            int[] array3 = testClass.MergeTwoSortedArraySame(array1, array2);
            Assert.AreEqual(3, array3.Length);
            Assert.AreEqual(1, array3[0]);
            Assert.AreEqual(3, array3[2]);
        }

    }
}
