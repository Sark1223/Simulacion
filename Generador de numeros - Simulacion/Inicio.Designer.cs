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
            this.txtSemilla = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txtA = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtC = new ns1.BunifuMaterialTextbox();
            this.txtM = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.lblSemilla.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.ForeColor = System.Drawing.Color.Black;
            this.lblSemilla.Location = new System.Drawing.Point(143, 181);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(74, 29);
            this.lblSemilla.TabIndex = 2;
            this.lblSemilla.Text = "Semilla:";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSemilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSemilla.HintForeColor = System.Drawing.Color.Empty;
            this.txtSemilla.HintText = "";
            this.txtSemilla.isPassword = false;
            this.txtSemilla.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtSemilla.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSemilla.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSemilla.LineThickness = 3;
            this.txtSemilla.Location = new System.Drawing.Point(214, 157);
            this.txtSemilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(115, 44);
            this.txtSemilla.TabIndex = 3;
            this.txtSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSemilla.OnValueChanged += new System.EventHandler(this.txtSemilla_OnValueChanged);
            this.txtSemilla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSemilla_KeyDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(346, 181);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(26, 29);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtA.HintForeColor = System.Drawing.Color.Empty;
            this.txtA.HintText = "";
            this.txtA.isPassword = false;
            this.txtA.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtA.LineIdleColor = System.Drawing.Color.Gray;
            this.txtA.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtA.LineThickness = 3;
            this.txtA.Location = new System.Drawing.Point(379, 157);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(115, 44);
            this.txtA.TabIndex = 5;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtA.OnValueChanged += new System.EventHandler(this.txtA_OnValueChanged);
            this.txtA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuMaterialTextbox1_KeyDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(110, 238);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(25, 29);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "c:";
            this.toolTip1.SetToolTip(this.bunifuCustomLabel2, "Sugerencia: \r\nIngresar un valor\r\ndivisble entre 200 con un residuo\r\nigual a 21\r\n\r" +
        "\nEjemplo:\r\nresiduo de 221/200 = 21\r\nresiduo de 421/200 = 21");
            // 
            // txtC
            // 
            this.txtC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtC.HintForeColor = System.Drawing.Color.Empty;
            this.txtC.HintText = "";
            this.txtC.isPassword = false;
            this.txtC.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtC.LineThickness = 3;
            this.txtC.Location = new System.Drawing.Point(132, 214);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(115, 44);
            this.txtC.TabIndex = 7;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtC.OnValueChanged += new System.EventHandler(this.txtC_OnValueChanged);
            // 
            // txtM
            // 
            this.txtM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtM.HintForeColor = System.Drawing.Color.Empty;
            this.txtM.HintText = "";
            this.txtM.isPassword = false;
            this.txtM.LineFocusedColor = System.Drawing.Color.Teal;
            this.txtM.LineIdleColor = System.Drawing.Color.Gray;
            this.txtM.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtM.LineThickness = 3;
            this.txtM.Location = new System.Drawing.Point(284, 214);
            this.txtM.Margin = new System.Windows.Forms.Padding(4);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(115, 44);
            this.txtM.TabIndex = 8;
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtM.OnValueChanged += new System.EventHandler(this.txtM_OnValueChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(251, 238);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(32, 29);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "m:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(530, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 53);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 626);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.lblSemilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuMaterialTextbox txtSemilla;
        private ns1.BunifuCustomLabel lblSemilla;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox txtM;
        private ns1.BunifuMaterialTextbox txtC;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMaterialTextbox txtA;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ns1.BunifuImageButton bunifuImageButton1;
    }
}