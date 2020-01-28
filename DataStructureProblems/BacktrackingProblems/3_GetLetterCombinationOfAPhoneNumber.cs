using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BacktrackingProblems
{
    public class GetLetterCombinationOfAPhoneNumber
    {
        private Dictionary<int, string> InitializeLetterMapping()
        {
            Dictionary<int, string> mapping = new Dictionary<int, string>();
            mapping.Add(2, "abc");
            mapping.Add(3, "def");
            mapping.Add(4, "ghi");
            mapping.Add(5, "jkl");
            mapping.Add(6, "mno");
            mapping.Add(7, "pqrs");
            mapping.Add(8, "tuv");
            mapping.Add(9, "wxyz");
            return mapping;
        }

        public List<string> HandleGetLetterCombinationOfAPhoneNumber(string phoneNumber)
        {
            Dictionary<int, string> mapping = this.InitializeLetterMapping();
            List<string> result = new List<string>();
            BacktrackingGetLetterCombo(mapping, result, new StringBuilder(), phoneNumber);
            return result;
        }

        private void BacktrackingGetLetterCombo(Dictionary<int, string> mapping, List<string> result, StringBuilder stResult, string phoneNumber)
        {
            if(phoneNumber == null || phoneNumber.Length == 0)
            {                
                if (stResult != null && stResult.Length > 0)
                    result.Add(stResult.ToString());

                return;
            }

            char c = phoneNumber[0];
            int intChar;
            if (int.TryParse(c.ToString(), out intChar) == false)
            {
                throw new Exception("invalid character in phone");
            }
            string mappedChars = mapping[intChar];
            foreach(char mc in mappedChars)
            {
                stResult.Append(mc);
                BacktrackingGetLetterCombo(mapping, result, stResult, phoneNumber.Substring(1));
                stResult.Remove(stResult.Length - 1, 1);
            }
        }

    }
}
