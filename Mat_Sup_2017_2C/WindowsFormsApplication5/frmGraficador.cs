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
    public partial class frmGraficador : Form
    {
        double x, y;
        //double a, b, c;

        public frmGraficador()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void borrarGraficos()
        {
            chart.Series[0].Enabled = false;
            chart.Series[1].Enabled = false;
            chart.Series[2].Enabled = false;
            chart.Series[3].Enabled = false;
            chart.Series[4].Enabled = false;
            chart.Series[5].Enabled = false;

            //chart.Series[6].Enabled = false; 
        }


        public void graficarPuntos()
        {
            //
            chart.Series[0].Enabled = true;
        }

        public void graficarRecta(double a, double b, double cotaMin, double cotaMax)
        {
            chart.Series[1].Points.Clear();
            borrarGraficos();

            for (x = cotaMin; x <= cotaMax; x += 0.5)
            {
                y = (a * x) + b;
                chart.Series[1].Points.AddXY(x, y);
            }
            chart.Series[1].Enabled = true;

            if (Form_Inicio_Ingresa_Datos.swNubeDePuntos==1)
            {
                ingresarPuntosAlGraficador(); 
            }

        }

        private void rbRecta_Leave(object sender, EventArgs e)
        {


        }


        public void graficarParabola(double a, double b, double c, double cotaMin, double cotaMax)
        {
            chart.Series[2].Points.Clear();
            borrarGraficos();

            for (x = cotaMin; x <= cotaMax; x += 0.5)
            {
                y = (a * x * x) + (b * x) + c;
                chart.Series[2].Points.AddXY(x, y);
            }
            chart.Series[2].Enabled = true;

            if (Form_Inicio_Ingresa_Datos.swNubeDePuntos == 1)
            {
                ingresarPuntosAlGraficador();
            }
        }

        public void graficarExponencial(double a, double b, double cotaMin, double cotaMax)
        {
            chart.Series[3].Points.Clear();
            borrarGraficos();

            for (x = cotaMin; x <= cotaMax; x += 0.5)
            {
                //y = b * (Math.Pow(Math.E,(a*x)));
                y = b * Math.Exp(a * x);
                chart.Series[3].Points.AddXY(x, y);
            }
            chart.Series[3].Enabled = true;

            if (Form_Inicio_Ingresa_Datos.swNubeDePuntos == 1)
            {
                ingresarPuntosAlGraficador();
            }
        }

        public void graficarPotencial(double a, double b, double cotaMin, double cotaMax)
        {
            chart.Series[4].Points.Clear();
            borrarGraficos();

            for (x = cotaMin; x <= cotaMax; x += 0.5)
            {
                y = b * Math.Pow(x, a);
                chart.Series[4].Points.AddXY(x, y);
            }
            chart.Series[4].Enabled = true;

            if (Form_Inicio_Ingresa_Datos.swNubeDePuntos == 1)
            {
                ingresarPuntosAlGraficador();
            }
        }

        public void graficarHiperbola(double a, double b, double cotaMin, double cotaMax)
        {
            double asintota;

            chart.Series[5].Points.Clear();
            chart.Series[6].Points.Clear();
            borrarGraficos();

            asintota = -b;

            for (x = cotaMin; x <= asintota - 0.1; x += 0.5)
            {
                y = a / (x + b);
                chart.Series[5].Points.AddXY(x, y);
            }

            for (x = asintota + 0.5; x <= cotaMax; x += 0.5)
            {
                y = a / (x + b);
                chart.Series[6].Points.AddXY(x, y);
            }

            chart.Series[5].Color = Color.Green;
            chart.Series[5].Enabled = true;
            chart.Series[6].Color = Color.Green;
            chart.Series[6].Enabled = true;

            if (Form_Inicio_Ingresa_Datos.swNubeDePuntos == 1)
            {
                ingresarPuntosAlGraficador();
            }
        }

        private void ingresarPuntosAlGraficador()
        {
            int cantDePuntos;
            int i;
            cantDePuntos = Form_Inicio_Ingresa_Datos.cantidadDePuntos;

            for (i = 0; i < cantDePuntos; i++)
            {
                chart.Series[0].Points.AddXY(Form_Inicio_Ingresa_Datos.puntos[i, 0], Form_Inicio_Ingresa_Datos.puntos[i, 1]);
            }

            chart.Series[0].Enabled = true;

        }

        private void frmGraficador_Load(object sender, EventArgs e)
        {

        }
    }
}
