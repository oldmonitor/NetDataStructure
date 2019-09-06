using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class TreeToLinkListConverter
    {
        /// <summary>
        /// Given a binary tree, design an algorithm which creates a linked list of all the nodes
        /// at each depth(e.g., if you have a tree with depth D, you'll have D linked lists).
        /// </summary>
        /// <returns></returns>
        public static List<List<TreeNode>> ConvertTreeToLists(TreeNode rootTree)
        {
            if(rootTree == null)
            {
                return null;
            }

            List<List<TreeNode>> result = new List<List<TreeNode>>();
            ConvertTreeTraverse(rootTree, result, 0);
            return result;
        }

        public static void ConvertTreeTraverse(TreeNode node, List<List<TreeNode>> treeNodeList, int level)
        {
            if(node == null)
            {
                return;
            }
            List<TreeNode> treeLevelList;
            if (treeNodeList.Count() == level)
            {
                treeLevelList = new List<TreeNode>();
                treeNodeList.Add(treeLevelList);
            }

            treeNodeList[level].Add(node);
            ConvertTreeTraverse(node.LeftNode, treeNodeList, level + 1);
            ConvertTreeTraverse(node.RightNode, treeNodeList, level + 1);

        }
    }
}
