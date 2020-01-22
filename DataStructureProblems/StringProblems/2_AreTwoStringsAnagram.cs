using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class AreTwoStringsAnagram
    {
        public bool IsAnagram(string s1, string s2)
        {
            int[] countKeeper = new int[128];
            for (int i = 0; i < s1.Length; i++)
            {
                countKeeper[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                countKeeper[s2[i]]--;
                if (countKeeper[s2[i]] < 0)
                {
                    return false;
                }
            }

            for (int i = 0; i < 128; i++)
            {
                if (countKeeper[i] > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
