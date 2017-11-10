using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Funcion_Cuadratica
    {

        private double[,] matriz = new double[3, 4];
        private double a;
        private double b;
        private double c;

        public Funcion_Cuadratica()
        {
            //Cargo la matriz con los valores a usar
            cargarMatriz();
            //Verificar si existe algun pivote en las filas que se pueda intercambiar
            buscarPivoteIntercambiar(matriz);
            //comenzamos a checkar matriz para ir determinando matriz invertida
            algoritmoGauss(matriz);
            //Seteo los coeficientes encontrados de la parabola
            setearCoeficientes(matriz);
        }

        private void cargarMatriz()
        {
            
            matriz[0, 0] = Form_Inicio_Ingresa_Datos.sumatoriaXCuarta;
            matriz[0, 1] = Form_Inicio_Ingresa_Datos.sumatoriaXCubo;
            matriz[0, 2] = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            matriz[0, 3] = Form_Inicio_Ingresa_Datos.sumatoriaXCuadradoY;
            matriz[1, 0] = Form_Inicio_Ingresa_Datos.sumatoriaXCubo;
            matriz[1, 1] = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            matriz[1, 2] = Form_Inicio_Ingresa_Datos.sumatoriaX;
            matriz[1, 3] = Form_Inicio_Ingresa_Datos.sumatoriaXY;
            matriz[2, 0] = Form_Inicio_Ingresa_Datos.sumatoriaXCuadrado;
            matriz[2, 1] = Form_Inicio_Ingresa_Datos.sumatoriaX;
            matriz[2, 2] = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            matriz[2, 3] = Form_Inicio_Ingresa_Datos.sumatoriaY;
            
            /*
            matriz[0, 0] = 18971.9348;
            matriz[0, 1] = 2275.352;
            matriz[0, 2] = 291.2;
            matriz[0, 3] = 1448.988;
            matriz[1, 0] = 2275.352;
            matriz[1, 1] = 291.2;
            matriz[1, 2] = 42.2;
            matriz[1, 3] = 230.42;
            matriz[2, 0] = 291.2;
            matriz[2, 1] = 42.2;
            matriz[2, 2] = 8;
            matriz[2, 3] = 46.4;
            */
        }

        private void buscarPivoteIntercambiar(Double[,] matriz)
        {
            //obtenemos el tamaño de la matriz
            int tamMatriz = matriz.GetUpperBound(1);
            int pivote = 0;

            for (int i = 0; i < tamMatriz; i++)
            {
                //verificamos si elemento pivote ya contiene un 1

                if (matriz[pivote, pivote] != 1)
                {
                    for (int r = 0; r < tamMatriz; r++)
                    {
                        if (Convert.ToString(matriz[r, i]) == "1" && ((r + i) != (pivote + pivote)))
                        {
                            for (int j = 0; j < tamMatriz + 1; j++)
                            {
                                Double temp = matriz[pivote, j];
                                matriz[pivote, j] = matriz[r, j];
                                matriz[r, j] = temp;
                            }
                            buscarPivoteIntercambiar(matriz);
                        }
                    }
                }
                pivote++;
            }

        }

        private void setearCoeficientes(Double[,] matriz)
        {
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;

            int tamMatriz = matriz.GetUpperBound(1);
            a = Math.Round(matriz[0, tamMatriz],cantidadDeDecimales);
            b = Math.Round(matriz[1, tamMatriz],cantidadDeDecimales);
            c = Math.Round(matriz[2, tamMatriz],cantidadDeDecimales);
        }

        private void algoritmoGauss(Double[,] matriz)
        {

            int tamMatriz = matriz.GetUpperBound(1);
            int pivote = 0;

            for (int i = 0; i <= tamMatriz - 1; i++)
            {

                if (matriz[i, i] == 0)
                {
                    //Deberia lanzar un error
                    //rchTeOperaciones.Text += "Error: " + "no es posible resolver ecuacion";
                }
                else
                {

                    if (matriz[i, i] != 1)
                    {
                        Double divisorPiv = matriz[i, i];
                        for (int col = 0; col <= tamMatriz; col++)
                        {
                            matriz[i, col] = matriz[i, col] / divisorPiv;
                        }
                    }

                    for (int ren = 0; ren < tamMatriz; ren++)
                    {

                        if (ren != pivote)
                        {

                            Double val0 = -Convert.ToDouble(matriz[ren, i]);
                            for (int col = 0; col <= tamMatriz; col++)
                            {
                                matriz[ren, col] = matriz[i, col] * val0 + matriz[ren, col];
                            }

                        }

                    }

                }
                pivote++;
            }

        }

        public double getCoeficienteA()
        {
            return a;
        }

        public double getCoeficienteB()
        {
            return b;
        }

        public double getCoeficienteC()
        {
            return c;
        }

    }
}
