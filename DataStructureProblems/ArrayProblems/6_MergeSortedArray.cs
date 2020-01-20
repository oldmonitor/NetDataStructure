using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class MergeSortedArray
    {
        /// <summary>
        /// user third array to store the final data
        /// </summary>
        /// <param name="sortedArr1"></param>
        /// <param name="sortedArr2"></param>
        /// <returns></returns>
        public int[] MergeTwoSortedArray(int[] sortedArr1, int[] sortedArr2)
        {
            int[] sortedArray = new int[sortedArr1.Length + sortedArr2.Length];
            int index1 = 0;
            int index2 = 0;
            int mergeIndex = 0;
            while(index1 < sortedArr1.Length || index2 < sortedArr2.Length)
            {
                if(index1 == sortedArr1.Length)
                {
                    sortedArray[mergeIndex] = sortedArr2[index2];
                    index2++;
                    mergeIndex++;
                    continue;
                }

                if (index2 == sortedArr2.Length)
                {
                    sortedArray[mergeIndex] = sortedArr1[index1];
                    index1++;
                    mergeIndex++;
                    continue;
                }

                if(sortedArr1[index1] < sortedArr2[index2])
                {
                    sortedArray[mergeIndex] = sortedArr1[index1];
                    index1++;
                }
                else
                {
                    sortedArray[mergeIndex] = sortedArr2[index2];
                    index2++;
                }
                mergeIndex++;
            }

            return sortedArray;
        }

        /// <summary>
        /// merge 2 array and put final result in bArray.
        /// Loop from the end 
        /// </summary>
        /// <param name="bArray"></param>
        /// <param name="sArray"></param>
        public int[] MergeTwoSortedArraySame(int[] bArray, int[] sArray)
        {
            int finalSize = bArray.Length + sArray.Length;
            int bArrayIndex = bArray.Length - 1;
            int sArrayIndex = sArray.Length - 1;
            int mergeIndex = finalSize - 1;

            // increase size
            Array.Resize(ref bArray, finalSize);
            while(bArrayIndex >=0 || sArrayIndex >= 0)
            {
                //run out of item in bArray
                if (bArrayIndex < 0)
                {
                    bArray[mergeIndex] = sArray[sArrayIndex];
                    sArrayIndex--;
                    mergeIndex--;
                    continue;
                }

                //run out of item in sArray
                if (sArrayIndex <0)
                {
                    bArray[mergeIndex] = bArray[bArrayIndex];
                    bArrayIndex--;
                    mergeIndex--;
                    continue;
                }

                if (bArray[bArrayIndex] < sArray[sArrayIndex])
                {
                    bArray[mergeIndex] = sArray[sArrayIndex];
                    sArrayIndex--;
                }
                else
                {
                    bArray[mergeIndex] = bArray[bArrayIndex];
                    bArrayIndex--;
                }
                mergeIndex--;
            }
            return bArray;
        }
    }
}
