using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class BinarySearchTreeChecker
    {
        /// <summary>
        /// Check if tree is binary search tree. 
        /// Note: in binary search tree, 
        /// - left side subtree is small or equal than current node
        /// - right side subtree is larger than the current node
        /// this is not a binary search tree: 9 is larger than 8
        ///     8
        ///  2     12
        ///1   9  10  13
        /// </summary>
        /// <param name="root"></param>
        public static bool IsBinarySearchTree(TreeNode root)
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        public static bool IsBinarySearchTree(TreeNode node, int minNumber, int maxNumber)
        {
            if(node == null)
            {
                return true;
            }

            if(node.TreeNodeValue>maxNumber || node.TreeNodeValue<= minNumber)
            {
                return false;
            }

            if (IsBinarySearchTree(node.LeftNode, minNumber, node.TreeNodeValue) == false)
            {
                return false;
            }

            if (IsBinarySearchTree(node.RightNode, node.TreeNodeValue, maxNumber) == false)
            {
                return false;
            }
            
            return true;
        }
    }
}
