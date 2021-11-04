using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Cuadro_T
{
    public class CuadroT
    {


        public double CuadrosT(double a, double b, string c)
        {
            double dat = (int)Convert.ToDouble(c));

            double data = dat * b / a;

            return data;

        }
    }
}
