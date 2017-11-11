namespace WindowsFormsApplication5
{
    partial class Form_Comparacion_De_Aproximaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMejorAproximacion = new System.Windows.Forms.Button();
            this.dgvComparacion = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lineal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuadrática = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiperbólica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exponencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorFuncionLineal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorFuncionCuadratica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorFuncionHiperbolica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorFuncionPotencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorFuncionExponencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMejorAproximacion
            // 
            this.btnMejorAproximacion.Location = new System.Drawing.Point(287, 433);
            this.btnMejorAproximacion.Name = "btnMejorAproximacion";
            this.btnMejorAproximacion.Size = new System.Drawing.Size(205, 23);
            this.btnMejorAproximacion.TabIndex = 19;
            this.btnMejorAproximacion.Text = "Mostrar Mejor Aproximacion";
            this.btnMejorAproximacion.UseVisualStyleBackColor = true;
            // 
            // dgvComparacion
            // 
            this.dgvComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Xi,
            this.Yi,
            this.Lineal,
            this.Cuadrática,
            this.Hiperbólica,
            this.Potencial,
            this.Exponencial,
            this.ErrorFuncionLineal,
            this.ErrorFuncionCuadratica,
            this.ErrorFuncionHiperbolica,
            this.ErrorFuncionPotencial,
            this.ErrorFuncionExponencial});
            this.dgvComparacion.Location = new System.Drawing.Point(12, 12);
            this.dgvComparacion.Name = "dgvComparacion";
            this.dgvComparacion.ReadOnly = true;
            this.dgvComparacion.Size = new System.Drawing.Size(797, 405);
            this.dgvComparacion.TabIndex = 20;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "Yi";
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            // 
            // Lineal
            // 
            this.Lineal.HeaderText = "Lineal";
            this.Lineal.Name = "Lineal";
            this.Lineal.ReadOnly = true;
            // 
            // Cuadrática
            // 
            this.Cuadrática.HeaderText = "Cuadrática";
            this.Cuadrática.Name = "Cuadrática";
            this.Cuadrática.ReadOnly = true;
            // 
            // Hiperbólica
            // 
            this.Hiperbólica.HeaderText = "Hiperbólica";
            this.Hiperbólica.Name = "Hiperbólica";
            this.Hiperbólica.ReadOnly = true;
            // 
            // Potencial
            // 
            this.Potencial.HeaderText = "Potencial";
            this.Potencial.Name = "Potencial";
            this.Potencial.ReadOnly = true;
            // 
            // Exponencial
            // 
            this.Exponencial.HeaderText = "Exponencial";
            this.Exponencial.Name = "Exponencial";
            this.Exponencial.ReadOnly = true;
            // 
            // ErrorFuncionLineal
            // 
            this.ErrorFuncionLineal.HeaderText = "Error Funcion Lineal";
            this.ErrorFuncionLineal.Name = "ErrorFuncionLineal";
            this.ErrorFuncionLineal.ReadOnly = true;
            // 
            // ErrorFuncionCuadratica
            // 
            this.ErrorFuncionCuadratica.HeaderText = "Error Funcion Cuadratica";
            this.ErrorFuncionCuadratica.Name = "ErrorFuncionCuadratica";
            this.ErrorFuncionCuadratica.ReadOnly = true;
            // 
            // ErrorFuncionHiperbolica
            // 
            this.ErrorFuncionHiperbolica.HeaderText = "Error Funcion Hiperbolica";
            this.ErrorFuncionHiperbolica.Name = "ErrorFuncionHiperbolica";
            this.ErrorFuncionHiperbolica.ReadOnly = true;
            // 
            // ErrorFuncionPotencial
            // 
            this.ErrorFuncionPotencial.HeaderText = "Error Funcion Potencial";
            this.ErrorFuncionPotencial.Name = "ErrorFuncionPotencial";
            this.ErrorFuncionPotencial.ReadOnly = true;
            // 
            // ErrorFuncionExponencial
            // 
            this.ErrorFuncionExponencial.HeaderText = "Error Funcion Exponencial";
            this.ErrorFuncionExponencial.Name = "ErrorFuncionExponencial";
            this.ErrorFuncionExponencial.ReadOnly = true;
            // 
            // Form_Comparacion_De_Aproximaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 468);
            this.Controls.Add(this.dgvComparacion);
            this.Controls.Add(this.btnMejorAproximacion);
            this.Name = "Form_Comparacion_De_Aproximaciones";
            this.Text = "Comparacion de funciones";
            this.Load += new System.EventHandler(this.Form_Comparacion_De_Aproximaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMejorAproximacion;
        private System.Windows.Forms.DataGridView dgvComparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lineal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuadrática;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiperbólica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exponencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorFuncionLineal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorFuncionCuadratica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorFuncionHiperbolica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorFuncionPotencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorFuncionExponencial;
    }
}