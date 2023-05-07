namespace Generador_de_numeros___Simulacion
{
    partial class frmOpciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpciones));
            this.panTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.bordeForma = new ns1.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesajeDatos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPruevasSuperadas = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new ns1.BunifuThinButton2();
            this.cmdContinuar = new ns1.BunifuThinButton2();
            this.cmdVerPruebas = new ns1.BunifuThinButton2();
            this.cmdVerNumeros = new ns1.BunifuThinButton2();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(490, 28);
            this.panTop.TabIndex = 21;
            this.panTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(456, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bordeForma
            // 
            this.bordeForma.ElipseRadius = 10;
            this.bordeForma.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numeros pseudoaleatorios generados exitosamente.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMesajeDatos
            // 
            this.txtMesajeDatos.BackColor = System.Drawing.SystemColors.Control;
            this.txtMesajeDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMesajeDatos.Enabled = false;
            this.txtMesajeDatos.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txtMesajeDatos.Location = new System.Drawing.Point(39, 69);
            this.txtMesajeDatos.Multiline = true;
            this.txtMesajeDatos.Name = "txtMesajeDatos";
            this.txtMesajeDatos.ReadOnly = true;
            this.txtMesajeDatos.Size = new System.Drawing.Size(403, 44);
            this.txtMesajeDatos.TabIndex = 23;
            this.txtMesajeDatos.Text = "Los numeros que se generaron pueden generar resultados ambiguos.";
            this.txtMesajeDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesajeDatos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 5);
            this.panel1.TabIndex = 28;
            // 
            // txtPruevasSuperadas
            // 
            this.txtPruevasSuperadas.BackColor = System.Drawing.SystemColors.Control;
            this.txtPruevasSuperadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPruevasSuperadas.Enabled = false;
            this.txtPruevasSuperadas.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            this.txtPruevasSuperadas.Location = new System.Drawing.Point(46, 116);
            this.txtPruevasSuperadas.Name = "txtPruevasSuperadas";
            this.txtPruevasSuperadas.ReadOnly = true;
            this.txtPruevasSuperadas.Size = new System.Drawing.Size(403, 22);
            this.txtPruevasSuperadas.TabIndex = 29;
            this.txtPruevasSuperadas.Text = "No. de pruebas superadas:";
            this.txtPruevasSuperadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.ActiveBorderThickness = 1;
            this.cmdCancelar.ActiveCornerRadius = 20;
            this.cmdCancelar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(106)))), ((int)(((byte)(75)))));
            this.cmdCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdCancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(106)))), ((int)(((byte)(75)))));
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.BackgroundImage")));
            this.cmdCancelar.ButtonText = "Cancelar";
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdCancelar.IdleBorderThickness = 1;
            this.cmdCancelar.IdleCornerRadius = 20;
            this.cmdCancelar.IdleFillColor = System.Drawing.Color.White;
            this.cmdCancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(106)))), ((int)(((byte)(75)))));
            this.cmdCancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(106)))), ((int)(((byte)(75)))));
            this.cmdCancelar.Location = new System.Drawing.Point(377, 157);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(97, 37);
            this.cmdCancelar.TabIndex = 27;
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdContinuar
            // 
            this.cmdContinuar.ActiveBorderThickness = 1;
            this.cmdContinuar.ActiveCornerRadius = 20;
            this.cmdContinuar.ActiveFillColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdContinuar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.cmdContinuar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.cmdContinuar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdContinuar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdContinuar.BackgroundImage")));
            this.cmdContinuar.ButtonText = "Continuar";
            this.cmdContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContinuar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdContinuar.IdleBorderThickness = 1;
            this.cmdContinuar.IdleCornerRadius = 20;
            this.cmdContinuar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.cmdContinuar.IdleForecolor = System.Drawing.Color.White;
            this.cmdContinuar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(84)))), ((int)(((byte)(142)))));
            this.cmdContinuar.Location = new System.Drawing.Point(266, 157);
            this.cmdContinuar.Margin = new System.Windows.Forms.Padding(5);
            this.cmdContinuar.Name = "cmdContinuar";
            this.cmdContinuar.Size = new System.Drawing.Size(97, 37);
            this.cmdContinuar.TabIndex = 26;
            this.cmdContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdContinuar.Click += new System.EventHandler(this.cmdContinuar_Click);
            // 
            // cmdVerPruebas
            // 
            this.cmdVerPruebas.ActiveBorderThickness = 1;
            this.cmdVerPruebas.ActiveCornerRadius = 20;
            this.cmdVerPruebas.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(120)))), ((int)(((byte)(172)))));
            this.cmdVerPruebas.ActiveForecolor = System.Drawing.Color.White;
            this.cmdVerPruebas.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(120)))), ((int)(((byte)(172)))));
            this.cmdVerPruebas.BackColor = System.Drawing.SystemColors.Control;
            this.cmdVerPruebas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdVerPruebas.BackgroundImage")));
            this.cmdVerPruebas.ButtonText = "Ver Pruebas";
            this.cmdVerPruebas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerPruebas.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdVerPruebas.IdleBorderThickness = 1;
            this.cmdVerPruebas.IdleCornerRadius = 20;
            this.cmdVerPruebas.IdleFillColor = System.Drawing.Color.White;
            this.cmdVerPruebas.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.cmdVerPruebas.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(165)))));
            this.cmdVerPruebas.Location = new System.Drawing.Point(143, 157);
            this.cmdVerPruebas.Margin = new System.Windows.Forms.Padding(5);
            this.cmdVerPruebas.Name = "cmdVerPruebas";
            this.cmdVerPruebas.Size = new System.Drawing.Size(107, 37);
            this.cmdVerPruebas.TabIndex = 25;
            this.cmdVerPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdVerPruebas.Click += new System.EventHandler(this.cmdVerPruebas_Click);
            // 
            // cmdVerNumeros
            // 
            this.cmdVerNumeros.ActiveBorderThickness = 1;
            this.cmdVerNumeros.ActiveCornerRadius = 20;
            this.cmdVerNumeros.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdVerNumeros.ActiveForecolor = System.Drawing.Color.White;
            this.cmdVerNumeros.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdVerNumeros.BackColor = System.Drawing.SystemColors.Control;
            this.cmdVerNumeros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdVerNumeros.BackgroundImage")));
            this.cmdVerNumeros.ButtonText = "Ver Números";
            this.cmdVerNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerNumeros.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdVerNumeros.IdleBorderThickness = 1;
            this.cmdVerNumeros.IdleCornerRadius = 20;
            this.cmdVerNumeros.IdleFillColor = System.Drawing.Color.White;
            this.cmdVerNumeros.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cmdVerNumeros.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cmdVerNumeros.Location = new System.Drawing.Point(14, 157);
            this.cmdVerNumeros.Margin = new System.Windows.Forms.Padding(5);
            this.cmdVerNumeros.Name = "cmdVerNumeros";
            this.cmdVerNumeros.Size = new System.Drawing.Size(113, 37);
            this.cmdVerNumeros.TabIndex = 24;
            this.cmdVerNumeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdVerNumeros.Click += new System.EventHandler(this.VerNumeros_Click);
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 214);
            this.Controls.Add(this.txtPruevasSuperadas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdContinuar);
            this.Controls.Add(this.cmdVerPruebas);
            this.Controls.Add(this.cmdVerNumeros);
            this.Controls.Add(this.txtMesajeDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpciones";
            this.panTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panTop;
        public ns1.BunifuImageButton btnCerrar;
        public ns1.BunifuElipse bordeForma;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public ns1.BunifuThinButton2 cmdCancelar;
        public ns1.BunifuThinButton2 cmdContinuar;
        public ns1.BunifuThinButton2 cmdVerPruebas;
        public ns1.BunifuThinButton2 cmdVerNumeros;
        public System.Windows.Forms.TextBox txtMesajeDatos;
        public System.Windows.Forms.TextBox txtPruevasSuperadas;
    }
}