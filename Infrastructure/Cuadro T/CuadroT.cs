using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Cuadro_T
{
    public class CuadroT
    {


        public string CelFar(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = (dat * 1.8) + 32.0;

            string data = Convert.ToString(dato);

            return data;

        }


        public string Celkel(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = dat  + 273.15;

            string data = Convert.ToString(dato);

            return data;

        }

        public string farcel(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = (dat - 32)*(5/9);

            string data = Convert.ToString(dato);

            return data;

        }

        public string farkel(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = (dat - 32) * (5 / 9)+ 273.15;

            string data = Convert.ToString(dato);

            return data;

        }


        public string kelcel(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = dat - 273.15;

            string data = Convert.ToString(dato);

            return data;

        }

        public string kelfar(string c)
        {
            double dat = (int)Convert.ToDouble(c);

            double dato = (dat - 273.15)*(9/5)+32;

            string data = Convert.ToString(dato);

            return data;

        }


    }
}
