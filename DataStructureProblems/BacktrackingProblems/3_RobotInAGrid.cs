using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BacktrackingProblems
{
    public class RobotInAGrid
    {
        private bool[][] _blocks;
        private int _xSize;
        private int _ySize;

        public RobotInAGrid(bool[][] blocks, int xSize, int ySize)
        {
            this._blocks = blocks;
            this._xSize = xSize;
            this._ySize = ySize;
        }

        public List<Point> GetPath()
        {
            throw new NotImplementedException();
        }

        private bool HandleGetPath(int currentX, int cu)
        {
            throw new NotImplementedException();
        }
    }

    public class Point
    {
        public int X;
        public int Y;
    }
}
