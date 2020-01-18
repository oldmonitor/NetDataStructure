using System;
using DataStructureProblems.MathProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.MathProblems
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void TestGetReversedPositiveInteger()
        {
            ReverseInteger reverseInteger = new ReverseInteger();
            int reversedInt = reverseInteger.GetReversedInteger(123456);
            Assert.AreEqual(654321, reversedInt);
        }

        [TestMethod]
        public void TestGetReversedNegativeInteger()
        {
            ReverseInteger reverseInteger = new ReverseInteger();
            int reversedInt = reverseInteger.GetReversedInteger(-123456);
            Assert.AreEqual(-654321, reversedInt);
        }
    }
}
