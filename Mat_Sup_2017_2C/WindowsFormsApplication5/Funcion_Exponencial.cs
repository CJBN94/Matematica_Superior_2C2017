using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Funcion_Exponencial
    {
        private double a;
        private double b;

        public Funcion_Exponencial()
        {
            //double sumatoriaX = 7.50;//Form_Inicio_Ingresa_Datos.sumatoriaX;
            //double sumatoriaXCuadrado = 11.875;//Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            //double sumatoriaXLogaritmoY = 14.422;//Form_Inicio_Ingresa_Datos.sumatoriaXLogaritmoY;
            //double sumatoriaLogaritmoY = 9.404;//Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            //int cantidadDePuntos = 5;//Form_Inicio_Ingresa_Datos.cantidadDePuntos;

            double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaXLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaXLogaritmoY;
            double sumatoriaLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;

            //double ecuacion1 = sumatoriaXCuadrado * a + sumatoriaX * b - sumatoriaXLogaritmoY;
            //double ecuacion2 = sumatoriaX * a + cantidadDePuntos * b - sumatoriaLogaritmoY;

            //a = (sumatoriaXLogaritmoY - sumatoriaX * b) / sumatoriaXCuadrado;
            //a = (sumatoriaLogaritmoY - cantidadDePuntos * b) / sumatoriaX;

            //Estas son las ecuaciones que calculan los coeficientes
            double bMayuscula = Math.Round((sumatoriaX * sumatoriaXLogaritmoY - sumatoriaXCuadrado * sumatoriaLogaritmoY) / (sumatoriaX * sumatoriaX - sumatoriaXCuadrado * cantidadDePuntos), cantidadDeDecimales);
            b = Math.Round(Math.Exp(bMayuscula),cantidadDeDecimales);
            a = Math.Round((sumatoriaLogaritmoY - cantidadDePuntos * bMayuscula) / sumatoriaX, cantidadDeDecimales);
        }

        public double getCoeficienteA()
        {
            return a;
        }

        public double getCoeficienteB()
        {
            return b;
        }

    }
}
