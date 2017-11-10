using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Funcion_Exponencial : Funcion
    {
        public static double a;
        public static double b;

        public void generarCoeficientes()
        {
            double sumatoriaX = 7.50;//Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXCuadrado = 11.875;//Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaXY = 14.422;//Form_Inicio_Ingresa_Datos.sumatoriaXY;
            double sumatoriaLogaritmoY = 9.404;//Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            int cantidadDePuntos = 5;//Form_Inicio_Ingresa_Datos.cantidadDePuntos;

            //double ecuacion1 = sumatoriaXCuadrado * a + sumatoriaX * b - sumatoriaXLogaritmoY;
            //double ecuacion2 = sumatoriaX * a + cantidadDePuntos * b - sumatoriaLogaritmoY;

            //a = (sumatoriaXLogaritmoY - sumatoriaX * b) / sumatoriaXCuadrado;
            //a = (sumatoriaLogaritmoY - cantidadDePuntos * b) / sumatoriaX;

            //Estas son las ecuaciones que calculan los coeficientes
            //Una vez obtenidos al leer la tabla, se utilizan aca sin hardcodear
            double bMayuscula = (sumatoriaX * sumatoriaXY - sumatoriaXCuadrado * sumatoriaLogaritmoY) / (sumatoriaX * sumatoriaX - sumatoriaXCuadrado * cantidadDePuntos);
            b = Math.Exp(bMayuscula);
            a = (sumatoriaLogaritmoY - cantidadDePuntos * bMayuscula) / sumatoriaX;
        }

    }
}
