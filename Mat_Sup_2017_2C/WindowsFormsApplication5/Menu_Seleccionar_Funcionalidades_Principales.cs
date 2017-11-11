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
    public partial class Menu_Seleccionar_Funcionalidades_Principales : Form
    {
        public Menu_Seleccionar_Funcionalidades_Principales()
        {
            InitializeComponent();
        }

        private void btnCompararAproximaciones_Click(object sender, EventArgs e)
        {
            Form_Comparacion_De_Aproximaciones f = new Form_Comparacion_De_Aproximaciones();
            f.Visible = true;
        }

        private void btnAproximarFuncion_Click(object sender, EventArgs e)
        {
            Menu_Seleccionar_Funcion_Aproximante f = new Menu_Seleccionar_Funcion_Aproximante();
            f.Visible = true;
        }
    }
}
