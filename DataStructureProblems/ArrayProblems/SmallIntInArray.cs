using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class SmallIntInArray
    {
        public int solution(int[] arrayInt)
        {
            Array.Sort(arrayInt);
            int intGap = 1;
            foreach(int i in arrayInt)
            {
                if(i<= 0)
                {
                    continue;
                }

                if(i==intGap)
                {
                    intGap++;
                }
            }
            return intGap;
        }
    }
}
