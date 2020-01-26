using System;
using DataStructureProblems.ArrayProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.ArrayProblems
{
    [TestClass]
    public class RemoveValueFromArrayTest
    {
        [TestMethod]
        public void TestArrayAllValueNeedToRemove()
        {
            int[] dataInput = new int[] { 1, 1, 1 };
            RemoveValueFromArray c = new RemoveValueFromArray();
            int[] finalOutput = c.HandleRemoveValueFromArray(dataInput, 1);
            Assert.AreEqual(0, finalOutput.Length);
        }

        [TestMethod]
        public void TestArrayWithValueToRemoveAtTheBeginningAndEnd()
        {
            int[] dataInput = new int[] { 1, 2, 1, 3, 1, 4 };
            RemoveValueFromArray c = new RemoveValueFromArray();
            int[] finalOutput = c.HandleRemoveValueFromArray(dataInput, 1);
            Assert.AreEqual(3, finalOutput.Length);

            bool hasTwo = false;
            bool hasThree = false;
            bool hasFour = false;

            foreach(int i in finalOutput)
            {
                if(i == 2)
                {
                    hasTwo = true;
                }
                if(i==3)
                {
                    hasThree = true;
                }
                if(i==4)
                {
                    hasFour = true;
                }
            }

            Assert.AreEqual(true, hasTwo);
            Assert.AreEqual(true, hasThree);
            Assert.AreEqual(true, hasFour);
        }

        [TestMethod]
        public void TestArrayWithOneItemLeftAfterRemoval()
        {

            int[] dataInput = new int[] { 1, 2, 1};
            RemoveValueFromArray c = new RemoveValueFromArray();
            int[] finalOutput = c.HandleRemoveValueFromArray(dataInput, 1);
            Assert.AreEqual(1, finalOutput.Length);

            bool hasTwo = false;
            foreach (int i in finalOutput)
            {
                if (i == 2)
                {
                    hasTwo = true;
                }
            }

            Assert.AreEqual(true, hasTwo);
            
        }



    }
}
