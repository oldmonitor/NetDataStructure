using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class FindLongestSubstringCount
    {
        /// <summary>
        /// return the longest substring with no repeating character. 
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int HandleFindLongestSubstringCount(string str)
        {
            int i = 0; // beginning of sliding window
            int j = 0; // ending index of sliding window
            int[] counter = new int[128]; //counter for character in the sliding window
            int maxLength = 0;
            for (j=0;j<str.Length; j++)
            {
                //increase count
                counter[str[j]]++;
                while(counter[str[j]] > 1)
                {
                    counter[str[i]]--;
                    i++;
                }
                maxLength = Math.Max(maxLength, j-i+1);
            }

            return maxLength;
        }
    }
}
