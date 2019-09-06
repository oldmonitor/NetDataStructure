using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class LinkedListMath
    {
        /// <summary>
        /// You have two numbers represented by a linked list, where each node contains a single
        /// digit.The digits are stored in reverse order, such that the 1 's digit is at the head of the list.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static SimpleLinkedListNode AddSum(SimpleLinkedListNode x, SimpleLinkedListNode y, int carry)
        {
            if (x == null && y == null && carry == 0)
                return null;

            int intSum = carry;
            intSum += x == null ? 0 : x.value;
            intSum += y == null ? 0 : y.value;

            SimpleLinkedListNode simpleLinkedListNode = new SimpleLinkedListNode();

            //(x + y + carry) /10
            int carryNextNode = intSum / 10;
            int nodeValue = intSum % 10;

            //(x + y + carry) % 10
            simpleLinkedListNode.value = nodeValue;

            SimpleLinkedListNode nextNode = AddSum(x == null ? null : x.Next, y == null ? null : y.Next, carryNextNode);
            if(nextNode != null)
            {
                simpleLinkedListNode.Next = nextNode;
                nextNode.Previous = simpleLinkedListNode;
            }
            
            //if node value is 0 and there is no next digit
            if(nodeValue == 0 && nextNode == null)
            {
                return null;
            }

            return simpleLinkedListNode;
        }

    }
}
