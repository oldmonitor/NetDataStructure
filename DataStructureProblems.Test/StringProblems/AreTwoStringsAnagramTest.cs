using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureProblems.StringProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StringProblems
{
    [TestClass]
    public class AreTwoStringsAnagramTest
    {
        [TestMethod]
        public void TestTwoStringsAnagram()
        {
            string s = "abc";
            string s2 = "cba";
            AreTwoStringsAnagram c = new AreTwoStringsAnagram();
            bool b = c.IsAnagram(s, s2);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestTwoStringsNotAnagram()
        {
            string s = "abc";
            string s2 = "dba";
            AreTwoStringsAnagram c = new AreTwoStringsAnagram();
            bool b = c.IsAnagram(s, s2);
            Assert.AreEqual(false, b);
        }

    }
}
