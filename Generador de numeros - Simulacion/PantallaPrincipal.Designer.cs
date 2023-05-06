namespace Generador_de_numeros___Simulacion
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.pbIniciar = new System.Windows.Forms.PictureBox();
            this.rdFroma = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIniciar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdIniciar.Location = new System.Drawing.Point(209, 459);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(117, 44);
            this.cmdIniciar.TabIndex = 1;
            this.cmdIniciar.Text = "INICIAR";
            this.cmdIniciar.UseVisualStyleBackColor = true;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // pbIniciar
            // 
            this.pbIniciar.Image = ((System.Drawing.Image)(resources.GetObject("pbIniciar.Image")));
            this.pbIniciar.Location = new System.Drawing.Point(-3, -6);
            this.pbIniciar.Name = "pbIniciar";
            this.pbIniciar.Size = new System.Drawing.Size(576, 588);
            this.pbIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIniciar.TabIndex = 0;
            this.pbIniciar.TabStop = false;
            // 
            // rdFroma
            // 
            this.rdFroma.ElipseRadius = 10;
            this.rdFroma.TargetControl = this;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(573, 573);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.pbIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIniciar;
        private System.Windows.Forms.Button cmdIniciar;
        private ns1.BunifuElipse rdFroma;
    }
}