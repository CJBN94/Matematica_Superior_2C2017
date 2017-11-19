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
        public static Form_Inicio_Ingresa_Datos formInicio = null;
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
        public static int swNubeDePuntos;
        public static int swCantPuntos;


        //Funciones
        public static Funcion_Lineal funcionLineal;
        public static Funcion_Exponencial funcionExponencial;
        public static Funcion_Hiperbolica funcionHiperbolica;
        public static Funcion_Potencial funcionPotencial;
        public static Funcion_Cuadratica funcionCuadratica;

        public Form_Inicio_Ingresa_Datos()
        {
            InitializeComponent();
            this.Visible = true;
            if (formInicio == null)
            {
                formInicio = this;
            }
        }

        //Reinicia los datos

        public void retornarAEstadoInicial()
        {
            cantidadDeDecimales = 0;
            puntos = null;
            cantidadDePuntos = 0;
            sumatoriaX = 0;
            sumatoriaXCuadrado = 0;
            sumatoriaXCubo = 0;
            sumatoriaXCuarta = 0;
            sumatoriaLogaritmoX = 0;
            sumatoriaY = 0;
            sumatoriaYCuadrado = 0;
            sumatoriaLogaritmoY = 0;
            sumatoriaXY = 0;
            sumatoriaXConYCuadrado = 0;
            sumatoriaXLogaritmoY = 0;
            sumatoriaXCuadradoY = 0;
            sumatoriaXDivididoY = 0;
            sumatoriaUnoDivididoY = 0;
            sumatoriaLogaritmoXAlCuadrado = 0;
            sumatoriaLogaritmoXLogaritmoY = 0;
            swNubeDePuntos = 0;
            swCantPuntos = 0;

            setearEstadoInicialDeComponentesContenedores();
            setearVisibilidadInicialDeComponentes();
        }

        //Setea el estado inicial de campos de texto y matrices

        private void setearEstadoInicialDeComponentesContenedores(){
            this.txtCoordenadaX.Clear();
            this.txtCantidadDeDecimales.Clear();
            this.txtCoordenadaY.Clear();
            this.dgvPuntos.Rows.Clear();
        }

        //Agrego los eventos para controlar que los textbox acepten lo que necesiten

        private void Form_Inicio_Ingresa_Datos_Load(object sender, EventArgs e)
        {
            this.setearEventosDeTextBox();
            this.setearVisibilidadInicialDeComponentes();
            this.CenterToScreen();
        }

        //Deshabilito los objetos necesarios para dar el estado inicial

        private void setearVisibilidadInicialDeComponentes()
        {
            txtCantidadDeDecimales.Enabled = true;
            btnFijarDecimales.Enabled = true;
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
                MessageBox.Show("Inserte la cantidad de decimales con la que desea trabajar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnFijarDecimales.Enabled = true;
            txtCantidadDeDecimales.Enabled = true;
            btnQuitarTodos_Click(sender, e);
            txtCoordenadaX.Text = "";
            txtCoordenadaY.Text = "";
            this.setearVisibilidadInicialDeComponentes();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            llenarMatrizDePuntos();
            generarFunciones();
            mostrarValores();
            Menu_Seleccionar_Funcionalidades_Principales frmSeleccionDeFuncionalidades = new Menu_Seleccionar_Funcionalidades_Principales();
            frmSeleccionDeFuncionalidades.Visible = true;
            this.Visible = false;
        }

        //llena la matriz de puntos desde el DGV
        private void llenarMatrizDePuntos()
        {
            int i;
            double x;
            double y;

            cantidadDePuntos = dgvPuntos.RowCount - 1;
            puntos = new double[cantidadDePuntos, 2];
            swCantPuntos = cantidadDePuntos;


            for (i = 0; i < cantidadDePuntos; i++)
            {
                x = Convert.ToDouble(dgvPuntos.Rows[i].Cells["X"].Value);
                y = Convert.ToDouble(dgvPuntos.Rows[i].Cells["Y"].Value);

                //puntos[i, 0] = Convert.ToDouble(dgvPuntos.Rows[i].Cells["X"].Value);
                //puntos[i, 1] = Convert.ToDouble(dgvPuntos.Rows[i].Cells["Y"].Value);

                puntos[i, 0] = x;
                puntos[i, 1] = y;

                sumatoriaX = Math.Round((sumatoriaX + x), cantidadDeDecimales);
                sumatoriaXCuadrado = Math.Round((sumatoriaXCuadrado + (x * x)), cantidadDeDecimales);
                sumatoriaXCubo = Math.Round((sumatoriaXCubo + (x * x * x)), cantidadDeDecimales);
                sumatoriaXCuarta = Math.Round((sumatoriaXCuarta + (x * x * x * x)), cantidadDeDecimales);
                sumatoriaLogaritmoX = Math.Round((sumatoriaLogaritmoX + Math.Log(x)), cantidadDeDecimales);
                sumatoriaY = Math.Round((sumatoriaY + y), cantidadDeDecimales);
                sumatoriaYCuadrado = Math.Round((sumatoriaYCuadrado + (y * y)), cantidadDeDecimales);
                sumatoriaXY = Math.Round((sumatoriaXY + (x * y)), cantidadDeDecimales);
                sumatoriaXLogaritmoY = Math.Round((sumatoriaXLogaritmoY + (x * Math.Log(y))), cantidadDeDecimales);
                sumatoriaXConYCuadrado = Math.Round((sumatoriaXConYCuadrado + (x * (y * y))), cantidadDeDecimales);
                sumatoriaLogaritmoY = Math.Round((sumatoriaLogaritmoY + Math.Log(y)), cantidadDeDecimales);

                sumatoriaXCuadradoY = Math.Round((sumatoriaXCuadradoY + ((x * x) * Math.Log(y))), cantidadDeDecimales);
                sumatoriaXDivididoY = Math.Round((sumatoriaXDivididoY + (x / y)), cantidadDeDecimales);
                sumatoriaUnoDivididoY = Math.Round((sumatoriaUnoDivididoY + (1 / y)), cantidadDeDecimales);
                sumatoriaLogaritmoXAlCuadrado = Math.Round((sumatoriaLogaritmoXAlCuadrado + Math.Pow(Math.Log(x), 2)), cantidadDeDecimales);
                sumatoriaLogaritmoXLogaritmoY = Math.Round((sumatoriaLogaritmoXLogaritmoY + (Math.Log(x) * Math.Log(y))), cantidadDeDecimales);

                //cantidadDePuntos += 1;

                //MessageBox.Show(puntos[i, 0] + " " + puntos[i, 1]);
            }

        }

        private void generarFunciones()
        {
            funcionLineal = new Funcion_Lineal();
            funcionCuadratica = new Funcion_Cuadratica();
            funcionExponencial = new Funcion_Exponencial();
            funcionPotencial = new Funcion_Potencial();
            funcionHiperbolica = new Funcion_Hiperbolica();
        }

        //Metodo que calcula los valores de las sumatorias (no funciona)

        private void calcularValores()
        {
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

        //Metodo debug de sumatorias

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
                "sumatoriaXCuadradoY: " + sumatoriaXCuadradoY + "\n" +
                "sumatoriaXDivididoY: " + sumatoriaXDivididoY + "\n" +
                "sumatoriaUnoDivididoY: " + sumatoriaUnoDivididoY + "\n" +
                "sumatoriaLogaritmoXAlCuadrado: " + sumatoriaLogaritmoXAlCuadrado + "\n" +
                "sumatoriaLogaritmoXLogaritmoY: " + sumatoriaLogaritmoXLogaritmoY + "\n" +
                "cantidadDePuntos: " + cantidadDePuntos, "Calculos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Prueba de funcion exponencial(OK)

            MessageBox.Show("coeficiente a: " + funcionExponencial.getCoeficienteA() + "\n" +
                "coeficiente b: " + funcionExponencial.getCoeficienteB(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Prueba de funcion cuadratica(OK)

            MessageBox.Show("coeficiente a: " + funcionCuadratica.getCoeficienteA() + "\n" +
                "coeficiente b: " + funcionCuadratica.getCoeficienteB() + "\n" +
                "coeficiente c: " + funcionCuadratica.getCoeficienteC(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Prueba de funcion lineal(OK)
            MessageBox.Show("coeficiente a: " + funcionLineal.getCoeficienteA() + "\n" +
                "coeficiente b: " + funcionLineal.getCoeficienteB(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Prueba de funcion potencial(OK)

            MessageBox.Show("coeficiente a: " + funcionPotencial.getCoeficienteA() + "\n" +
                "coeficiente b: " + funcionPotencial.getCoeficienteB(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Prueba de funcion hiperbolica(OK)

            MessageBox.Show("coeficiente a: " + funcionHiperbolica.getCoeficienteA() + "\n" +
                "coeficiente b: " + funcionHiperbolica.getCoeficienteB(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
