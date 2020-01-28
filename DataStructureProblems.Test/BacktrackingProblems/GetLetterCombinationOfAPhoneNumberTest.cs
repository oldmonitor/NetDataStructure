using System;
using System.Collections.Generic;
using System.Data.Linq;
using DataStructureProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.BacktrackingProblems
{
    [TestClass]
    public class GetLetterCombinationOfAPhoneNumberTest
    {
        /*
         * mapping.Add(2, "abc");
            mapping.Add(3, "def");
            mapping.Add(4, "ghi");
            mapping.Add(5, "jkl");
            mapping.Add(6, "mno");
            mapping.Add(7, "pqrs");
            mapping.Add(8, "tuv");
            mapping.Add(9, "wxyz");*/
        [TestMethod]
        public void TestOneNumber()
        {
            GetLetterCombinationOfAPhoneNumber c = new GetLetterCombinationOfAPhoneNumber();
            List<string> result = c.HandleGetLetterCombinationOfAPhoneNumber("2");
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("a"));
            Assert.IsTrue(result.Contains("b"));
            Assert.IsTrue(result.Contains("c"));
        }

        [TestMethod]
        public void TestTwoNumber()
        {
            GetLetterCombinationOfAPhoneNumber c = new GetLetterCombinationOfAPhoneNumber();
            List<string> result = c.HandleGetLetterCombinationOfAPhoneNumber("29");
            Assert.AreEqual(12, result.Count);
            Assert.IsTrue(result.Contains("aw"));
            Assert.IsTrue(result.Contains("by"));
            Assert.IsTrue(result.Contains("cz"));
        }
    }
}
