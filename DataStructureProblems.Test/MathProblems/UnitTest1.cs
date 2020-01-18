using System;
using DataStructureProblems.MathProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.MathProblems
{
    [TestClass]
    public class RomanToIntegerTest
    {
        [TestMethod]
        public void TestConvertRomanToInteger()
        {
            RomanToInteger rom = new RomanToInteger();

            string input;
            int output;
            input = "III";
            output = rom.ConvertRomanToInteger(input);
            Assert.AreEqual(3, output);

            input = "IV";
            output = rom.ConvertRomanToInteger(input);
            Assert.AreEqual(4, output);

            input = "IX";
            output = rom.ConvertRomanToInteger(input);
            Assert.AreEqual(9, output);

            input = "LVIII";
            output = rom.ConvertRomanToInteger(input);
            Assert.AreEqual(58, output);

            input = "MCMXCIV";
            output = rom.ConvertRomanToInteger(input);
            Assert.AreEqual(1994, output);

        }
    }
}
