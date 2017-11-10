using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Funcion_Potencial
    {

        private double a;
        private double b;

        public Funcion_Potencial()
        {
            double sumatoriaLogaritmoXAlCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXAlCuadrado;
            double sumatoriaLogaritmoX = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoX;
            double sumatoriaLogaritmoXLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXLogaritmoY;
            double sumatoriaLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;


            double bMayuscula = Math.Round((sumatoriaLogaritmoX * sumatoriaLogaritmoXLogaritmoY - sumatoriaLogaritmoY * sumatoriaLogaritmoXAlCuadrado) / (sumatoriaLogaritmoX * sumatoriaLogaritmoX - cantidadDePuntos * sumatoriaLogaritmoXAlCuadrado), cantidadDeDecimales);
            a = Math.Round((sumatoriaLogaritmoY - bMayuscula * cantidadDePuntos) / sumatoriaLogaritmoX, cantidadDeDecimales);
            b = Math.Round(Math.Exp(bMayuscula), cantidadDeDecimales);
        }

        //public void generarCoeficientes()
        //{
            /*
            double sumatoriaLogaritmoXAlCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXAlCuadrado;
            double sumatoriaLogaritmoX = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoX;
            double sumatoriaLogaritmoXLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoXLogaritmoY;
            double sumatoriaLogaritmoY = Form_Inicio_Ingresa_Datos.sumatoriaLogaritmoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            */

            //double sumatoriaLogaritmoXAlCuadrado = 2.48689;
            //double sumatoriaLogaritmoX = 2.85547;
            //double sumatoriaLogaritmoXLogaritmoY = 5.39618;
            //double sumatoriaLogaritmoY = 7.9787;
            //int cantidadDePuntos = 5;

            //double bMayuscula = (sumatoriaLogaritmoX * sumatoriaLogaritmoXLogaritmoY - sumatoriaLogaritmoY * sumatoriaLogaritmoXAlCuadrado) / (sumatoriaLogaritmoX * sumatoriaLogaritmoX - cantidadDePuntos * sumatoriaLogaritmoXAlCuadrado);
            //a = (sumatoriaLogaritmoY - bMayuscula * cantidadDePuntos) / sumatoriaLogaritmoX;
            //b = Math.Exp(bMayuscula);

        //}

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
