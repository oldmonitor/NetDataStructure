using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.StackProblems
{
    public class ValidParentheses
    {
        private Dictionary<char, char> _openParen;
        private Dictionary<char, char> _closeParen;

        private void InitParentheseHashtable()
        {
            _openParen = new Dictionary<char, char>();
            _openParen.Add('(', ')');
            _openParen.Add('[', ']');
            _openParen.Add('{', '}');

            _closeParen = new Dictionary<char, char>();
            _closeParen.Add(')', '(');
            _closeParen.Add(']', '[');
            _closeParen.Add('}', '{');
        }

        public bool IsParenthesesValid(string str)
        {
            Stack<char> parenStack = new Stack<char>();
            this.InitParentheseHashtable();
            if(str.Length == 0)
            {
                return true;
            }
            foreach(char c in str)
            {
                // if c is open paren, push to stack
                if(_openParen.ContainsKey(c))
                {
                    parenStack.Push(c);
                }

                // if c is close paren, check the top of stack
                if(_closeParen.ContainsKey(c))
                {
                    if(parenStack.Count == 0)
                    {
                        return false;
                    }
                    if(parenStack.Pop() != _closeParen[c])
                    {
                        return false;
                    }
                }
            }

            if(parenStack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
