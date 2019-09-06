using System;
using System.Collections.Generic;
using DataStructureProblems.StackProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StackProblems
{
    [TestClass]
    public class StackSortTest
    {
        [TestMethod]
        public void TestStackSort()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(1);
            stack.Push(5);

            Stack<int> result = StackSorter.Sort(stack);

            Assert.AreEqual(1, result.Pop());
            Assert.AreEqual(5, result.Pop());
            Assert.AreEqual(10, result.Pop());

        }

        [TestMethod]
        public void TestStackSortOneItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            
            Stack<int> result = StackSorter.Sort(stack);

            Assert.AreEqual(10, result.Pop());

        }
    }
}
