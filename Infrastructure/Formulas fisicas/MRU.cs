using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class MRU
    {

        public double Distancia(string v, string t)
        {
            int v1 = (int)Convert.ToDouble(v);
            int t1 = (int)Convert.ToDouble(t);

            double resultado = v1 * t1;



            return resultado;


        }


        public double Velocidad(string d, string t)
        {

            int d1 = (int)Convert.ToDouble(d);
            int t1 = (int)Convert.ToDouble(t);


            double resultado = d1 / t1;

            return resultado;


        }

        public double Tiempo(string d, string v)
        {


            int d1 = (int)Convert.ToDouble(d);
            int v1 = (int)Convert.ToDouble(v);


            double resultado = d1 / v1;

            return resultado;
            


        }


    }
}
