using System;
using DataStructureProblems.TreeProblems;
using DataStructureProblems.TreeProblems.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.TreeProblem
{
    [TestClass]
    public class TreeHeightTest
    {
        [TestMethod]
        public void TestGettingHeightForOneLevelTree()
        {
            TreeNode tn = new TreeNode()
            {
                TreeNodeValue = 1
            };

            int height = GetTreeHeight.GetHeight(tn);
            Assert.AreEqual(1, height);
        }

        [TestMethod]
        public void TestUnbalanceTreeHeight()
        {
            TreeNode tn = new TreeNode()
            {
                TreeNodeValue = 1
            };

            TreeNode child = new TreeNode()
            {
                TreeNodeValue = 2
            };

            TreeNode grandchild = new TreeNode()
            {
                TreeNodeValue = 3
            };

            child.LeftNode = grandchild;
            tn.LeftNode = child;

            int height = GetTreeHeight.GetHeight(tn);
            Assert.AreEqual(3, height);

        }


        [TestMethod]
        public void TestBalanceTreeHeight()
        {
            TreeNode tn = new TreeNode()
            {
                TreeNodeValue = 1
            };

            TreeNode child = new TreeNode()
            {
                TreeNodeValue = 2
            };

            TreeNode child2 = new TreeNode()
            {
                TreeNodeValue = 3
            };

            tn.RightNode = child2;
            tn.LeftNode = child;

            int height = GetTreeHeight.GetHeight(tn);
            Assert.AreEqual(2, height);

        }
    }
}
