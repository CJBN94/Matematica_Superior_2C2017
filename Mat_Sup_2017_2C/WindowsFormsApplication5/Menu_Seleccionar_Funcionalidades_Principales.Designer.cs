namespace WindowsFormsApplication5
{
    partial class Menu_Seleccionar_Funcionalidades_Principales
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
            this.btnAproximarFuncion = new System.Windows.Forms.Button();
            this.btnCompararAproximaciones = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAproximarFuncion
            // 
            this.btnAproximarFuncion.Location = new System.Drawing.Point(12, 86);
            this.btnAproximarFuncion.Name = "btnAproximarFuncion";
            this.btnAproximarFuncion.Size = new System.Drawing.Size(288, 61);
            this.btnAproximarFuncion.TabIndex = 11;
            this.btnAproximarFuncion.Text = "Aproximar Con Una Función";
            this.btnAproximarFuncion.UseVisualStyleBackColor = true;
            this.btnAproximarFuncion.Click += new System.EventHandler(this.btnAproximarFuncion_Click);
            // 
            // btnCompararAproximaciones
            // 
            this.btnCompararAproximaciones.Location = new System.Drawing.Point(12, 183);
            this.btnCompararAproximaciones.Name = "btnCompararAproximaciones";
            this.btnCompararAproximaciones.Size = new System.Drawing.Size(289, 61);
            this.btnCompararAproximaciones.TabIndex = 16;
            this.btnCompararAproximaciones.Text = "Comparar Aproximaciones";
            this.btnCompararAproximaciones.UseVisualStyleBackColor = true;
            this.btnCompararAproximaciones.Click += new System.EventHandler(this.btnCompararAproximaciones_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(11, 277);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(289, 61);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "¿Qué desea hacer?";
            // 
            // Menu_Seleccionar_Funcionalidades_Principales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCompararAproximaciones);
            this.Controls.Add(this.btnAproximarFuncion);
            this.Name = "Menu_Seleccionar_Funcionalidades_Principales";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAproximarFuncion;
        private System.Windows.Forms.Button btnCompararAproximaciones;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
    }
}