using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class BinarySearchTreeSucessor
    {
        /// <summary>
        /// Get successor of current node
        /// </summary>
        /// <param name="selectedNode"></param>
        /// <returns></returns>
        public TreeNode GetSuccessor(TreeNode selectedNode)
        {
            /*
             * if (n has right child)
             *  return the left most of right subtree
             * else
             *  while(n is right child)
             *      n = n.parent
             *  return n.parent
             * */

            if(selectedNode.RightNode != null)
            {
                return this.GetMostLeftChild(selectedNode.RightNode);
            }
            else
            {
                TreeNode currentNode = selectedNode;
                TreeNode parentNode = currentNode.Parent;
                while(parentNode != null && parentNode.RightNode != null && parentNode.RightNode == currentNode)
                {
                    currentNode = parentNode;
                    parentNode = currentNode.Parent;
                }

                return currentNode.Parent;
            }

        }

        private TreeNode GetMostLeftChild(TreeNode node)
        {
            if(node == null)
            {
                return null;
            }

            TreeNode currentNode = node;
            while(currentNode.LeftNode != null)
            {
                currentNode = currentNode.LeftNode;
            }
            return currentNode;

        }


    }
}
