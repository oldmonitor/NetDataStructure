using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    /*
     * Given a imbalance binary tree, print the leaf nodes then remove those leaf node, 
     * print the new leaf nodes until only root node left.
       For example:

              1
             / \
            2   3
           / \     
          4   5    
    Print: [4 5 3], [2], [1]
     * */
    public class L366_FindLeavesOfBinaryTree
    {
        /// <summary>
        /// The trick use height as position value in the list.
        /// When left child and right child have different height, pick the max value + 1 for parent
        /// </summary>
        /// <param name="treeRoot"></param>
        /// <returns></returns>
        public List<List<int>> FindLeaveOfBinaryTree(TreeNode treeRoot)
        {
            List<List<int>> result = new List<List<int>>();

            this.GetTreeHeight(treeRoot, result);
            return result;
        }

        private int GetTreeHeight(TreeNode node, List<List<int>> result)
        {
            if(node == null)
            {
                return -1;
            }
            int nodeHeight = 1 + Math.Max(GetTreeHeight(node.LeftNode, result), GetTreeHeight(node.RightNode, result));

            if(result.Count-1<nodeHeight)
            {
                result.Add(new List<int>());
            }

            result[nodeHeight].Add(node.TreeNodeValue);

            return nodeHeight;
        }
    }
}
