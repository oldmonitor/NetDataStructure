using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.HashtableProblems
{
    public class FindFirstUniqueCharacterInString
    {
        public char? GetFirstUniqueCharacterInString(string input)
        {
            if(input == null || input.Length == 0)
            {
                return null;
            }

            var characterCounter = new Dictionary<char, int>();
            var characterPosition = new Dictionary<char, int>();

            for(int i = 0;i<input.Length; i++)
            {
                char c = input[i];
                if(characterCounter.ContainsKey(c) == false)
                {
                    characterCounter.Add(c, 1);
                }
                else
                {
                    characterCounter[c]++;
                }

                if (characterPosition.ContainsKey(c) == false)
                {
                    characterPosition.Add(c, 1);
                }
            }

            char? firstUniqueCharacter = null;
            int index = int.MaxValue;
            foreach(char c in characterCounter.Keys)
            {
                if(characterCounter[c] == 1)
                {
                    if(characterPosition[c] < index)
                    {
                        index = characterPosition[c];
                        firstUniqueCharacter = c;
                    }
                }
            }

            return firstUniqueCharacter;
        }
    }
}
