using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Funcion_Lineal : Funcion
    {
        public static double a;
        public static double b;

        public void generarCoeficientes()
        {
            /*
            double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXY = Form_Inicio_Ingresa_Datos.sumatoriaXY;
            double sumatoriaY = Form_Inicio_Ingresa_Datos.sumatoriaY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
             * */

            double sumatoriaXCuadrado = 524;
            double sumatoriaX = 56;
            double sumatoriaXY = 364;
            double sumatoriaY = 40;
            int cantidadDePuntos = 8;

            b = (sumatoriaX * sumatoriaXY - sumatoriaY * sumatoriaXCuadrado) / (sumatoriaX * sumatoriaX - cantidadDePuntos * sumatoriaXCuadrado);
            a = (sumatoriaY - b * cantidadDePuntos) / sumatoriaX;
        }

    }
}
