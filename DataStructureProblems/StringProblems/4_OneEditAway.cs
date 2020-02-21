using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class OneEditAway
    {
        public bool HandleOneEditAway(string s1, string s2)
        {
            string shortString;
            string longString;

            if (s1.Length < s2.Length)
            {
                shortString = s1;
                longString = s2;
            }
            else
            {
                shortString = s2;
                longString = s1;
            }

            if ((longString.Length - shortString.Length) > 1)
            {
                return false;
            }

            for (int i = 0; i < shortString.Length - 1; i++)
            {
                if (shortString[i] != longString[i])
                {
                    if (shortString.Length == longString.Length)
                    {
                        return shortString.Substring(i + 1) == longString.Substring(i + 1);
                    }
                    else
                    {
                        return shortString == longString.Substring(i + 1);
                    }
                }
            }

            return true;
        }

    }
}
