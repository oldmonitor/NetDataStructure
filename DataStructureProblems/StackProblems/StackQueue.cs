using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StackProblems
{
    /// <summary>
    /// implement queu using two stacks. Queue is first in first out
    /// </summary>
    public class StackQueue
    {
        Stack<StackQueueElement> oldOnStopStack;
        Stack<StackQueueElement> newOnTopStack;

        public StackQueue()
        {
            oldOnStopStack = new Stack<StackQueueElement>();
            newOnTopStack = new Stack<StackQueueElement>();
        }

        public void Enqueue(StackQueueElement element)
        {
            //if "old" stack has the items, shift items to "new" stack
            if(newOnTopStack.Any() == false)
            {
                ShiftStack();
            }

            newOnTopStack.Push(element);
        }

        public StackQueueElement Dequeue()
        {
            if(oldOnStopStack.Any()==false)
            {
                ShiftStack();
            }

            return oldOnStopStack.Pop();
        }

        public void ShiftStack()
        {
            //if all element in the "new" stack, move elements from "new" stack to "old" stack
            if(newOnTopStack.Any())
            {
                while(newOnTopStack.Any())
                {
                    oldOnStopStack.Push(newOnTopStack.Pop());
                }
            }
            else
            {
                //if all element in "old" stack, move elements from "old" stack to "new" stack
                while(oldOnStopStack.Any())
                {
                    newOnTopStack.Push(oldOnStopStack.Pop());
                }
            }
        }

        public int Count()
        {
            return this.newOnTopStack.Count() + this.oldOnStopStack.Count();
        }

    }

    public class StackQueueElement
    {
        public int ElementValue { get; set; }
    }
}
