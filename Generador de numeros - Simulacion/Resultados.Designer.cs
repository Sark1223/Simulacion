namespace Generador_de_numeros___Simulacion
{
    partial class Resultados
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
            this.dgvResAni = new System.Windows.Forms.DataGridView();
            this.dgvResAgua = new System.Windows.Forms.DataGridView();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResAni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResAgua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResAni
            // 
            this.dgvResAni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResAni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResAni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Animal,
            this.Salud});
            this.dgvResAni.Location = new System.Drawing.Point(40, 20);
            this.dgvResAni.Name = "dgvResAni";
            this.dgvResAni.RowHeadersVisible = false;
            this.dgvResAni.Size = new System.Drawing.Size(434, 442);
            this.dgvResAni.TabIndex = 0;
            // 
            // dgvResAgua
            // 
            this.dgvResAgua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResAgua.Location = new System.Drawing.Point(655, 252);
            this.dgvResAgua.Name = "dgvResAgua";
            this.dgvResAgua.Size = new System.Drawing.Size(235, 184);
            this.dgvResAgua.TabIndex = 1;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "Animal";
            this.Animal.Name = "Animal";
            this.Animal.Width = 63;
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Salud";
            this.Salud.Name = "Salud";
            this.Salud.Width = 59;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 542);
            this.Controls.Add(this.dgvResAgua);
            this.Controls.Add(this.dgvResAni);
            this.Name = "Resultados";
            this.Text = "Resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResAni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResAgua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvResAni;
        public System.Windows.Forms.DataGridView dgvResAgua;
        public System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        public System.Windows.Forms.DataGridViewTextBoxColumn Salud;
    }
}