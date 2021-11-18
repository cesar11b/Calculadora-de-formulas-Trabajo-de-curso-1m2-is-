using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CaidaLibre
{
    public class CaidaLibre
    {

        public double Altura1(string vi, string t)
        {
            double resultado;

            int vi1 = (int)Convert.ToDouble(vi);
            int t1 = (int)Convert.ToDouble(t);


            resultado = vi1 * t1  + ((9.8*(t1*t1))/2);
            //mxs

            return resultado;

        }

        public double Altura2(double vi, double vf, double t)
        {
            double resultado;

            resultado = ((vi+vf)/2)*t;
            //mxs

            return resultado;

        }


        public double velfin(double vi, double t)
        {

            double resultado;

            resultado = vi + (9.8 * t);


            return resultado;


        }













    }
}
