using System;
using DataStructureProblems.StackProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StackProblems
{
    [TestClass]
    public class ValidParenthesesTest
    {
        [TestMethod]
        public void TestValidParen()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            bool isValid = validParentheses.IsParenthesesValid("{}[](test)");
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestValidParenEmptyString()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            bool isValid = validParentheses.IsParenthesesValid("");
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestInValidParenString()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            bool isValid = validParentheses.IsParenthesesValid("{");
            Assert.IsFalse(isValid);

            isValid = validParentheses.IsParenthesesValid("{}]");
            Assert.IsFalse(isValid);
        }




    }
}
