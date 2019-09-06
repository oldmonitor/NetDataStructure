using DataStructureProblems.TreeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.Test.TreeProblem
{
    [TestClass]
    public class MinBSTTest
    {
        [TestMethod]
        public void TestMinBSTBalanceTree()
        {
            MinHeightTree minHeightTree = new MinHeightTree();
            int[] sortedIntArray = new int[] { 1, 2, 3 };
            var node = minHeightTree.GetMinBST(sortedIntArray);

            Assert.AreEqual(2, node.TreeNodeValue);
            Assert.AreEqual(1, node.LeftNode.TreeNodeValue);
            Assert.AreEqual(3, node.RightNode.TreeNodeValue);

        }

        [TestMethod]
        public void TestMinBSTWithOnlyOneItemInArray()
        {
            MinHeightTree minHeightTree = new MinHeightTree();
            int[] sortedIntArray = new int[] { 1};
            var node = minHeightTree.GetMinBST(sortedIntArray);

            Assert.AreEqual(1, node.TreeNodeValue);
        }

        [TestMethod]
        public void TestMinBSTWithOnlyTwoItemInArray()
        {
            MinHeightTree minHeightTree = new MinHeightTree();
            int[] sortedIntArray = new int[] { 1, 2 };
            var node = minHeightTree.GetMinBST(sortedIntArray);

            Assert.AreEqual(1, node.TreeNodeValue);
            Assert.AreEqual(2, node.RightNode.TreeNodeValue);

        }

        [TestMethod]
        public void TestMinBSTWith3LayersOfTree()
        {
            MinHeightTree minHeightTree = new MinHeightTree();
            int[] sortedIntArray = new int[] { 1, 2 , 3, 4, 5};
            var node = minHeightTree.GetMinBST(sortedIntArray);

            Assert.AreEqual(3, node.TreeNodeValue);

            Assert.AreEqual(1, node.LeftNode.TreeNodeValue);
            Assert.AreEqual(2, node.LeftNode.RightNode.TreeNodeValue);
            Assert.AreEqual(4, node.RightNode.TreeNodeValue);
            Assert.AreEqual(5, node.RightNode.RightNode.TreeNodeValue);
        }
    }
}
