using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class RemoveValueFromArray
    {
        public int[] HandleRemoveValueFromArray(int[] input, int valueToRemove)
        {
            if(input == null || input.Length == 0)
            {
                return input;
            }

            int i = 0; // index number from left
            int j = input.Length - 1; // index number from right. 
            
            while(i<= j)
            {
                if(input[i] == valueToRemove)
                {
                    input[i] = input[j]; //take the right most valid character 
                    j--; // move the right index
                }
                else
                {
                    i++; // move the left index
                }
            }

            Array.Resize(ref input, j + 1);
            return input;
        }
    }
}
