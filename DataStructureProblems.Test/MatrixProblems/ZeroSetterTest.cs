using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using DataStructureProblems.MatrixProblems;

namespace DataStructureProblems.Test.MatrixProblems
{
    /// <summary>
    /// Summary description for ZeroSetterTest
    /// </summary>
    [TestClass]
    public class ZeroSetterTest
    {
        public ZeroSetterTest()
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
        public void TestZeroSettingWhenElementsHaveNoZero()
        {
 
            int[,] input = new int[3, 3]
            {
                {
                    1, 2, 3
                },
                 {
                    1, 2, 3
                },
                 {
                    1, 2, 3
                }
            };

            int[,] expected = new int[3, 3]
            {
                {
                    1, 2, 3
                },
                 {
                    1, 2, 3
                },
                 {
                    1, 2, 3
                }
            };

            ZeroColumnRowSetter.SetZeroValue(input);

            bool isEqual = MatrixComparer.Are2DEqual(input, expected);
            Assert.IsTrue(isEqual);
        }

        [TestMethod]
        public void TestZeroSettingWhenMatrixHasOneZero()
        {
            int[,] input = new int[3, 3]
           {
                {
                    1, 0, 3
                },
                 {
                    1, 2, 3
                },
                 {
                    1, 2, 3
                }
           };

            int[,] expected = new int[3, 3]
            {
                {
                    0, 0, 0
                },
                 {
                    1, 0, 3
                },
                 {
                    1, 0, 3
                }
            };

            ZeroColumnRowSetter.SetZeroValue(input);

            bool isEqual = MatrixComparer.Are2DEqual(input, expected);
            Assert.IsTrue(isEqual);
        }
        
    }
}
