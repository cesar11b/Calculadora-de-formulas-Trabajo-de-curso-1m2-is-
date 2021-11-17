using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Formulas_fisicas
{
    public class MRUA
    {
        public float Aceleracion(float vf, float vi, float t)
        {

            float resultado;

            resultado = (vf - vi) / t;

            return resultado;
        }

        public float distancia1(float vf, float vi, float t)
        {

            float resultado = ((vf + vi) / 2) * t;

            return resultado;


        }


        public double distancia2(double vi, double t, double a)
        {

            double resultado = (vi*t)+(a*(t*t))/2;

            return resultado;


        }

        public double VelocidadFinal(double VelInical, double Distancia, double aceleracion)
        {
            double resultado = Math.Pow(VelInical,2) + 2*(Distancia * aceleracion); 

            return resultado;
        }






    }
}
