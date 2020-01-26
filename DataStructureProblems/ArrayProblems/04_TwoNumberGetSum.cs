using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    /// <summary>
    /// given an array of integers, return indices that adds to given sum
    /// </summary>
    public class TwoNumToGetSum
    {
        public int[] GetIndicesForSumValue(int[] intArray, int sum)
        {
            int[] result = new int[2];
            for(int i=0;i< intArray.Length; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if(intArray[i] + intArray[j] == sum)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}
