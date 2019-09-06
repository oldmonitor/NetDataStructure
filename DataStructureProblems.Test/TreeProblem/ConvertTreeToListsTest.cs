using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureProblems.TreeProblems.DataStructures;
using DataStructureProblems.TreeProblems;

namespace DataStructureProblems.Test.TreeProblem
{
    /// <summary>
    /// Summary description for ConvertTreeToListsTest
    /// </summary>
    [TestClass]
    public class ConvertTreeToListsTest
    {
       
        [TestMethod]
        public void TestConvertingTreeWithOneLevelToList()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 1;

            var list = TreeToLinkListConverter.ConvertTreeToLists(root);

            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0].Count);
        }

        [TestMethod]
        public void TestConvertingTreeWithTwoLevelToList()
        {
            TreeNode root = new TreeNode();
            root.TreeNodeValue = 1;

            root.LeftNode = new TreeNode()
            {
                TreeNodeValue = 2
            };

            root.RightNode = new TreeNode()
            {
                TreeNodeValue = 3
            };

            var list = TreeToLinkListConverter.ConvertTreeToLists(root);

            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list[0].Count);
            Assert.AreEqual(2, list[1].Count);

        }
    }
}
