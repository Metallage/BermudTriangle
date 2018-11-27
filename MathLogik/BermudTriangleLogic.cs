using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLogik
{
    public class BermudTriangleLogic
    {
        //test upd
        private int[] simField = new int[2];
        private int[,] triangleField = new int[3,2];
        private static Random xRandom;
        private static Random yRandom;

        public BermudTriangleLogic(int xCoord, int yCoord)
        {
            simField[0] = xCoord;
            simField[1] = yCoord;
            xRandom = new Random(xCoord);
            yRandom = new Random(yCoord);
        }
      
    }
}
