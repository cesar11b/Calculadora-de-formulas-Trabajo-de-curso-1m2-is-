using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Temperatura
{
    public class FormulaGeneral
    {

        public double FormGenPos(string a, string b, string c)
        {
            int a1 = (int)Convert.ToDouble(a);
            int b1 = (int)Convert.ToDouble(b);
            int c1 = (int)Convert.ToDouble(c);
            

            double resultado = (-b1 + Math.Sqrt(((b1 * b1) - (4 * a1 * c1)))) / 2 * a1;


            return resultado;


        }
        public double FormGenNeg(string a, string b, string c)
        {
            int a1 = (int)Convert.ToDouble(a);
            int b1 = (int)Convert.ToDouble(b);
            int c1 = (int)Convert.ToDouble(c);

            double resultado = (-b1 - Math.Sqrt(((b1 * b1) - (4 * a1 * c1)))) / 2 * a1;


            return resultado;


        }

    }
}
