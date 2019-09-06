using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class PermutationChecker
    {
        public static string sort(string s)
        {
            char[] charArray = s.ToCharArray();
             Array.Sort(charArray);
            return charArray.ToString();
        }

        public static Boolean IsPermutatinEqual(string s, string t)
        {
            s = sort(s);
            t = sort(t);
            if (s.Equals(t))
            {
                return true;
            }
            return false;
        }
    }
}
