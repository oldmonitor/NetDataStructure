using DataStructureProblems.BacktrackingProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.Test.BacktrackingProblems
{
    [TestClass]
    public class FindAllPossibleSubsetsTest
    {
        [TestMethod]
        public void TestListWithJustOneItem()
        {
            FindAllPossibleSubsets c = new FindAllPossibleSubsets();
            List<List<string>> result = c.HandleFindAllPossibleSubsets(new List<string>() { "a" });
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("a", result[0][0]);
        }

        [TestMethod]
        public void TestListWithJustTwoItem()
        {
            FindAllPossibleSubsets c = new FindAllPossibleSubsets();
            List<List<string>> result = c.HandleFindAllPossibleSubsets(new List<string>() { "a", "b", "c" });
            Assert.AreEqual(7, result.Count);
        }

    }
}
