using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class StringRotationChecker
    {
        /// <summary>
        /// Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one
        /// call to IsRotation(e.g., "waterbottle" is a rotation of "erbottlewat").
        /// 
        /// quick way is duplicate second string then check if first string is substring of the duplicated second string
        /// example:
        /// check if waterbottle is substring of erbottlewaterbottlewat
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsRotation(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(t);
            sb.Append(t);

            return sb.ToString().Contains(s);
        }
    }
}
