using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class MRU
    {

        public float Distancia(float v, float t)
        {
            float resultado = v * t;



            return resultado;


        }


        public float Velocidad(float d, float t)
        {

            float resultado = d / t;

            return resultado;


        }

        public float Tiempo(float d, float v)
        {

            float resultado = d / v;

            return resultado;


        }


    }
}
