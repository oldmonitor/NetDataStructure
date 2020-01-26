using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    /// <summary>
    /// Given two strings, write a method to decide if one is a permutation of the other.
    /// </summary>
    public class PermutationChecker
    {
        public static string sort(string s)
        {
            char[] charArray = s.ToCharArray();
             Array.Sort(charArray);
            return charArray.ToString();
        }

        /// <summary>
        /// sort the array, then compare
        /// time: nlogn
        /// space: n
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsPermutatinEqual(string s, string t)
        {
            s = sort(s);
            t = sort(t);
            if (s.Equals(t))
            {
                return true;
            }
            return false;
        }

        public static bool IsPermutatinEqual2(string s, string t)
        {
            int[] intArray = new int[128];
            foreach(char c in s)
            {
                intArray[c]++;
            }

            foreach(char c in t)
            {
                intArray[c]--;
                if(intArray[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
