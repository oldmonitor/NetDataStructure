using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MathProblems
{
    public class ReverseInteger
    {
        /// <summary>
        /// 123 return 321. -123 return -321
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int GetReversedInteger(int i)
        {
            int newInt = 0;
            int index = 0;
            while(i != 0)
            {
                int digit = i % 10;
                newInt = newInt * 10 + digit;
                i = i / 10;
                index++;
            }
            return newInt;
        }
    }
}
