using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.DecisionTreeProblems
{
    public class ClimbStairs
    {
        /*
            You are climbing a stair case. It takes n steps to reach to the top.
            Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        */

        /// <summary>
        /// solutin is finding number of path that can goes down the decision tree
        /// </summary>
        /// <param name="numberOfStep"></param>
        /// <returns></returns>
        public int FindNumberOfWayOfClimbingStairs(int numberOfStep)
        {
            return GetNumberStep(numberOfStep);
        }

        private int GetNumberStep(int stepRemaining)
        {
            if(stepRemaining == 0)
            {
                return 1;
            }

            // can't take more steps than stepRemaining
            if(stepRemaining < 0)
            {
                return 0;
            }

            // subtree of taking one step plus subtree of taking two steps
            return GetNumberStep(stepRemaining - 1) + GetNumberStep(stepRemaining - 2);
        }
    }
}
