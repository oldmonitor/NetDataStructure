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
    public class LinkedListNodeFinderTest
    {
        [TestMethod]
        public void FindingKthElementTest()
        {

            LinkedList<NodeDataElement> mylist = new LinkedList<NodeDataElement>();

            mylist.AddLast(new NodeDataElement { Key = 1, Value = "one" });
            mylist.AddLast(new NodeDataElement { Key = 2, Value = "two" });
            mylist.AddLast(new NodeDataElement { Key = 3, Value = "three" });
            mylist.AddLast(new NodeDataElement { Key = 4, Value = "four" });

            LinkedListNode<NodeDataElement> kthElement = NodeFinder.GetGetKthNodeFromLast(mylist.First, 2);
            Assert.AreEqual("three", kthElement.Value.Value);

        }
    }
}
