using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLib
{
    public class Triangle
    {
        public bool CanTriangleExist(double A_Side, double B_Side, double C_Side)
        {
            return (A_Side >= 0 && B_Side >= 0 && C_Side >= 0 && (A_Side + B_Side > C_Side && B_Side + C_Side > A_Side && A_Side + C_Side > B_Side));
        }
    }
}
