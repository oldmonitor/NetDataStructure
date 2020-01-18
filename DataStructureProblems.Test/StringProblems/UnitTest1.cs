using System;
using DataStructureProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StringProblems
{
    [TestClass]
    public class LongestCommonPrefixTest
    {
        [TestMethod]
        public void TestGetLongestCommonPrefix()
        {
            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            string[] stringArray = new string[] { "abc", "ab" };
            string prefix = longestCommonPrefix.GetLongestCommonPrefix(stringArray);

            Assert.AreEqual("ab", prefix);
        }

        [TestMethod]
        public void TestEmptyPrefix()
        {
            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            string[] stringArray = new string[] { "abc", "efg" };
            string prefix = longestCommonPrefix.GetLongestCommonPrefix(stringArray);

            Assert.AreEqual("", prefix);
        }
    }
}
