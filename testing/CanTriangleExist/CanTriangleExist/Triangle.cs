using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLib
{
    public class Triangle
    {
        public bool CanTriangleExist(double a, double b, double c)
        {
            if (a <= 0)
                return false;
            if (b <= 0)
                return false;
            if (c <= 0)
                return false;
            if (a + b <= c)
                return false;
            if (a + c <= b)
                return false;
            if (b + c <= a)
                return false;
            

            return true;
        }
    }
}
