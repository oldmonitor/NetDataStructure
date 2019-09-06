using System.Collections.Generic;

namespace DataStructureProblems.ArrayProblems
{
    public class UniqueCharacterChecker
    {
        public static bool HasAllUniqueChars(string s)
        {
            var charSet = new HashSet<char>();
            foreach (char c in s)
            {
                if (!charSet.Contains(c))
                    charSet.Add(c);
                else
                    return false;
            }

            return true;
        }

        public static bool HasAllUniqueChars2(string s)
        {
            if (s.Length > 128) return false;

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
