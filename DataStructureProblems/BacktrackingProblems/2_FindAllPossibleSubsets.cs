using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BacktrackingProblems
{
    public class FindAllPossibleSubsets
    {
        public List<List<string>> HandleFindAllPossibleSubsets(List<string> input)
        {
            List<List<string>> result = new List<List<string>>();
            List<string> subset = new List<string>();
            recursiveFindPossibleSubsets(result, input, 0, subset);
            return result;
        }

        /// <summary>
        /// think of this problem as tree traval. each path is one possible subset. Check the graph
        /// </summary>
        /// <param name="result"></param>
        /// <param name="input"></param>
        /// <param name="position"></param>
        /// <param name="subset"></param>
        private void recursiveFindPossibleSubsets(List<List<string>> result, List<string> input, int position, List<string> subset)
        {
            if(position == input.Count)
            {
                if(subset.Count > 0)
                    result.Add(new List<string>(subset));
                return;
            }

            // go the substree excluding the current character
            recursiveFindPossibleSubsets(result, input, position + 1, subset);

            // add the current character the subset
            subset.Add(input[position]);

            // go to the subtree including the current character
            recursiveFindPossibleSubsets(result, input, position + 1, subset);

            //reset
            subset.RemoveAt(subset.Count - 1);
        }

    }
    
}
