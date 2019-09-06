using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MatrixProblem
{
    public class MatrixRotater
    {
        /// <summary>
        /// rotate matrix to the right
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool RotateMatrix(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length) return false;
            int n = matrix.Length;
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = matrix[first][i]; // save top
                    //left->top
                    matrix[first][i] = matrix[last - offset][first];

                    //bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    //right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    //top -> right
                    matrix[i][last] = top;

                }
            }
            return true;
        }
    }
}
