using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Funcion_Lineal
    {
        //public static double a;
        //public static double b;

        private double a;
        private double b;
        
        //private void generarCoeficientes()
        //{
            
            //double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            //double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            //double sumatoriaXY = Form_Inicio_Ingresa_Datos.sumatoriaXY;
            //double sumatoriaY = Form_Inicio_Ingresa_Datos.sumatoriaY;
            //int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            
            /*Datos viejos para prueba (hardcodeado)
            double sumatoriaXCuadrado = 524;
            double sumatoriaX = 56;
            double sumatoriaXY = 364;
            double sumatoriaY = 40;
            int cantidadDePuntos = 8;
            */

            //b = (sumatoriaX * sumatoriaXY - sumatoriaY * sumatoriaXCuadrado) / (sumatoriaX * sumatoriaX - cantidadDePuntos * sumatoriaXCuadrado);
          //  a = (sumatoriaY - b * cantidadDePuntos) / sumatoriaX;
        //}
        

        public Funcion_Lineal()
        {
            double sumatoriaXCuadrado = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            double sumatoriaX = Form_Inicio_Ingresa_Datos.sumatoriaX;
            double sumatoriaXY = Form_Inicio_Ingresa_Datos.sumatoriaXY;
            double sumatoriaY = Form_Inicio_Ingresa_Datos.sumatoriaY;
            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;

            b = Math.Round((sumatoriaX * sumatoriaXY - sumatoriaY * sumatoriaXCuadrado) / (sumatoriaX * sumatoriaX - cantidadDePuntos * sumatoriaXCuadrado), cantidadDeDecimales);
            a = Math.Round((sumatoriaY - b * cantidadDePuntos) / sumatoriaX, cantidadDeDecimales);
        }

        public double getCoeficienteA(){
            return a;
        }

        public double getCoeficienteB(){
            return b;
        }

    }
}
