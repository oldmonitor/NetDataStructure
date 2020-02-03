using System;
using DataStructureProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.DynamicProgrammingProblems
{
    [TestClass]
    public class LongestCommonSubstringTest
    {
        [TestMethod]
        public void TestTwoStringEqual()
        {
            string s1 = "abcdefg";
            string s2 = "abcdefg";
            LongestCommonSubstring c = new LongestCommonSubstring();
            string s = c.GetLongestCommonSubstring(s1, s2);
            Assert.AreEqual(s, "abcdefg");
        }

        [TestMethod]
        public void TestTwoStringWithNoSharedSubtring()
        {
            string s1 = "abcdefg";
            string s2 = "hijk";
            LongestCommonSubstring c = new LongestCommonSubstring();
            string s = c.GetLongestCommonSubstring(s1, s2);
            Assert.AreEqual(s, "");
        }

        [TestMethod]
        public void TestTwoStringWithSharedSubtring()
        {
            string s1 = "abcdefg";
            string s2 = "hiabcjkfg";
            LongestCommonSubstring c = new LongestCommonSubstring();
            string s = c.GetLongestCommonSubstring(s1, s2);
            Assert.AreEqual(s, "abc");
        }

    }
}
