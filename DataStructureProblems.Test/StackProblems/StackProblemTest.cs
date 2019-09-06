using System;
using DataStructureProblems.StackProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.StackProblems
{
    [TestClass]
    public class StackProblemTest
    {
        [TestMethod]
        public void StackQueueAddedItemCountTest()
        {
            StackQueue sq = new StackQueue();
            sq.Enqueue(new StackQueueElement() { ElementValue = 1 });
            sq.Enqueue(new StackQueueElement() { ElementValue = 2 });
            sq.Enqueue(new StackQueueElement() { ElementValue = 3 });

            Assert.AreEqual(3, sq.Count());

        }

        [TestMethod]
        public void StackQueueDequeuTest()
        {
            StackQueue sq = new StackQueue();
            sq.Enqueue(new StackQueueElement() { ElementValue = 1 });
            sq.Enqueue(new StackQueueElement() { ElementValue = 2 });
            sq.Enqueue(new StackQueueElement() { ElementValue = 3 });

            StackQueueElement ele = sq.Dequeue();
            Assert.AreEqual(1, ele.ElementValue);

            StackQueueElement ele2 = sq.Dequeue();
            Assert.AreEqual(2, ele2.ElementValue);
        }



    }
}
