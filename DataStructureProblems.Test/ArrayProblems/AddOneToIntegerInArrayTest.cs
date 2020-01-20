using System;
using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class AddOneToIntegerInArrayTest
    {
        [TestMethod]
        public void TestAddOneWithNoCarry()
        {
            int[] dataArray = new int[] { 1, 2 };
            AddOneToIntegerInArray a = new AddOneToIntegerInArray();
            int[] dataResult = a.HandleIntegerArrayPlusOne(dataArray);

            Assert.AreEqual(2, dataResult.Length);
            Assert.AreEqual(1, dataResult[0]);
            Assert.AreEqual(3, dataResult[1]);
        }

        [TestMethod]
        public void TestAddOneWithCarry()
        {
            int[] dataArray = new int[] { 3, 9, 9 };
            AddOneToIntegerInArray a = new AddOneToIntegerInArray();
            int[] dataResult = a.HandleIntegerArrayPlusOne(dataArray);

            Assert.AreEqual(3, dataResult.Length);
            Assert.AreEqual(4, dataResult[0]);
            Assert.AreEqual(0, dataResult[1]);
            Assert.AreEqual(0, dataResult[2]);

        }

        [TestMethod]
        public void TestAddOneWithCarryNeedExtraDigit()
        {
            int[] dataArray = new int[] { 9, 9, 9 };
            AddOneToIntegerInArray a = new AddOneToIntegerInArray();
            int[] dataResult = a.HandleIntegerArrayPlusOne(dataArray);

            Assert.AreEqual(4, dataResult.Length);
            Assert.AreEqual(1, dataResult[0]);
            Assert.AreEqual(0, dataResult[1]);
            Assert.AreEqual(0, dataResult[2]);
            Assert.AreEqual(0, dataResult[3]);

        }

    }
}
