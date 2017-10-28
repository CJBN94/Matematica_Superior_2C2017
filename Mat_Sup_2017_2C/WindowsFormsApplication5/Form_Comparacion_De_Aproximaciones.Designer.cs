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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lineal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuadrática = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiperbólica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exponencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datos,
            this.modelos,
            this.Error});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(748, 24);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Datos";
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            // 
            // modelos
            // 
            this.modelos.HeaderText = "Modelos Aproximantes";
            this.modelos.Name = "modelos";
            this.modelos.ReadOnly = true;
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Xi,
            this.Yi,
            this.Lineal,
            this.Cuadrática,
            this.Hiperbólica,
            this.Potencial,
            this.Exponencial});
            this.dataGridView2.Location = new System.Drawing.Point(13, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(747, 124);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Mostrar Mejor Aproximacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lineal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuadrática;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiperbólica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exponencial;
        private System.Windows.Forms.Button button1;
    }
}