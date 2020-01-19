using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class SimpleLinkedListNode
    {
        public SimpleLinkedListNode() { }
        public SimpleLinkedListNode(int value)
        {
            this.value = value;

        }
        public int value { get; set; }

        public SimpleLinkedListNode Previous;
        public void SetPrevious(SimpleLinkedListNode previousNode)
        {
            this.Previous = previousNode;
            previousNode.Next = this;
        }

        public SimpleLinkedListNode Next;
        public void SetNext(SimpleLinkedListNode nextNode)
        {
            this.Next = nextNode;
            nextNode.Previous = this;
        }


    }
}
