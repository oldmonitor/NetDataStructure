using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    /// <summary>
    /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
    /// Note: You may not slant the container and n is at least 2.
    /// Example:
    /// Input: [1,8,6,2,5,4,8,3,7]
    /// Output: 49
    /// </summary>
    public class ContainerWithMostWater
    {
        /*
         * The solution is keep removeing one data point at a time to find the max size
         * The idea is either to remove the left most or the right most.
         * The one to remove is the one with lower value. Then move the index depending on which one was removed.
         * Remember: lower vaue is the one used in the multiplication
         * */
        public int GetContainerWithMostWater(int[] dataPoints)
        {
            if (dataPoints.Length <= 1)
            {
                return 0;
            }

            int leftIndex = 0;
            int rightIndex = dataPoints.Length - 1;
            int maxArea = 0;

            while (leftIndex != rightIndex)
            {
                //shorter line
                int shorterLine = Math.Min(dataPoints[leftIndex], dataPoints[rightIndex]);
                int currentArea = shorterLine * (rightIndex - leftIndex);
                maxArea = Math.Max(maxArea, currentArea);

                //maxArea = Math.Max(max)
                // left line is higher, remove the right index
                if (dataPoints[leftIndex] > dataPoints[rightIndex])
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                }
            }

            return maxArea;
        }

    }

}
