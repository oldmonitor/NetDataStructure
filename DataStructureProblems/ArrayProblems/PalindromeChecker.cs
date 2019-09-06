using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string s)
        {
            char[] characters = s.Replace(" ", "").ToArray();
            for(int i =0; i<=characters.Count()/2; i++)
            {
                if(characters[i] != characters[characters.Count()-i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
