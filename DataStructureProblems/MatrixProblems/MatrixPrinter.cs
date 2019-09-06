using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MatrixProblem
{
    public class MatrixOutputFormatter
    {
        public static string GetSpiralOrderFormat(int[][] matrix)
        {
            StringBuilder sbOutput = new StringBuilder();
                        
            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=0; j<matrix[i].Length; j++)
                {
                    sbOutput.Append(matrix[i][j].ToString());
                }
            }

            return sbOutput.ToString();
        }
    }
}
