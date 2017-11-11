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
    public partial class Menu_Seleccionar_Funcion_Aproximante : Form
    {
        public Menu_Seleccionar_Funcion_Aproximante()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGraficador frmGraficador = new frmGraficador();
            double a,b;
            a=Form_Inicio_Ingresa_Datos.funcionLineal.getCoeficienteA();
            b=Form_Inicio_Ingresa_Datos.funcionLineal.getCoeficienteB();

            frmGraficador.graficarRecta(a, b, -20, 20);
            frmGraficador.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGraficador frmGraficador = new frmGraficador();
            double a, b, c;

            a = Form_Inicio_Ingresa_Datos.funcionCuadratica.getCoeficienteA();
            b = Form_Inicio_Ingresa_Datos.funcionCuadratica.getCoeficienteB();
            c = Form_Inicio_Ingresa_Datos.funcionCuadratica.getCoeficienteC();

            frmGraficador.graficarParabola(a, b, c, -20, 20);
            frmGraficador.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGraficador frmGraficador = new frmGraficador();
            double a, b;

            a = Form_Inicio_Ingresa_Datos.funcionHiperbolica.getCoeficienteA();
            b = Form_Inicio_Ingresa_Datos.funcionHiperbolica.getCoeficienteB();
            
            frmGraficador.graficarHiperbola(a, b, -2, 2);
            frmGraficador.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGraficador frmGraficador = new frmGraficador();
            double a, b;

            a = Form_Inicio_Ingresa_Datos.funcionPotencial.getCoeficienteA();
            b = Form_Inicio_Ingresa_Datos.funcionPotencial.getCoeficienteB();

            frmGraficador.graficarPotencial(a, b, -20, 20);
            frmGraficador.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGraficador frmGraficador = new frmGraficador();
            double a, b;

            a = Form_Inicio_Ingresa_Datos.funcionExponencial.getCoeficienteA();
            b = Form_Inicio_Ingresa_Datos.funcionExponencial.getCoeficienteB();

            frmGraficador.graficarExponencial(a, b, -20, 20);
            frmGraficador.Visible = true;
        }
    }
}
