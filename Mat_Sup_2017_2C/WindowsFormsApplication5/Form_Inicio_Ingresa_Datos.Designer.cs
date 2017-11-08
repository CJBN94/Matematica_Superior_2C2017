namespace WindowsFormsApplication5
{
    partial class Form_Inicio_Ingresa_Datos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFijarDecimales = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.txtCantidadDeDecimales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnQuitarPunto = new System.Windows.Forms.Button();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCoordenadaY = new System.Windows.Forms.TextBox();
            this.txtCoordenadaX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(613, 38);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFijarDecimales
            // 
            this.btnFijarDecimales.Location = new System.Drawing.Point(476, 38);
            this.btnFijarDecimales.Name = "btnFijarDecimales";
            this.btnFijarDecimales.Size = new System.Drawing.Size(94, 23);
            this.btnFijarDecimales.TabIndex = 42;
            this.btnFijarDecimales.Text = "Fijar Decimales";
            this.btnFijarDecimales.UseVisualStyleBackColor = true;
            this.btnFijarDecimales.Click += new System.EventHandler(this.btnFijarDecimales_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ingrese los puntos que desea utilizar para la aproximación";
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(298, 443);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(196, 32);
            this.btnIngresarDatos.TabIndex = 40;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // txtCantidadDeDecimales
            // 
            this.txtCantidadDeDecimales.Location = new System.Drawing.Point(187, 38);
            this.txtCantidadDeDecimales.Name = "txtCantidadDeDecimales";
            this.txtCantidadDeDecimales.Size = new System.Drawing.Size(243, 20);
            this.txtCantidadDeDecimales.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cantidad De Decimales :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "¿Con qué cantidad de decimales desea trabajar?";
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Location = new System.Drawing.Point(613, 349);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(94, 23);
            this.btnQuitarTodos.TabIndex = 36;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnQuitarPunto
            // 
            this.btnQuitarPunto.Location = new System.Drawing.Point(613, 303);
            this.btnQuitarPunto.Name = "btnQuitarPunto";
            this.btnQuitarPunto.Size = new System.Drawing.Size(94, 23);
            this.btnQuitarPunto.TabIndex = 35;
            this.btnQuitarPunto.Text = "Quitar Punto";
            this.btnQuitarPunto.UseVisualStyleBackColor = true;
            this.btnQuitarPunto.Click += new System.EventHandler(this.btnQuitarPunto_Click);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Location = new System.Drawing.Point(613, 255);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(94, 23);
            this.btnAgregarPunto.TabIndex = 34;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvPuntos.Location = new System.Drawing.Point(60, 199);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(532, 228);
            this.dgvPuntos.TabIndex = 33;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Puntos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Punto";
            // 
            // txtCoordenadaY
            // 
            this.txtCoordenadaY.Location = new System.Drawing.Point(187, 143);
            this.txtCoordenadaY.Name = "txtCoordenadaY";
            this.txtCoordenadaY.Size = new System.Drawing.Size(243, 20);
            this.txtCoordenadaY.TabIndex = 30;
            // 
            // txtCoordenadaX
            // 
            this.txtCoordenadaX.Location = new System.Drawing.Point(187, 111);
            this.txtCoordenadaX.Name = "txtCoordenadaX";
            this.txtCoordenadaX.Size = new System.Drawing.Size(243, 20);
            this.txtCoordenadaX.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Coordenada Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Coordenada X :";
            // 
            // Form_Inicio_Ingresa_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 487);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFijarDecimales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.txtCantidadDeDecimales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnQuitarPunto);
            this.Controls.Add(this.btnAgregarPunto);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoordenadaY);
            this.Controls.Add(this.txtCoordenadaX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Inicio_Ingresa_Datos";
            this.Text = "Ingreso De Puntos";
            this.Load += new System.EventHandler(this.Form_Inicio_Ingresa_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFijarDecimales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.TextBox txtCantidadDeDecimales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnQuitarPunto;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCoordenadaY;
        private System.Windows.Forms.TextBox txtCoordenadaX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}