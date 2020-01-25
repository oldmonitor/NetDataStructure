using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class RemoveDuplicateInSortedArray
    {
        public int[] HandleRemoveDuplicateInSortedArray(int[] input)
        {
            if(input == null || input.Length <= 1)
            {
                return input;
            }

            int i = 0; // only move when there is distinct character
            int j;
            for (j = 1; j< input.Length; j++)
            {
                // if new encounter character is different from the last distinct character,
                // set the last distinct character and move i
                if(input[i] != input[j])
                {
                    i++;
                    input[i] = input[j];
                }
            }

            // cut out anything after distinct character count
            Array.Resize(ref input, i + 1);
            return input;
        }
    }
}
