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
    public class PermutationCheckerTest
    {
        [TestMethod]
        public void TestPermutation()
        {
            string s = "test";
            string s2 = "tset";

            bool boolResult =
            PermutationChecker.IsPermutatinEqual2(s, s2);

            Assert.IsTrue(boolResult);
        }

        [TestMethod]
        public void TestPermutationWithExtraCharacter()
        {
            string s = "test";
            string s2 = "tsett";

            bool boolResult =
            PermutationChecker.IsPermutatinEqual2(s, s2);

            Assert.IsFalse(boolResult);
        }
    }
}
