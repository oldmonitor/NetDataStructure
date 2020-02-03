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
            

        }

        /*
        public int minimumDays(int rows, int columns, int[,] grid)
        {
            int[,] daysGrid = new int[rows, columns];
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns; j++)
                {
                    
                }
            }
        }*/


        public static List<string> popularNToys(int numToys,
                                 int topToys,
                                 List<string> toys,
                                 int numQuotes, 
                                 List<string> quotes)
        {
            List<string> result = new List<string>();
            Dictionary<string, int> countDictionary = new Dictionary<string, int>();
            
            foreach (string t in toys)
            {
                countDictionary.Add(t, 0);
            }
            
            foreach(string s in quotes)
            {
                foreach (var toyName in toys)
                {
                    if(s.Contains(toyName))
                    {
                        countDictionary[toyName]++;
                    }
                }
            }

            result = countDictionary.ToList().OrderByDescending(x => x.Value).Where(x=>x.Value>0).Take(topToys).Select(x => x.Key).ToList();

            return result;
        }




    }
}
