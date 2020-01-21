using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StringProblems
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] stringArray)
        {
            int minLength = 0;
            
            if(stringArray.Length == 0)
            {
                return "";
            }
            minLength = this.FindMinLength(stringArray);

            StringBuilder commonPrefix = new StringBuilder();
            for(int i = 0;i<minLength;i++)
            {
                char c = stringArray[0][i];
                //string substring = stringArray[0].Substring(0, i);
                bool isCommonPrefix = true;
                for(int j = 1; j< stringArray.Length; j++)
                {
                    if(stringArray[j][i] != c)
                    {
                        isCommonPrefix = false;
                        break;
                    }
                }

                if(isCommonPrefix == false)
                {
                    break;
                }
                else
                {
                    commonPrefix.Append(c);
                }
            }
            return commonPrefix.ToString();
        }

        private int FindMinLength(string[] stringArray)
        {
            if (stringArray.Length == 0)
            {
                return 0;
            }

            int minLength = stringArray[0].Length;
            for(int i= 1;i<stringArray.Length;i++)
            {
                if(stringArray[i].Length < minLength)
                {
                    minLength = stringArray[i].Length;
                }
            }
            return minLength;
        }
    }
}
