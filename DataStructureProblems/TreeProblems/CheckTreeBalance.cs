using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class CheckTreeBalance
    {
        /// <summary>
        /// Implement a function to check if a binary tree is balanced.For the purposes of
        /// this question, a balanced tree is defined to be a tree such that the heights of the two subtrees of any
        /// node never differ by more than one.
        /// 
        /// note: need to check at each level
        /// </summary>
        public static bool IsTreeBalanceInefficient(TreeNode node)
        {
            //one way is recurively check height at each level 
            int rightHeight = GetTreeHeight.GetHeight(node.LeftNode);
            int leftHeight = GetTreeHeight.GetHeight(node.RightNode);

            if(Math.Abs(rightHeight - leftHeight) > 1)
            {
                return false;
            }
            else
            {
                if(IsTreeBalanceInefficient(node.LeftNode) == false)
                {
                    return false;
                }

                if (IsTreeBalanceInefficient(node.RightNode) == false)
                {
                    return false;
                }

                return true;
            }
        }

       
    }
}
