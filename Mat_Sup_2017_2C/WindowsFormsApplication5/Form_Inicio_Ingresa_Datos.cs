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
        public static double[][] puntos;
        public static double sumatoriaX;
        public static double sumatoriaY;
        public static double sumatoriaXCuadrado;
        public static double sumatoriaYCuadrado;
        public static double sumatoriaLogaritmoX;
        public static double sumatoriaLogaritmoY;
        public static double sumatoriaXY;

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
                MessageBox.Show("Coordenada X o Coordenada Y vacía. Inserte ambos valores de las coordenadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            btnQuitarTodos_Click(sender, e);
            txtCoordenadaX.Text = "";
            txtCoordenadaY.Text = "";
            this.setearEstadoInicial();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {

        }

    }
}
