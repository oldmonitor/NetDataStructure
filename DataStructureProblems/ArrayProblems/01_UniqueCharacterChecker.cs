using System.Collections.Generic;

namespace DataStructureProblems.ArrayProblems
{
    /// <summary>
    /// Implement an algorithm to determine if a string has all unique characters.
    /// </summary>
    public class UniqueCharacterChecker
    {
        /// <summary>
        /// space: 1
        /// time: n^2
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HasAllUniqueChars(string s)
        {
            //use hashset
            var charSet = new HashSet<char>();
            foreach (char c in s)
            {
                // if hashset already contain character, return false
                if (!charSet.Contains(c))
                    charSet.Add(c);
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// space: 128
        /// time: n
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HasAllUniqueChars2(string s)
        {
            if (s.Length > 128) return false;

            //use fixed size array
            var booleanArray = new bool[128];
            for(int i =0; i < s.Length; i++)
            {
                int charInt = (int)s[i];
                if(booleanArray[charInt] == true)
                {
                    return false;
                }
                else
                {
                    booleanArray[charInt] = true;
                }
            }
            
            return true;
        }
    }
}
