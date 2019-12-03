using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj3
{
    class Config
    {
        public static double[,] identity = new double[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        public static double[,] blur = new double[,] { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
        public static double[,] sharpen = new double[,] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
        public static double[,] edges_detection = new double[,] { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
        public static double[,] emboss = new double[,] { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
        public static double[,] gaussian_blur = new double[,] { { 1, 4, 6, 4, 1 }, { 4, 16, 24, 16, 4 }, { 6, 24, 36, 24, 6 }, { 4, 16, 24, 16, 4 }, { 1, 4, 6, 4, 1 } };
    }
}
