﻿using System;
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
    public partial class Menu_Post_Seleccion_De_Funcionalidad_Aproximante : Form
    {
        public Menu_Post_Seleccion_De_Funcionalidad_Aproximante()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu_Seleccionar_Funcion_Aproximante menuDeModosDeAproximacion = new Menu_Seleccionar_Funcion_Aproximante();

            Form_Inicio_Ingresa_Datos.swNubeDePuntos = 0;
            menuDeModosDeAproximacion.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_Seleccionar_Funcion_Aproximante menuDeModosDeAproximacion = new Menu_Seleccionar_Funcion_Aproximante();

            Form_Inicio_Ingresa_Datos.swNubeDePuntos = 1;
            menuDeModosDeAproximacion.Visible = true;
        }
    }
}
