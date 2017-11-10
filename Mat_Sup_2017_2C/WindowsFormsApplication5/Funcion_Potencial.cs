using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Funcion_Potencial : Funcion
    {

        public static double a;
        public static double b;

        public void generarCoeficientes()
        {
            /*
            double sumatoriaLogaritmoXAlCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXAlCuadrado;
            double sumatoriaLogaritmoX = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoX;
            double sumatoriaLogaritmoXLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXLogaritmoY;
            double sumatoriaLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            */

            double sumatoriaLogaritmoXAlCuadrado = 2.48689;
            double sumatoriaLogaritmoX = 2.85547;
            double sumatoriaLogaritmoXLogaritmoY = 5.39618;
            double sumatoriaLogaritmoY = 7.9787;
            int cantidadDePuntos = 5;

            double bMayuscula = (sumatoriaLogaritmoX * sumatoriaLogaritmoXLogaritmoY - sumatoriaLogaritmoY * sumatoriaLogaritmoXAlCuadrado) / (sumatoriaLogaritmoX * sumatoriaLogaritmoX - cantidadDePuntos * sumatoriaLogaritmoXAlCuadrado);
            a = (sumatoriaLogaritmoY - bMayuscula * cantidadDePuntos) / sumatoriaLogaritmoX;
            b = Math.Exp(bMayuscula);

        }



    }
}
