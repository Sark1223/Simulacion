namespace Generador_de_numeros___Simulacion
{
    partial class frmGenerador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tablaResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.LightCoral;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(167, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(528, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GENERADOR DE NUMEROS PSEUDO-ALEATORIOS";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Location = new System.Drawing.Point(637, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 24);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "&GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tablaResultados
            // 
            this.tablaResultados.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaResultados.Location = new System.Drawing.Point(45, 93);
            this.tablaResultados.Multiline = true;
            this.tablaResultados.Name = "tablaResultados";
            this.tablaResultados.Size = new System.Drawing.Size(706, 320);
            this.tablaResultados.TabIndex = 3;
            // 
            // frmGenerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaResultados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmGenerador";
            this.Text = "Metodo congruencial mixto";
            this.Load += new System.EventHandler(this.frmGenerador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tablaResultados;
    }
}

