using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    /// <summary>
    /// remove characters that are duplicated more than 2 times.
    ///  111223 => 11223
    /// </summary>
    public class RemoveMoreThanTwoDuplicateInSortedArray
    {
        public int[] HandleRemoveMoreThanTwoDuplicateInSortedArray(int[] input)
        {
            // if length is less than 2, just return
            if(input == null || input.Length <= 2)
            {
                return input;
            }

            int i = 2;
            int j;

            for(j=2; j<input.Length; j++)
            {
                if(input[j] != input[i-2]) //max 2 duplicate, third characher should be different
                {
                    input[i] = input[j];
                    i++;
                }
            }

            Array.Resize(ref input, i);
            return input;
        }


    }
}
