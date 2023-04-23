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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tblPseudo = new ns1.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panEncabezado = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrastrar1 = new ns1.BunifuDragControl(this.components);
            this.arrastrar2 = new ns1.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblPseudo)).BeginInit();
            this.panEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(104, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUMEROS PSEUDO-ALEATORIOS";
            // 
            // tblPseudo
            // 
            this.tblPseudo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(158)))), ((int)(((byte)(245)))));
            this.tblPseudo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblPseudo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.tblPseudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblPseudo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.tblPseudo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPseudo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tblPseudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPseudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tblPseudo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tblPseudo.DoubleBuffered = true;
            this.tblPseudo.EnableHeadersVisualStyles = false;
            this.tblPseudo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblPseudo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(94)))), ((int)(((byte)(191)))));
            this.tblPseudo.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.tblPseudo.Location = new System.Drawing.Point(132, 115);
            this.tblPseudo.Margin = new System.Windows.Forms.Padding(1);
            this.tblPseudo.Name = "tblPseudo";
            this.tblPseudo.ReadOnly = true;
            this.tblPseudo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPseudo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tblPseudo.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.tblPseudo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tblPseudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblPseudo.Size = new System.Drawing.Size(250, 299);
            this.tblPseudo.TabIndex = 4;
            this.tblPseudo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPseudo_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Location = new System.Drawing.Point(41, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 48);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(401, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 90);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(122, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 42);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Location = new System.Drawing.Point(122, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(41, 37);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaGreen;
            this.panel7.Location = new System.Drawing.Point(386, 217);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(55, 48);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaGreen;
            this.panel8.Location = new System.Drawing.Point(27, 115);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(25, 24);
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
            this.panEncabezado.Size = new System.Drawing.Size(537, 38);
            this.panEncabezado.TabIndex = 14;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Generador_de_numeros___Simulacion.Properties.Resources.icons8_cerrar_ventana_100;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(491, 3);
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
            this.pictureBox1.Location = new System.Drawing.Point(411, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // frmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(537, 450);
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
            this.Name = "frmNumeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo congruencial mixto";
            this.Load += new System.EventHandler(this.frmGenerador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPseudo)).EndInit();
            this.panEncabezado.ResumeLayout(false);
            this.panEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

