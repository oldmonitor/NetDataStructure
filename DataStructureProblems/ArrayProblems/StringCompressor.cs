using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.ArrayProblems
{
    public class StringCompressor
    {
        public static string CompressString(string str)
        {
            StringBuilder compressed = new StringBuilder();
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                
                /* If next character is different than current, append this char to result.*/
                if (i + 1 >= str.Length || str[i] != str[i + 1]) {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            return compressed.Length < str.Length? compressed.ToString() : str;
        }
    }
}
