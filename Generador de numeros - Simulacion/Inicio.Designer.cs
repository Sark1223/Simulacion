namespace Generador_de_numeros___Simulacion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.lblSemilla = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new ns1.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new ns1.BunifuCustomLabel();
            this.lblTitulo = new ns1.BunifuCustomLabel();
            this.btnDatos = new ns1.BunifuThinButton2();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtM = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panTop = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblSemilla.Location = new System.Drawing.Point(58, 189);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(94, 37);
            this.lblSemilla.TabIndex = 7;
            this.lblSemilla.Text = "Semilla:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(259, 189);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(34, 37);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "a:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(60, 261);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 37);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "c:";
            this.toolTip1.SetToolTip(this.bunifuCustomLabel2, "Sugerencia: \r\nIngresar un valor\r\ndivisble entre 200 con un residuo\r\nigual a 21\r\n\r" +
        "\nEjemplo:\r\nresiduo de 221/200 = 21\r\nresiduo de 421/200 = 21");
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(261, 261);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(42, 37);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "m:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.lblTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(406, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(67, 49);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(81, 58);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(166, 64);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(192, 28);
            this.lblLogo.TabIndex = 6;
            this.lblLogo.Text = "K.E. Laboratory";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(74, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 28);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "GENERADOR DE NUMEROS ";
            // 
            // btnDatos
            // 
            this.btnDatos.ActiveBorderThickness = 1;
            this.btnDatos.ActiveCornerRadius = 20;
            this.btnDatos.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDatos.ActiveForecolor = System.Drawing.Color.White;
            this.btnDatos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDatos.BackColor = System.Drawing.Color.White;
            this.btnDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatos.BackgroundImage")));
            this.btnDatos.ButtonText = "Generar # ";
            this.btnDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDatos.IdleBorderThickness = 1;
            this.btnDatos.IdleCornerRadius = 20;
            this.btnDatos.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnDatos.IdleForecolor = System.Drawing.Color.Black;
            this.btnDatos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDatos.Location = new System.Drawing.Point(144, 371);
            this.btnDatos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(149, 50);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSemilla
            // 
            this.txtSemilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSemilla.Location = new System.Drawing.Point(65, 223);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(116, 24);
            this.txtSemilla.TabIndex = 0;
            this.txtSemilla.Text = "17";
            this.txtSemilla.TextChanged += new System.EventHandler(this.txtSemilla_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Location = new System.Drawing.Point(65, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Location = new System.Drawing.Point(266, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 2);
            this.panel2.TabIndex = 10;
            // 
            // txtA
            // 
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtA.Location = new System.Drawing.Point(266, 223);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(116, 24);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "101";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel3.Location = new System.Drawing.Point(67, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 2);
            this.panel3.TabIndex = 13;
            // 
            // txtC
            // 
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtC.Location = new System.Drawing.Point(67, 296);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(116, 24);
            this.txtC.TabIndex = 2;
            this.txtC.Text = "221";
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel4.Location = new System.Drawing.Point(266, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 2);
            this.panel4.TabIndex = 14;
            // 
            // txtM
            // 
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtM.Location = new System.Drawing.Point(266, 296);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(116, 24);
            this.txtM.TabIndex = 3;
            this.txtM.Text = "17001";
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 456);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 3);
            this.panel5.TabIndex = 15;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panTop.Controls.Add(this.lblTitulo);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(445, 45);
            this.panTop.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 411);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(442, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 411);
            this.panel8.TabIndex = 18;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panTop;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Generador de numeros pseudoaleatorios con los\r\nque se realizara la simulacion del" +
    " problema";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.lblSemilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomLabel lblSemilla;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider error1;
        private ns1.BunifuImageButton btnCerrar;
        private ns1.BunifuCustomLabel lblLogo;
        private System.Windows.Forms.PictureBox Logo;
        private ns1.BunifuCustomLabel lblTitulo;
        private ns1.BunifuThinButton2 btnDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panel5;
        private ns1.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label1;
    }
}