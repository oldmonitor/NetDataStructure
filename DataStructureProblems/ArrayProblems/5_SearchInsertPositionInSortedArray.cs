using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class SearchInsertPositionInSortedArray
    {
        public int HandleSearchInsertPositionInSortedArray(int[] dataArray, int valueToInsert)
        {
            if(dataArray.Length == 0)
            {
                return 0;
            }

            int leftIndex = 0;
            int rightIndex = dataArray.Length - 1;
            while(leftIndex <= rightIndex)
            {
                int middleIndex = (rightIndex - leftIndex) / 2 + leftIndex;
                if(dataArray[middleIndex] == valueToInsert)
                {
                    return middleIndex;
                }

                if(valueToInsert < dataArray[middleIndex])
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return leftIndex;
        }

    }
}
