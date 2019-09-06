using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MatrixProblems
{
    public class ZeroColumnRowSetter
    {
        /// <summary>
        /// Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
        ///  column are set to 0.
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        public static void SetZeroValue(int[,] matrix)
        {
            bool[] horizontal = new bool[matrix.Length];
            bool[] vertical;
            if(horizontal.Length > 0)
            {
                vertical = new bool[matrix.GetLength(1)];
            }
            else
            {
                return;
            }

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1);j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        horizontal[i] = true;
                        vertical[j] = true;
                    }
                }
            }

            //set

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (horizontal[i] == true || vertical[j] == true)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

        }
    }
}
