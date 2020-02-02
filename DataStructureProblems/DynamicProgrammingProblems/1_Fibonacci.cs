using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.DynamicProgrammingProblems
{
    public class Fibonacci
    {
        private Dictionary<int, int> cache = new Dictionary<int, int>();

        public int GetFibonacciNumber(int number)
        {
            if(number < 2)
            {
                return number;
            }

            if (this.cache.ContainsKey(number))
            {
                return cache[number];
            }

            cache.Add(number, GetFibonacciNumber(number - 1) + GetFibonacciNumber(number - 2));
            return cache[number];
        }
    }
}
