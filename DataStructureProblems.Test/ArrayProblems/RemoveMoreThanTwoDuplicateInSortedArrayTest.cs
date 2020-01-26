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
    public class RemoveMoreThanTwoDuplicateInSortedArrayTest
    {
        [TestMethod]
        public void TestDupOfOneNumber()
        {
            int[] input = new int[] { 1, 1, 1, 1 };
            RemoveMoreThanTwoDuplicateInSortedArray c = new RemoveMoreThanTwoDuplicateInSortedArray();
            int[] output = c.HandleRemoveMoreThanTwoDuplicateInSortedArray(input);
            Assert.AreEqual(2, output.Length);
            Assert.AreEqual(1, output[0]);
            Assert.AreEqual(1, output[1]);
        }

        [TestMethod]
        public void TestNoDup()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            RemoveMoreThanTwoDuplicateInSortedArray c = new RemoveMoreThanTwoDuplicateInSortedArray();
            int[] output = c.HandleRemoveMoreThanTwoDuplicateInSortedArray(input);
            Assert.AreEqual(4, output.Length);
            Assert.AreEqual(1, output[0]);
            Assert.AreEqual(2, output[1]);
            Assert.AreEqual(3, output[2]);
            Assert.AreEqual(4, output[3]);

        }


        [TestMethod]
        public void TestOneCharacter()
        {
            int[] input = new int[] { 1};
            RemoveMoreThanTwoDuplicateInSortedArray c = new RemoveMoreThanTwoDuplicateInSortedArray();
            int[] output = c.HandleRemoveMoreThanTwoDuplicateInSortedArray(input);
            Assert.AreEqual(1, output.Length);
            Assert.AreEqual(1, output[0]);
            
        }

        [TestMethod]
        public void TestDupOfMultipleNumber()
        {
            int[] input = new int[] { 1, 1, 1, 1, 2, 3, 3, 3, 4, 4 };
            RemoveMoreThanTwoDuplicateInSortedArray c = new RemoveMoreThanTwoDuplicateInSortedArray();
            int[] output = c.HandleRemoveMoreThanTwoDuplicateInSortedArray(input);
            Assert.AreEqual(7, output.Length);
            Assert.AreEqual(1, output[0]);
            Assert.AreEqual(1, output[1]);

            Assert.AreEqual(2, output[2]);

            Assert.AreEqual(3, output[3]);

            Assert.AreEqual(3, output[4]);
            Assert.AreEqual(4, output[5]);
            Assert.AreEqual(4, output[6]);
        }





    }
}
