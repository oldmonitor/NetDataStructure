using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class MergeSortedList
    {
        public SimpleLinkedListNode GetMergeSortedList(SimpleLinkedListNode listA, SimpleLinkedListNode listB)
        {
            if(listA == null)
            {
                return listB;
            }

            if(listB == null)
            {
                return listA;
            }

            if(listA.value < listB.value)
            {
                listA.Next = GetMergeSortedList(listA.Next, listB);
                return listA;
            }
            else
            {
                listB.Next = GetMergeSortedList(listB.Next, listA);
                return listB;
            }
        }
    }
}
