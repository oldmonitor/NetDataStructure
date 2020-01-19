using System;
using DataStructureProblems.LinkedListProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.LinkedListProblems
{
    [TestClass]
    public class MergeSortedListTest
    {
        [TestMethod]
        public void TestMergeTwoSortedListWithSameNumberOfNode()
        {
            SimpleLinkedListNode listA = new SimpleLinkedListNode(1);
            SimpleLinkedListNode listA2 = new SimpleLinkedListNode(4);
            SimpleLinkedListNode listA3 = new SimpleLinkedListNode(5);
            listA.SetNext(listA2);
            listA2.SetNext(listA3);

            SimpleLinkedListNode listB = new SimpleLinkedListNode(2);
            SimpleLinkedListNode listB2 = new SimpleLinkedListNode(3);
            SimpleLinkedListNode listB3 = new SimpleLinkedListNode(6);
            listB.SetNext(listB2);
            listB2.SetNext(listB3);


            MergeSortedList mergeSortedList = new MergeSortedList();
            SimpleLinkedListNode listC = mergeSortedList.GetMergeSortedList(listA, listB);

            Assert.AreEqual(1, listC.value);
            listC = listC.Next;
            Assert.AreEqual(2, listC.value);
            listC = listC.Next;
            Assert.AreEqual(3, listC.value);
            listC = listC.Next;
            Assert.AreEqual(4, listC.value);
            listC = listC.Next;
            Assert.AreEqual(5, listC.value);
            listC = listC.Next;
            Assert.AreEqual(6, listC.value);

        }


        [TestMethod]
        public void TestMergeTwoSortedListWithDifferentNumberOfNode()
        {
            SimpleLinkedListNode listA = new SimpleLinkedListNode(1);
            SimpleLinkedListNode listA2 = new SimpleLinkedListNode(4);
            SimpleLinkedListNode listA3 = new SimpleLinkedListNode(5);
            SimpleLinkedListNode listA4 = new SimpleLinkedListNode(7);
            listA.SetNext(listA2);
            listA2.SetNext(listA3);
            listA3.SetNext(listA4);

            SimpleLinkedListNode listB = new SimpleLinkedListNode(2);
            SimpleLinkedListNode listB2 = new SimpleLinkedListNode(3);
            SimpleLinkedListNode listB3 = new SimpleLinkedListNode(6);
            listB.SetNext(listB2);
            listB2.SetNext(listB3);


            MergeSortedList mergeSortedList = new MergeSortedList();
            SimpleLinkedListNode listC = mergeSortedList.GetMergeSortedList(listA, listB);

            Assert.AreEqual(1, listC.value);
            listC = listC.Next;
            Assert.AreEqual(2, listC.value);
            listC = listC.Next;
            Assert.AreEqual(3, listC.value);
            listC = listC.Next;
            Assert.AreEqual(4, listC.value);
            listC = listC.Next;
            Assert.AreEqual(5, listC.value);
            listC = listC.Next;
            Assert.AreEqual(6, listC.value);
            listC = listC.Next;
            Assert.AreEqual(7, listC.value);

        }
    }
}
