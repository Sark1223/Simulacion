namespace Generador_de_numeros___Simulacion
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new ns1.BunifuCustomLabel();
            this.btnCerrar = new ns1.BunifuImageButton();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.DatosNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad_animales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Res_Ani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad_agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Res_agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.panTop.Controls.Add(this.lblTitulo);
            this.panTop.Controls.Add(this.btnCerrar);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(800, 32);
            this.panTop.TabIndex = 27;
            this.panTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTop_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(260, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HISTORIAL DE EXPERIMENTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(757, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(120)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosNo,
            this.Probabilidad_animales,
            this.Res_Ani,
            this.Probabilidad_agua,
            this.Res_agua,
            this.conclusion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.IndianRed;
            this.dgvHistorial.Location = new System.Drawing.Point(24, 58);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 100;
            this.dgvHistorial.Size = new System.Drawing.Size(755, 365);
            this.dgvHistorial.TabIndex = 29;
            // 
            // DatosNo
            // 
            this.DatosNo.HeaderText = "Datos de numeros";
            this.DatosNo.Name = "DatosNo";
            this.DatosNo.ReadOnly = true;
            this.DatosNo.Width = 147;
            // 
            // Probabilidad_animales
            // 
            this.Probabilidad_animales.HeaderText = "Probabilidad en analisis animales";
            this.Probabilidad_animales.Name = "Probabilidad_animales";
            this.Probabilidad_animales.ReadOnly = true;
            this.Probabilidad_animales.Width = 192;
            // 
            // Res_Ani
            // 
            this.Res_Ani.HeaderText = "Resultado del analisis en ANIMALES";
            this.Res_Ani.Name = "Res_Ani";
            this.Res_Ani.ReadOnly = true;
            this.Res_Ani.Width = 196;
            // 
            // Probabilidad_agua
            // 
            this.Probabilidad_agua.HeaderText = "Probabilidad en analisis de AGUA";
            this.Probabilidad_agua.Name = "Probabilidad_agua";
            this.Probabilidad_agua.ReadOnly = true;
            this.Probabilidad_agua.Width = 192;
            // 
            // Res_agua
            // 
            this.Res_agua.HeaderText = "Resultado en analisis de Agua";
            this.Res_agua.Name = "Res_agua";
            this.Res_agua.ReadOnly = true;
            this.Res_agua.Width = 172;
            // 
            // conclusion
            // 
            this.conclusion.HeaderText = "Conclusion";
            this.conclusion.Name = "conclusion";
            this.conclusion.ReadOnly = true;
            this.conclusion.Width = 109;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(148)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 23);
            this.panel1.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(228, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(354, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "EQUIPO: Dinamita.   @Karla Santos @Edwin Villada";
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorial";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panTop;
        public ns1.BunifuCustomLabel lblTitulo;
        public ns1.BunifuImageButton btnCerrar;
        public System.Windows.Forms.DataGridView dgvHistorial;
        public System.Windows.Forms.DataGridViewTextBoxColumn DatosNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad_animales;
        public System.Windows.Forms.DataGridViewTextBoxColumn Res_Ani;
        public System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad_agua;
        public System.Windows.Forms.DataGridViewTextBoxColumn Res_agua;
        public System.Windows.Forms.DataGridViewTextBoxColumn conclusion;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
    }
}