using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StackProblems
{
    public class StackSorter
    {
        public static Stack<int> Sort(Stack<int> stack)
        {
            Stack<int> resultStack = new Stack<int>();
            while(stack.Any())
            {
                int temp = stack.Pop();
                if(resultStack.Any() == false)
                {
                    resultStack.Push(temp);
                    continue;
                }

                while(resultStack.Any() && temp>resultStack.Peek())
                {
                    //temp value needs push to buttom
                    stack.Push(resultStack.Pop());
                }

                resultStack.Push(temp);
            }

            return resultStack;
        }

        
    }
}
