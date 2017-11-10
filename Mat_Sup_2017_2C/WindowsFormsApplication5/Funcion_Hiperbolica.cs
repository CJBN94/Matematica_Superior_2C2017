using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Funcion_Hiperbolica : Funcion
    {

        public static double a;
        public static double b;

        public void generarCoeficientes()
        {

            /*
            double sumatoriaXCuadrado = Form3.sumatoriaXCuadrado;
            double sumatoriaX = Form3.sumatoriaX;
            double sumatoriaXDivididoY = Form3.sumatoriaXDivididoY;
            double sumatoriaUnoDivididoY = Form3.sumatoriaUnoDivididoY;
            int cantidadDePuntos = Form3.cantidadDePuntos;
            */

            double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXDivididoY = Form_Inicio_Ingresa_Datos.sumatoriaXDivididoY;
            double sumatoriaUnoDivididoY = Form_Inicio_Ingresa_Datos.sumatoriaUnoDivididoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;

            //double bMayuscula = 0;
            //double aMayuscula1 = (sumatoriaXDivididoY - bMayuscula * sumatoriaX) / sumatoriaXCuadrado;
            //double aMayuscula2 = (sumatoriaUnoDivididoY - bMayuscula * cantidadDePuntos) / sumatoriaX;
            double bMayuscula = (sumatoriaX * sumatoriaUnoDivididoY - sumatoriaUnoDivididoY * sumatoriaXCuadrado) / ((sumatoriaX * sumatoriaX) - (cantidadDePuntos * sumatoriaXCuadrado));
            double aMayuscula = (sumatoriaUnoDivididoY - bMayuscula * cantidadDePuntos) / sumatoriaX;
            a = 1 / aMayuscula;
            b = bMayuscula * a;
        }

    }
}
