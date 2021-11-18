using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CaidaLibre
{
    public class CaidaLibre
    {

        public double Altura1(double vi, double t)
        {
            double resultado;

            resultado = vi * t + ((9.8*(t*t))/2);
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
