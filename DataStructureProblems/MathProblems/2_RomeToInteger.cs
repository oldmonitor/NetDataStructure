using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MathProblems
{
    public class RomanToInteger
    {
        public int ConvertRomanToInteger(string roman)
        {
            int intResult = 0;
            int symbolValue =0;
            int lastSymbolValue = 0;
            for(int i=roman.Length - 1; i>=0; i--)
            {
                char letter = roman[i];
                symbolValue = this.ConvertRomanSymbolToInteger(letter);
                if(
                    (symbolValue == 1 && lastSymbolValue == 5) ||
                    (symbolValue == 1 && lastSymbolValue == 10) ||
                    (symbolValue == 10 && lastSymbolValue == 50) ||
                    (symbolValue == 10 && lastSymbolValue == 100) ||
                    (symbolValue == 100 && lastSymbolValue == 500) ||
                    (symbolValue == 100 && lastSymbolValue == 1000)
                )
                {
                    intResult = intResult - symbolValue *2;
                }

                intResult = intResult + symbolValue;
                lastSymbolValue = symbolValue;
            }

            return intResult;
        }

        public int ConvertRomanSymbolToInteger(char romanChar)
        {
            int intValue = 0;
            switch(romanChar)
            {
                case 'I':
                    intValue = 1;
                    break;
                case 'V':
                    intValue = 5;
                    break;
                case 'X':
                    intValue = 10;
                    break;
                case 'L':
                    intValue = 50;
                    break;
                case 'C':
                    intValue = 100;
                    break;
                case 'D':
                    intValue = 500;
                    break;
                case 'M':
                    intValue = 1000;
                    break;
            }
            return intValue;
        }
    }
}
