using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class OneEditAwayChecker
    {
        /// <summary>
        /// check if string is one edit away
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsOneEditAway(string s, string t)
        {
            string shortString;
            string longString;
            if(s.Length>t.Length)
            {
                shortString = t;
                longString = s;
            }
            else
            {
                shortString = s;
                longString = t;
            }

            int shortStringIndex = 0;
            int longStringIndex = 0;
            bool diff = false;
            while(shortStringIndex < shortString.Length && longStringIndex < longString.Length)
            {
                if(shortString[shortStringIndex] != longString[longStringIndex])
                {
                    if(diff)
                    {
                        return false;
                    }
                    else
                    {
                        if(shortString.Length == longString.Length)
                        {
                            shortStringIndex++;
                        }
                        diff = true;
                    }
                }
                else
                {
                    shortStringIndex++;
                }

                longStringIndex++;
                
            }

            return false;
        }
    }
}
