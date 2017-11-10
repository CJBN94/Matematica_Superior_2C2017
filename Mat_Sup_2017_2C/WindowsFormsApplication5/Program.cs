using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Inicio_Ingresa_Datos());

            //Prueba de funcion exponencial(OK)
            
            /*
            Funcion_Exponencial f = new Funcion_Exponencial();
            f.generarCoeficientes();
            MessageBox.Show("coeficiente a: " + Funcion_Exponencial.a + "\n" +
                "coeficiente b: " + Funcion_Exponencial.b, "Prueba",MessageBoxButtons.OK,MessageBoxIcon.Information);
            */

            //Prueba de funcion cuadratica(OK)
            /*
            Funcion_Cuadratica f = new Funcion_Cuadratica();
            f.generarCoeficientes();
            MessageBox.Show("coeficiente a: " + Funcion_Cuadratica.a + "\n" +
                "coeficiente b: " + Funcion_Cuadratica.b + "\n" +
                "coeficiente c: " + Funcion_Cuadratica.c, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
            /*
            //Prueba de funcion lineal(OK)
            Funcion_Lineal f = new Funcion_Lineal();
            f.generarCoeficientes();
            MessageBox.Show("coeficiente a: " + Funcion_Lineal.a + "\n" +
                "coeficiente b: " + Funcion_Lineal.b, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
            //Prueba de funcion potencial(OK)

            /*
            Funcion_Potencial f = new Funcion_Potencial();
            f.generarCoeficientes();
            MessageBox.Show("coeficiente a: " + Funcion_Potencial.a + "\n" +
                "coeficiente b: " + Funcion_Potencial.b, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */

            //Prueba de funcion hiperbolica(pendiente)

            /*
            Funcion_Hiperbolica f = new Funcion_Hiperbolica();
            f.generarCoeficientes();
            MessageBox.Show("coeficiente a: " + Funcion_Hiperbolica.a + "\n" +
                "coeficiente b: " + Funcion_Hiperbolica.b, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */

        }
    }
}
