using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class HackerRankSimple
    {
        static int simpleArraySum(int[] ar)
        {
            int sumResult = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sumResult += ar[i];
            }
            return sumResult;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/compare-the-triplets/problem?h_r=next-challenge&h_v=zen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);

            for(int i=0;i<a.Count(); i++)
            {
                if(a[i]>b[i])
                {
                    result[0] += 1;
                }

                if (a[i] < b[i])
                {
                    result[1] += 1;
                }
            }

            return result;
        }
    }
}
