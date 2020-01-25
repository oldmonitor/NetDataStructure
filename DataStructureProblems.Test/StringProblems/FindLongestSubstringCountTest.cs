using System;
using DataStructureProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StringProblems
{
    [TestClass]
    public class FindLongestSubstringCountTest
    {
        [TestMethod]
        public void TestWithJustOneCharacter()
        {
            FindLongestSubstringCount c = new FindLongestSubstringCount();
            string s = "a";
            int len = c.HandleFindLongestSubstringCount(s);
            Assert.AreEqual(1, len);
        }

        [TestMethod]
        public void TestWithLongestSubstringAtTheEnd()
        {
            FindLongestSubstringCount c = new FindLongestSubstringCount();
            string s = "ababcabcd";
            int len = c.HandleFindLongestSubstringCount(s);
            Assert.AreEqual(4, len);
        }

        [TestMethod]
        public void TestWithLongestSubstringInMiddle()
        {
            FindLongestSubstringCount c = new FindLongestSubstringCount();
            string s = "ababcdeabcd";
            int len = c.HandleFindLongestSubstringCount(s);
            Assert.AreEqual(5, len);
        }
    }
}
