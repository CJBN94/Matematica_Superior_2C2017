using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication5
{
    public partial class Form_Inicio_Ingresa_Datos : Form
    {
        public static int cantidadDeDecimales;
        public static double[,] puntos;
        public static int cantidadDePuntos;
        public static double sumatoriaX;
        public static double sumatoriaXCuadrado;
        public static double sumatoriaXCubo;
        public static double sumatoriaXCuarta;
        public static double sumatoriaLogaritmoX;
        public static double sumatoriaY;
        public static double sumatoriaYCuadrado;
        public static double sumatoriaLogaritmoY;
        public static double sumatoriaXY;
        public static double sumatoriaXConYCuadrado;
        public static double sumatoriaXLogaritmoY;
        public static double sumatoriaXCuadradoY;
        public static double sumatoriaXDivididoY;
        public static double sumatoriaUnoDivididoY; // (1/y)
        public static double sumatoriaLogaritmoXAlCuadrado;
        public static double sumatoriaLogaritmoXLogaritmoY;

        /*Funciones
        public static Funcion_Lineal funcionLineal;
        public static Funcion_Exponencial funcionExponencial;
        public static Funcion_Hiperbolica funcionHiperbolica;
        public static Funcion_Potencial funcionPotencial;
        public static Funcion_Cuadratica funcionCuadrarica;
        */

        public Form_Inicio_Ingresa_Datos()
        {
            InitializeComponent();
        }

        //Agrego los eventos para controlar que los textbox acepten lo que necesiten

        private void Form_Inicio_Ingresa_Datos_Load(object sender, EventArgs e)
        {
            this.setearEventosDeTextBox();
            this.setearEstadoInicial();
            this.CenterToScreen();
        }

        //Deshabilito los objetos necesarios para dar el estado inicial

        private void setearEstadoInicial()
        {
            txtCoordenadaX.Enabled = false;
            txtCoordenadaY.Enabled = false;
            btnAgregarPunto.Enabled = false;
            btnQuitarPunto.Enabled = false;
            btnQuitarTodos.Enabled = false;
            btnIngresarDatos.Enabled = false;
            btnCancelar.Enabled = false;
            dgvPuntos.Enabled = false;
        }

        //Asigno los eventos a los textbox a utilizar para verificaciones

        private void setearEventosDeTextBox()
        {
            txtCoordenadaX.KeyPress += this.soloNumerosPositivos_KeyPress;
            txtCoordenadaX.KeyPress += this.limitarCantidadDeDecimales_KeyPress;
            txtCoordenadaY.KeyPress += this.soloNumerosPositivos_KeyPress;
            txtCoordenadaY.KeyPress += this.limitarCantidadDeDecimales_KeyPress;
            txtCantidadDeDecimales.KeyPress += this.soloNumerosEnterosPositivos_KeyPress;
        }

        //Evento que solo permite escribir numeros positivos (incluidos decimales)

        private void soloNumerosPositivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cantidadDeDecimales > 0)
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    if ((sender as TextBox).Text.Length != 0 && e.KeyChar == ',')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

                
                // Verifico que solo tenga un decimal la cadena de texto
                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }

            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
         
        /*
        private void limitarCantidadDeDecimalesDeLaCoordenadaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            String decimales = cantidadDeDecimales.ToString();
            bool cumpleLimiteDeDecimales = Regex.IsMatch(txtCoordenadaX.Text, "^\\d*\\,\\d{"+cantidadDeDecimales+"}$");
            if (cumpleLimiteDeDecimales&&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void limitarCantidadDeDecimalesDeLaCoordenadaY_KeyPress(object sender, KeyPressEventArgs e)
        {
            String decimales = cantidadDeDecimales.ToString();

            if (decimales != "0")
            {
                bool cumpleLimiteDeDecimales = Regex.IsMatch(txtCoordenadaY.Text, "^\\d*\\,\\d{" + cantidadDeDecimales + "}$");
                if (cumpleLimiteDeDecimales && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }
        */

        //Evento que limita la cantidad de decimales de un numero

        private void limitarCantidadDeDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool cumpleLimiteDeDecimales = Regex.IsMatch((sender as TextBox).Text, "^\\d*\\,\\d{" + cantidadDeDecimales + "}$");
            if (cumpleLimiteDeDecimales && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //Evento que solo permite escribir numeros ENTEROS positivos

        private void soloNumerosEnterosPositivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Metodo que agrega un punto a la tabla que usa el boton AGREGAR PUNTO

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            if (txtCoordenadaX.Text != "" && txtCoordenadaY.Text != "")
            {
                if (Double.Parse(txtCoordenadaY.Text) != 0)
                {
                    Double x = Double.Parse(txtCoordenadaX.Text);
                    Double y = Double.Parse(txtCoordenadaY.Text);

                    dgvPuntos.Rows.Add(x, y);
                    btnQuitarPunto.Enabled = true;
                    btnQuitarTodos.Enabled = true;
                    dgvPuntos.Enabled = true;
                    btnIngresarDatos.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La Coordenada Y no puede tomar por valor el cero.", "Valor no permitido en coordenada Y", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                    MessageBox.Show("Coordenada X o Coordenada Y vacía. Inserte ambos valores de las coordenadas.", "Coordenadas vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //BtnQuitarPunto

        private void btnQuitarPunto_Click(object sender, EventArgs e)
        {
            if (!dgvPuntos.CurrentRow.IsNewRow)
            {
                dgvPuntos.Rows.Remove(dgvPuntos.CurrentRow);
                if (dgvPuntos.RowCount == 1)
                {
                    btnQuitarPunto.Enabled = false;
                    btnQuitarTodos.Enabled = false;
                    dgvPuntos.ClearSelection();
                    dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    btnIngresarDatos.Enabled = false;
                }
            }
        }

        //Vacia los datos de la tabla

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            dgvPuntos.Rows.Clear();
            btnIngresarDatos.Enabled = false;
        }

        private void btnFijarDecimales_Click(object sender, EventArgs e)
        {
            if (txtCantidadDeDecimales.Text != "")
            {
                txtCantidadDeDecimales.Enabled = false;
                btnFijarDecimales.Enabled = false;

                txtCoordenadaX.Enabled = true;
                txtCoordenadaY.Enabled = true;
                btnAgregarPunto.Enabled = true;
                btnCancelar.Enabled = true;

                cantidadDeDecimales = Int32.Parse(txtCantidadDeDecimales.Text);
            }
            else
            {
                MessageBox.Show("Inserte la cantidad de decimales con la que desea trabajar","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnFijarDecimales.Enabled = true;
            txtCantidadDeDecimales.Enabled = true;
            btnQuitarTodos_Click(sender,e);
            txtCoordenadaX.Text = "";
            txtCoordenadaY.Text = "";
            this.setearEstadoInicial();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            //calcularValores(); //Calcula las sumatorias
            //mostrarValores(); //Muestra los valores de las sumatorias calculadas (Debug)

            //Guardo las funciones como variables globales y calculo sus coeficientes
            /*
            funcionLineal = new Funcion_Lineal();
            funcionCuadratica = new Funcion_Cuadratica();
            funcionExponencial = new Funcion_Exponencial();
            funcionHiperbolica = new Funcion_Hiperbolica();
            funcionPotencial = new Funcion_Potencial();
            funcionLineal.generarCoeficientes();
            funcionCuadratica.generarCoeficientes();
            funcionExponencial.generarCoeficientes();
            funcionHiperbolica.generarCoeficientes();
            funcionPotencial.generarCoeficientes();
            */
            /*Menu_Seleccionar_Funcionalidades_Principales frmSeleccionDeFuncionalidades = new Menu_Seleccionar_Funcionalidades_Principales();
            frmSeleccionDeFuncionalidades.Visible = true;
            this.Visible = false;*/

            llenarMatrizDePuntos();
        }

        //llena la matriz de puntos desde el DGV
        private void llenarMatrizDePuntos()
        {
            int i, cantPuntos;

            cantPuntos = dgvPuntos.RowCount - 1;
            puntos = new double[cantPuntos, 2];


            for (i = 0; i < cantPuntos; i++)
            {
                puntos[i, 0] = Convert.ToDouble(dgvPuntos.Rows[i].Cells["X"].Value);
                puntos[i, 1] = Convert.ToDouble(dgvPuntos.Rows[i].Cells["Y"].Value);
                MessageBox.Show(puntos[i, 0] + " " + puntos[i, 1]);
            }

        }

        //Metodo que calcula los valores de las sumatorias (no funciona)

        private void calcularValores(){
            double x = 0;
            double y = 0;

            for (int i = 0; i < dgvPuntos.Rows.Count; i++)
            {
                x = Double.Parse(dgvPuntos.Rows[i].Cells["X"].Value.ToString());
                y = Double.Parse(dgvPuntos.Rows[i].Cells["Y"].Value.ToString());

                sumatoriaX += x;
                sumatoriaXCuadrado += (x * x);
                sumatoriaXCubo += (x * x * x);
                sumatoriaXCuarta += (x * x * x * x);
                sumatoriaLogaritmoX += Math.Log(x);
                sumatoriaY += y;
                sumatoriaYCuadrado += (y * y);
                sumatoriaXY += (x * y);
                sumatoriaXLogaritmoY += (x * Math.Log(y));
                sumatoriaXConYCuadrado += (x * (y * y));
                sumatoriaLogaritmoY += Math.Log(y);
                cantidadDePuntos += 1;
            }

            /*DataGridViewRowCollection filas = dgvPuntos.Rows;
            foreach (DataGridViewRow dr in filas)
            {
                //string col1 = dr.Cells["X"].Value.ToString();
                //string col2 = dr.Cells["Y"].Value.ToString();
                x = Double.Parse(dr.Cells["X"].Value.ToString());
                y = Double.Parse(dr.Cells["Y"].Value.ToString());

                sumatoriaX += x;
                sumatoriaXCuadrado += (x * x);
                sumatoriaXCubo += (x * x * x);
                sumatoriaXCuarta += (x * x * x * x);
                sumatoriaLogaritmoX += Math.Log(x);
                sumatoriaY += y;
                sumatoriaYCuadrado += (y * y);
                sumatoriaXY += (x * y);
                sumatoriaXLogaritmoY += (x * Math.Log(y));
                sumatoriaXConYCuadrado += (x * (y * y));
                sumatoriaLogaritmoY += Math.Log(y);
                cantidadDePuntos += 1;

            }*/
        }

        private void mostrarValores()
        {
            MessageBox.Show("sumatoriaX: " + sumatoriaX + "\n" +
                "sumatoriaXCuadrado: " + sumatoriaXCuadrado + "\n" +
                "sumatoriaXCubo: " + sumatoriaXCubo + "\n" +
                "sumatoriaXCuarta: " + sumatoriaXCuarta + "\n" +
                "sumatoriaLogaritmoX: " + sumatoriaLogaritmoX + "\n" +
                "sumatoriaY: " + sumatoriaY + "\n" +
                "sumatoriaYCuadrado: " + sumatoriaYCuadrado + "\n" +
                "sumatoriaXY: " + sumatoriaXY + "\n" +
                "sumatoriaXLogaritmoY: " + sumatoriaXLogaritmoY + "\n" +
                "sumatoriaXConYCuadrado: " + sumatoriaXConYCuadrado + "\n" +
                "sumatoriaLogaritmoY: " + sumatoriaLogaritmoY + "\n" +
                "cantidadDePuntos: " + cantidadDePuntos, "Calculos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
