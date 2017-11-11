using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form_Comparacion_De_Aproximaciones : Form
    {
        private double sumatoriaErrorCuadraticoLineal;
        private double sumatoriaErrorCuadraticoCuadratica;
        private double sumatoriaErrorCuadraticoExponencial;
        private double sumatoriaErrorCuadraticoPotencial;
        private double sumatoriaErrorCuadraticoHiperbola;

        public Form_Comparacion_De_Aproximaciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Comparacion_De_Aproximaciones_Load(object sender, EventArgs e)
        {
            double x;
            double y;
            double yLineal;
            double yCuadratica;
            double yExponencial;
            double yPotencial;
            double yHiperbola;
            double errorCuadraticoLineal;
            double errorCuadraticoCuadratica;
            double errorCuadraticoExponencial;
            double errorCuadraticoPotencial;
            double errorCuadraticoHiperbola;

            int cantidadDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;
            int cantidadDeDecimales = Form_Inicio_Ingresa_Datos.cantidadDeDecimales;
            double[,] puntos = Form_Inicio_Ingresa_Datos.puntos;
            Funcion_Lineal funcionLineal = Form_Inicio_Ingresa_Datos.funcionLineal;
            Funcion_Cuadratica funcionCuadratica = Form_Inicio_Ingresa_Datos.funcionCuadratica;
            Funcion_Potencial funcionPotencial = Form_Inicio_Ingresa_Datos.funcionPotencial;
            Funcion_Hiperbolica funcionHiperbolica = Form_Inicio_Ingresa_Datos.funcionHiperbolica;
            Funcion_Exponencial funcionExponencial = Form_Inicio_Ingresa_Datos.funcionExponencial;

            for (int i = 0; i < cantidadDePuntos; i++)
            {
                x = puntos[i, 0];
                y = puntos[i, 1];

                yLineal = Math.Round((funcionLineal.getCoeficienteA() * x) + funcionLineal.getCoeficienteB(), cantidadDeDecimales);
                yCuadratica = Math.Round((funcionCuadratica.getCoeficienteA() * x * x) + (funcionCuadratica.getCoeficienteB() * x) + funcionCuadratica.getCoeficienteC(), cantidadDeDecimales);
                yExponencial = Math.Round(funcionExponencial.getCoeficienteB() * Math.Exp(funcionExponencial.getCoeficienteA() * x), cantidadDeDecimales);
                yPotencial = Math.Round(funcionPotencial.getCoeficienteB() * Math.Pow(x, funcionPotencial.getCoeficienteA()), cantidadDeDecimales);
                yHiperbola = Math.Round(funcionHiperbolica.getCoeficienteA() / (x + funcionHiperbolica.getCoeficienteB()), cantidadDeDecimales);

                errorCuadraticoLineal = Math.Round(Math.Pow(yLineal - y, 2));
                errorCuadraticoCuadratica = Math.Round(Math.Pow(yCuadratica - y, 2));
                errorCuadraticoExponencial = Math.Round(Math.Pow(yExponencial - y, 2));
                errorCuadraticoPotencial = Math.Round(Math.Pow(yPotencial - y, 2));
                errorCuadraticoHiperbola = Math.Round(Math.Pow(yHiperbola - y, 2));

                sumatoriaErrorCuadraticoLineal = Math.Round(sumatoriaErrorCuadraticoLineal + errorCuadraticoLineal, cantidadDeDecimales);
                sumatoriaErrorCuadraticoCuadratica = Math.Round(sumatoriaErrorCuadraticoCuadratica + errorCuadraticoCuadratica, cantidadDeDecimales);
                sumatoriaErrorCuadraticoHiperbola = Math.Round(sumatoriaErrorCuadraticoHiperbola + errorCuadraticoHiperbola, cantidadDeDecimales);
                sumatoriaErrorCuadraticoPotencial = Math.Round(sumatoriaErrorCuadraticoPotencial + errorCuadraticoPotencial, cantidadDeDecimales);
                sumatoriaErrorCuadraticoExponencial = Math.Round(sumatoriaErrorCuadraticoExponencial + errorCuadraticoExponencial, cantidadDeDecimales);

                dgvComparacion.Rows.Add(i + 1, x, y, yLineal, yCuadratica, yHiperbola, yPotencial, yExponencial,
                    errorCuadraticoLineal, errorCuadraticoCuadratica, errorCuadraticoHiperbola,
                    errorCuadraticoPotencial, errorCuadraticoExponencial);
            }
            dgvComparacion.Rows.Add("Total", "", "", "", "", "", "", "",
                sumatoriaErrorCuadraticoLineal, sumatoriaErrorCuadraticoCuadratica,
                sumatoriaErrorCuadraticoHiperbola, sumatoriaErrorCuadraticoPotencial,
                sumatoriaErrorCuadraticoExponencial);
        }
    }
}
