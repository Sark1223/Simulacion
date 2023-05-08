namespace Generador_de_numeros___Simulacion
{
    partial class frmNumeros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumeros));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tblPseudo = new ns1.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arrastrar1 = new ns1.BunifuDragControl(this.components);
            this.arrastrar2 = new ns1.BunifuDragControl(this.components);
            this.redondear1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.lblSemilla = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblPseudo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(45, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUMEROS PSEUDO-ALEATORIOS";
            // 
            // tblPseudo
            // 
            this.tblPseudo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(158)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tblPseudo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblPseudo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.tblPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblPseudo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tblPseudo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPseudo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPseudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPseudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tblPseudo.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblPseudo.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblPseudo.DoubleBuffered = true;
            this.tblPseudo.EnableHeadersVisualStyles = false;
            this.tblPseudo.GridColor = System.Drawing.Color.Purple;
            this.tblPseudo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(191)))));
            this.tblPseudo.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.tblPseudo.Location = new System.Drawing.Point(15, 49);
            this.tblPseudo.Margin = new System.Windows.Forms.Padding(1);
            this.tblPseudo.Name = "tblPseudo";
            this.tblPseudo.ReadOnly = true;
            this.tblPseudo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPseudo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblPseudo.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tblPseudo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblPseudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblPseudo.Size = new System.Drawing.Size(250, 387);
            this.tblPseudo.TabIndex = 4;
            this.tblPseudo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPseudo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ri";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(305, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 59);
            this.panel1.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(206)))), ((int)(((byte)(158)))));
            this.panel9.Location = new System.Drawing.Point(76, 44);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(16, 15);
            this.panel9.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(374, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 83);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(366, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 42);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.panel15);
            this.panel6.Location = new System.Drawing.Point(348, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(45, 37);
            this.panel6.TabIndex = 11;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(206)))), ((int)(((byte)(158)))));
            this.panel15.Location = new System.Drawing.Point(26, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(19, 37);
            this.panel15.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaGreen;
            this.panel7.Location = new System.Drawing.Point(348, 222);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(49, 48);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaGreen;
            this.panel8.Location = new System.Drawing.Point(283, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(47, 44);
            this.panel8.TabIndex = 13;
            // 
            // panEncabezado
            // 
            this.panEncabezado.BackColor = System.Drawing.Color.DarkGreen;
            this.panEncabezado.Controls.Add(this.bunifuImageButton1);
            this.panEncabezado.Controls.Add(this.lblTitulo);
            this.panEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panEncabezado.Name = "panEncabezado";
            this.panEncabezado.Size = new System.Drawing.Size(472, 38);
            this.panEncabezado.TabIndex = 14;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Generador_de_numeros___Simulacion.Properties.Resources.icons8_cerrar_ventana_100;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(432, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Generador_de_numeros___Simulacion.Properties.Resources.dinosaurio;
            this.pictureBox1.Location = new System.Drawing.Point(283, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // arrastrar1
            // 
            this.arrastrar1.Fixed = true;
            this.arrastrar1.Horizontal = true;
            this.arrastrar1.TargetControl = this.panEncabezado;
            this.arrastrar1.Vertical = true;
            // 
            // arrastrar2
            // 
            this.arrastrar2.Fixed = true;
            this.arrastrar2.Horizontal = true;
            this.arrastrar2.TargetControl = this.lblTitulo;
            this.arrastrar2.Vertical = true;
            // 
            // redondear1
            // 
            this.redondear1.ElipseRadius = 10;
            this.redondear1.TargetControl = this.tblPseudo;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.tblPseudo;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(394, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 15);
            this.panel3.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(317, 147);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(25, 24);
            this.panel11.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(206)))), ((int)(((byte)(158)))));
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(13, 14);
            this.panel12.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGreen;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(469, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(3, 412);
            this.panel10.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkGreen;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 38);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2, 412);
            this.panel13.TabIndex = 18;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkGreen;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(2, 447);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(467, 3);
            this.panel14.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(206)))), ((int)(((byte)(158)))));
            this.panel5.Location = new System.Drawing.Point(366, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(31, 19);
            this.panel5.TabIndex = 20;
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.Color.Ivory;
            this.txtM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtM.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.ForeColor = System.Drawing.Color.DimGray;
            this.txtM.Location = new System.Drawing.Point(291, 128);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(92, 23);
            this.txtM.TabIndex = 24;
            this.txtM.Text = "17001";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.Ivory;
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.DimGray;
            this.txtC.Location = new System.Drawing.Point(288, 230);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(92, 23);
            this.txtC.TabIndex = 23;
            this.txtC.Text = "221";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.Ivory;
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.DimGray;
            this.txtA.Location = new System.Drawing.Point(291, 177);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(92, 23);
            this.txtA.TabIndex = 22;
            this.txtA.Text = "101";
            // 
            // txtSemilla
            // 
            this.txtSemilla.BackColor = System.Drawing.Color.Ivory;
            this.txtSemilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemilla.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.ForeColor = System.Drawing.Color.DimGray;
            this.txtSemilla.Location = new System.Drawing.Point(291, 76);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.ReadOnly = true;
            this.txtSemilla.Size = new System.Drawing.Size(94, 23);
            this.txtSemilla.TabIndex = 21;
            this.txtSemilla.Text = "12";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(290, 108);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(26, 20);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "m:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(290, 207);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(21, 20);
            this.bunifuCustomLabel2.TabIndex = 27;
            this.bunifuCustomLabel2.Text = "c:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(289, 154);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(22, 20);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "a:";
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.ForeColor = System.Drawing.Color.White;
            this.lblSemilla.Location = new System.Drawing.Point(292, 53);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(64, 20);
            this.lblSemilla.TabIndex = 25;
            this.lblSemilla.Text = "Semilla:";
            // 
            // frmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panEncabezado);
            this.Controls.Add(this.tblPseudo);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo congruencial mixto";
            this.Load += new System.EventHandler(this.frmGenerador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPseudo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panEncabezado.ResumeLayout(false);
            this.panEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        public ns1.BunifuCustomDataGrid tblPseudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panEncabezado;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ns1.BunifuDragControl arrastrar1;
        private ns1.BunifuDragControl arrastrar2;
        private ns1.BunifuElipse redondear1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtSemilla;
        public System.Windows.Forms.TextBox txtM;
        public System.Windows.Forms.TextBox txtC;
        public System.Windows.Forms.TextBox txtA;
        public ns1.BunifuCustomLabel bunifuCustomLabel3;
        public ns1.BunifuCustomLabel bunifuCustomLabel2;
        public ns1.BunifuCustomLabel bunifuCustomLabel1;
        public ns1.BunifuCustomLabel lblSemilla;
    }
}

