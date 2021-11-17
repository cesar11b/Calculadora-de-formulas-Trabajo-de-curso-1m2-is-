using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Formulas_fisicas
{
    public class MRUV
    {

        public double VelFinalV1(double VelInical, double acelaracion, double IntervaloTiempo)
        {

            double resultado = VelInical + (acelaracion * IntervaloTiempo);
                 
                return resultado;
        }

        public double distanciaV1(double VelInical, double acelaracion, double IntervaloTiempo)
        {

            double resultado = (VelInical* IntervaloTiempo) + 1/2*(acelaracion * Math.Pow(IntervaloTiempo, 2));

            return resultado;
        }

        public double distanciaV2(double VelFinal, double acelaracion, double IntervaloTiempo)
        {

            double resultado = (VelFinal *IntervaloTiempo)- 1/2*(acelaracion * Math.Pow(IntervaloTiempo,2));

            return resultado;
        }

        public double VelFinalV2Cuadrada(double VelInicial, double acelaracion, double distancia)
        {

            double resultado = Math.Pow(VelInicial, 2) + (2 * (acelaracion * distancia));
            return resultado;

        }
        public double distanciaV3(double VelFinal, double VelInicial, double IntervaloTiempo)
        {

            double resultado = ((VelInicial * VelFinal) / 2) * IntervaloTiempo;
            return resultado;

        }



        }
}
