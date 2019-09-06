using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureProblems.ArrayProblems;

namespace DataStructureProblems.Test.ArrayProblems
{
    /// <summary>
    /// Summary description for StringRotationTest
    /// </summary>
    [TestClass]
    public class StringRotationTest
    {
        public StringRotationTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SameStringHasSameRotaionTest()
        {
            string s = "test";
            string s2 = "test";

            bool boolResult =
            StringRotationChecker.IsRotation(s, s2);

            Assert.IsTrue(boolResult);
        }

        [TestMethod]
        public void RotatedStringTest()
        {
            string s = "stte";
            string s2 = "test";

            bool boolResult =
            StringRotationChecker.IsRotation(s, s2);

            Assert.IsTrue(boolResult);
        }
    }
}
