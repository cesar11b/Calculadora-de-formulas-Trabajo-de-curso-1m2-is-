using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Ley2Newton
{
    public class Fuerza
    {


        public double Fuerza1(string m, string a)
        {

            int m1 = (int)Convert.ToDouble(m);
            int a1 = (int)Convert.ToDouble(a);

            //masa en kilogramos

            //aceleracion en m/s2

            double resultado;

            resultado = m1 * a1;


            return resultado;


        }



    }
}
