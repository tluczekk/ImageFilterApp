using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTluczek1
{
    public class Polyline
    {
        public double[,] points;
        public Polyline()
        {
            points = new double[256, 2];
            for(int i = 0; i < 256; i++)
            {
                points[i,0] = i;
                points[i, 1] = i;
            }
        }

    }
}
