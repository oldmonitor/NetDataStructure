using System;
using DataStructureProblems.TreeProblems;
using DataStructureProblems.TreeProblems.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.TreeProblem
{
    [TestClass]
    public class TestBinarySearchTreeChecker
    {
        [TestMethod]
        public void TestOneNodeTreeIsBalance()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 10;

            bool boolResult = BinarySearchTreeChecker.IsBinarySearchTree(root);

            Assert.AreEqual(true, boolResult);
        }

        [TestMethod]
        public void TestUnbalanceWithTwoLevel()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 10;

            TreeNode child = new TreeNode();
            child.TreeNodeValue = 5;

            TreeNode child2 = new TreeNode();
            child2.TreeNodeValue = 9;

            root.LeftNode = child;
            root.RightNode = child2;


            bool boolResult = BinarySearchTreeChecker.IsBinarySearchTree(root);

            Assert.AreEqual(false, boolResult);
        }

        [TestMethod]
        public void TestBalanceWithTwoLevel()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 10;

            TreeNode child = new TreeNode();
            child.TreeNodeValue = 5;

            TreeNode child2 = new TreeNode();
            child2.TreeNodeValue = 11;

            root.LeftNode = child;
            root.RightNode = child2;

            bool boolResult = BinarySearchTreeChecker.IsBinarySearchTree(root);

            Assert.AreEqual(true, boolResult);
        }

        [TestMethod]
        public void TestBalanceTreeWithThreeLevel()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 10;

            TreeNode child = new TreeNode();
            child.TreeNodeValue = 5;

            TreeNode child2 = new TreeNode();
            child2.TreeNodeValue = 11;

            TreeNode gchild1 = new TreeNode();
            gchild1.TreeNodeValue = 13;

            child2.RightNode = gchild1;

            root.LeftNode = child;
            root.RightNode = child2;

            bool boolResult = BinarySearchTreeChecker.IsBinarySearchTree(root);

            Assert.AreEqual(true, boolResult);
        }

        [TestMethod]
        public void TestUnBalanceTreeWithThreeLevel()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 10;

            TreeNode child = new TreeNode();
            child.TreeNodeValue = 5;

            TreeNode child2 = new TreeNode();
            child2.TreeNodeValue = 11;

            TreeNode gchild1 = new TreeNode();
            gchild1.TreeNodeValue = 1;

            child2.LeftNode = gchild1;

            root.LeftNode = child;
            root.RightNode = child2;

            bool boolResult = BinarySearchTreeChecker.IsBinarySearchTree(root);

            Assert.AreEqual(false, boolResult);
        }

    }
}
