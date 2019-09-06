using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class NumberStringFormatter
    {
        public static string GetNumericStringFormat(int number)
        {
            StringBuilder sbResult = new StringBuilder();
            string numberString = number.ToString();
            
            for(int i=numberString.Length-1;i>=0;i--)
            {
                if(i%3==0)
                {
                    sbResult.Append(",");
                }
                sbResult.Append(numberString[i]);
            }
            return sbResult.ToString().Reverse().ToString();
        }

        /// <summary>
        /// number in binary number format, use one to indicate comma
        /// Example: 100010001000
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberFormat"></param>
        /// <returns></returns>
        public static string GetCustomNumericStringFormat(int number, int numberFormat)
        {
            StringBuilder sbResult = new StringBuilder();
            string numberString = number.ToString();
            int counter = 0;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                int intCheck = (int)Math.Pow(2, counter);
                if ((intCheck & numberFormat) == intCheck)
                {
                    sbResult.Append(",");
                    counter++;
                }

                sbResult.Append(numberString[i]);
                counter++;
            }

            string stringReturn = new string(sbResult.ToString().Reverse().ToArray());
            return stringReturn;
        }
    }
}
