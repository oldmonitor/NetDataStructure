using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StackProblems
{
    /// <summary>
    /// the top of the stack has element with min value
    /// </summary>
    public class MinStack
    {
        private Stack<StackElement> _minStack;
        public MinStack()
        {
            _minStack = new Stack<StackElement>();
        }
        
        public int? GetMinValue()
        {
            StackElement se = _minStack.Peek();
            if(se != null)
            {
                return se.MinStackValue;
            }
            else
            {
                return null; 
            }
        }

        public StackElement Pop()
        {
            return _minStack.Pop();
        }

        public void Push(StackElement stackElement)
        {
            int? minValue = this.GetMinValue();
            if(minValue != null)
            {
                if(stackElement.Value<minValue.Value)
                {
                    stackElement.MinStackValue = stackElement.Value;
                }
                else
                {
                    stackElement.MinStackValue = minValue.Value;
                }
            }
            else
            {
                stackElement.MinStackValue = stackElement.Value;
            }

            this._minStack.Push(stackElement);
        }
    }

    public class StackElement
    {
        public int Value { get; set; }

        //track min value of stack
        public int MinStackValue { get; set; }
    }

}
