using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems
{
    public class GetTreeHeight
    {
        public static int GetHeight(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }

            return  Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;
        }

    }
}
