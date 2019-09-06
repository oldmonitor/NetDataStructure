using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class MinHeightTree
    {
        /// <summary>
        /// Given a sorted (increasing order) array with unique integer elements, write an
        /// algorithm to create a binary search tree with minimal height.
        /// </summary>
        /// <returns></returns>
        public TreeNode GetMinBST(int[] sortedArray)
        {
            return this.GetMinBST(sortedArray, 0, sortedArray.Length - 1);
        }

        public TreeNode GetMinBST(int[] sortedArray, int beginIndex, int endingIndx)
        {
            if(sortedArray.Length == 0 || endingIndx < beginIndex)
            {
                return null;
            }

            TreeNode treeNode = new TreeNode();
            if (beginIndex == endingIndx)
            {   
                treeNode.TreeNodeValue = sortedArray[beginIndex];
                return treeNode;
            }

            int middelIndex = (endingIndx + beginIndex) / 2;
            treeNode.TreeNodeValue = sortedArray[middelIndex];

            //left side of the tree
            TreeNode leftNode = this.GetMinBST(sortedArray, beginIndex, middelIndex - 1);

            //right side of the tree
            TreeNode rightNode = this.GetMinBST(sortedArray, middelIndex + 1, endingIndx);

            treeNode.LeftNode = leftNode;
            treeNode.RightNode = rightNode;

            return treeNode;
        }
    }
}
