using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MatrixProblems
{
    public class MatrixComparer
    {
        public static bool Are2DEqual(int[,] s, int[,] t)
        {

            if (s.GetLength(0) != t.GetLength(0) ||
        s.GetLength(1) != t.GetLength(1))
                return false;
            for (int i = 0; i < s.GetLength(0); i++)
                for (int j = 0; j < s.GetLength(1); j++)
                    if (s[i, j].CompareTo(t[i, j]) != 0)
                        return false;
            return true;

        }
    }
}
