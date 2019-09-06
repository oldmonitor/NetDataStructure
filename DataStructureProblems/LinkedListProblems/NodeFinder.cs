using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class NodeFinder
    {

        public static LinkedListNode<NodeDataElement> GetGetKthNodeFromLast
            (LinkedListNode<NodeDataElement> currentNode, int k)
        {
            int levelCounter = 0;
            return HandleGetKthNodeFromLast(currentNode, k, ref levelCounter);
        }

        private static LinkedListNode<NodeDataElement> HandleGetKthNodeFromLast
            (LinkedListNode<NodeDataElement> currentNode, int k, ref int levelCounter)
        {
            //return null when reaches bottom
            if(currentNode == null)
            {
                return null;
            }

            LinkedListNode<NodeDataElement> nextNode = HandleGetKthNodeFromLast(currentNode.Next, k, ref levelCounter);
            
            //track from the bottom-up
            levelCounter = levelCounter + 1;
            
            if(levelCounter == k)
            {
                return currentNode;
            }

            return nextNode;
        }

        
    }
}
