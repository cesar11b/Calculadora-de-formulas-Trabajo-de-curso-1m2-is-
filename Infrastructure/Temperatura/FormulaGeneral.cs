using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Temperatura
{
    public class FormulaGeneral
    {

        public double FormGenPos(double a, double b, double c)
        {

            double resultado = (-b + Math.Sqrt(((b * b) - (4 * a * c)))) / 2 * a;


            return resultado;


        }

        public double FormGenNeg(double a, double b, double c)
        {

            double resultado = (-b - Math.Sqrt(((b * b) - (4 * a * c)))) / 2 * a;


            return resultado;


        }

    }
}
