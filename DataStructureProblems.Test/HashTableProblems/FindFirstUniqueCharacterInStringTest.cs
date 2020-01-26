using System;
using DataStructureProblems.HashtableProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.HashTableProblems
{
    [TestClass]
    public class FindFirstUniqueCharacterInStringTest
    {
        [TestMethod]
        public void TestOneCharacterArray()
        {
            string input = "a";
            FindFirstUniqueCharacterInString c = new FindFirstUniqueCharacterInString();
            var output = c.GetFirstUniqueCharacterInString(input);
            Assert.AreEqual('a', output);
        }

        [TestMethod]
        public void TestUniqueCharacterAtTheEnd()
        {
            string input = "aaababc";
            FindFirstUniqueCharacterInString c = new FindFirstUniqueCharacterInString();
            var output = c.GetFirstUniqueCharacterInString(input);
            Assert.AreEqual('c', output);
        }


    }
}
