using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Funcion_Hiperbolica
    {

        private double a;
        private double b;

        public Funcion_Hiperbolica()
        {

            double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXDivididoY = Form_Inicio_Ingresa_Datos.sumatoriaXDivididoY;
            double sumatoriaUnoDivididoY = Form_Inicio_Ingresa_Datos.sumatoriaUnoDivididoY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;
            /*
            double sumatoriaXCuadrado = 55;
            double sumatoriaX = 15;
            double sumatoriaXDivididoY = 1.7718;
            double sumatoriaUnoDivididoY = 0.6457;
            int cantidadDePuntos = 5;
            */
            //double bMayuscula = 0;
            //double aMayuscula1 = (sumatoriaXDivididoY - bMayuscula * sumatoriaX) / sumatoriaXCuadrado;
            //double aMayuscula2 = (sumatoriaUnoDivididoY - bMayuscula * cantidadDePuntos) / sumatoriaX;
            double bMayuscula = Math.Round((sumatoriaX * sumatoriaXDivididoY - sumatoriaUnoDivididoY * sumatoriaXCuadrado) / ((sumatoriaX * sumatoriaX) - (cantidadDePuntos * sumatoriaXCuadrado)),cantidadDeDecimales);
            double aMayuscula = Math.Round((sumatoriaUnoDivididoY - bMayuscula * cantidadDePuntos) / sumatoriaX, cantidadDeDecimales);
            a = Math.Round(1 / aMayuscula,cantidadDeDecimales);
            b = Math.Round(bMayuscula * a, cantidadDeDecimales);
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
