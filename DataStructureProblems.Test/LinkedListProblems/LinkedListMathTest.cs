using DataStructureProblems.LinkedListProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.Test.LinkedListProblems
{
    [TestClass]
    public class LinkedListMathTest
    {
        [TestMethod]
        public void SumTwoLinkedListSameLengthTest()
        {
            SimpleLinkedListNode list1 = new SimpleLinkedListNode();
            list1.value = 6;

            SimpleLinkedListNode list2 = new SimpleLinkedListNode();
            list2.value = 7;

            SimpleLinkedListNode list3 = LinkedListMath.AddSum(list1, list2, 0);

            Assert.AreEqual(3, list3.value);
            Assert.AreEqual(1, list3.Next.value);
        }

        [TestMethod]
        public void SumTwoLinkedListDifferentLengthTest()
        {
            SimpleLinkedListNode list1Head = new SimpleLinkedListNode();
            list1Head.value = 7;

            SimpleLinkedListNode list2node2 = new SimpleLinkedListNode();
            list2node2.value = 2;

            list1Head.Next = list2node2;
            list2node2.Previous = list1Head;

            SimpleLinkedListNode list2node3 = new SimpleLinkedListNode();
            list2node3.value = 1;

            list2node2.Next = list2node3;
            list2node3.Previous = list2node2;

            SimpleLinkedListNode list2Head = new SimpleLinkedListNode();
            list2Head.value = 7;

            SimpleLinkedListNode list3Head = LinkedListMath.AddSum(list1Head, list2Head, 0);

            Assert.AreEqual(4, list3Head.value);
            Assert.AreEqual(3, list3Head.Next.value);
            Assert.AreEqual(1, list3Head.Next.Next.value);
        }
    }
}
