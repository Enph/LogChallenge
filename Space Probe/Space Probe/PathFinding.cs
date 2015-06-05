using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Probe
{
    class PathFinding
    {

        public Universe uni = new Universe();
        Point[] _movements;
        CompleteSquare[,] _squares = new CompleteSquare[uni.row, uni.col];



        public PathFinding()
        {
        }

        public void InitMovements(int movementCount)
        {
            if (movementCount == 4)
            {
                _movements = new Point[]
                {
                    new Point(0,-1),
                new Point(1, 0),
                new Point(0, 1),
                new Point(-1, 0)
                };
            }
            else
            {
                _movements = new Point[]
                {
                    new Point(-1,1),
                    new Point(0,-1),
                    new Point(1,-1),
                    new Point(1,0),
                    new Point(1,1),
                    new Point(-1,0)
                };
            }
        }

        //Keep bounderies inside
        public bool ValidCoordinates(int x, int y)
        {
            if (x < 0)
            {
                return false;
            }
            if (y < 0)
            {
                return false;
            }
            if (x > uni.col)
            {
                return false;
            }
            if (y > uni.row)
            {
                return false;
            }
            return true;
        }

    }
}
