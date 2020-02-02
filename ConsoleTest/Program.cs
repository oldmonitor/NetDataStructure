using DataStructureProblems.ArrayProblems;
using DataStructureProblems.StringProblems;
using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello World");


        }

        static bool IsAnagram(string s1, string s2)
        {
            int[] countKeeper = new int[128];
            for (int i = 0; i < s1.Length; i++)
            {
                countKeeper[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                countKeeper[s1[i]]--;
                if (countKeeper[s1[i]] < 0)
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
