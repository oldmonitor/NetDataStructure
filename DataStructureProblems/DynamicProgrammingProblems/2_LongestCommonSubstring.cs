using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class LongestCommonSubstring
    {
        /// <summary>
        /// create a grid. If s1[i] == s2[j], then cell value = cell[i-1, j-1] + 1. else set to 0. 
        /// See the png file 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public string GetLongestCommonSubstring(string s1, string s2)
        {
            if(s1.Length == 0 || s2.Length == 0)
            {
                return "";
            }

            int[,] counterChecker = new int[s1.Length, s2.Length];
            int intMaxCounter = 0;
            int intMaxILocation = 0;
            int intMaxJLocation = 0;

            for(int i =0;i<s1.Length; i++)
            {
                for(int j=0; j<s2.Length; j++)
                {
                    if(s1[i] == s2[j])
                    {
                        if(i==0 || j== 0 )
                        {
                            counterChecker[i, j] = 1;
                        }
                        else
                        {
                            counterChecker[i, j] = counterChecker[i - 1, j - 1] + 1;
                        }
                    }
                    else
                    {
                        counterChecker[i, j] = 0;
                    }

                    if(counterChecker[i, j] > intMaxCounter)
                    {
                        intMaxCounter = counterChecker[i, j];
                        intMaxILocation = i;
                        intMaxJLocation = j;
                    }
                }
            }

            if (intMaxCounter == 0)
            {
                return "";
            }
            else
            {
                return s1.Substring(intMaxILocation - intMaxCounter + 1, intMaxCounter);
            }
        }
    }
}
