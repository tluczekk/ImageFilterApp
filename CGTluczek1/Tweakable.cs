using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGTluczek1
{
    class Tweakable
    {
        public static int brightCoeff = 50;
        public static double gammaCoeff = 3.0;
        public static int contrastCoeff = 20;
        public static double[,] blurKernel = new double[3, 3] { { 1, 1, 1 }, 
                                                                { 1, 1, 1 }, 
                                                                { 1, 1, 1 } };
        public static double[,] gaussBlurKernel = new double[5, 5] { { 0, 1, 2, 1, 0 }, 
                                                                     { 1, 4, 8, 4, 1 }, 
                                                                     { 2, 8, 16, 8, 2 }, 
                                                                     { 1, 4, 8, 4, 1 }, 
                                                                     { 0, 1, 2, 1, 0 } };
        public static double[,] sharpKernel = new double[3, 3] { { -1, -1, -1 }, 
                                                                 { -1, 9, -1 }, 
                                                                 { -1, -1, -1 } };
        public static double[,] edgeKernel = new double[3, 3] { { -1, -1, -1 }, 
                                                                { -1, 8, -1 }, 
                                                                { -1, -1, -1 } };
        public static double[,] embKernel = new double[3, 3] { { -1, -1, 0 }, 
                                                               { -1, 1, 1 }, 
                                                               { 0, 1, 1 } };
    }
}
