using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_numeros___Simulacion
{
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Objetos de clases
        frmNumeros frmNumeros = new frmNumeros();
        frmPruebas frmPruebas = new frmPruebas();
        frmProblema frmProblema = new frmProblema();

        public bool cer = false;

        public void RecibirNumeros(frmNumeros numeros)
        {
            frmNumeros = numeros;
        }

        public void RecibirNumerosPrueba(frmProblema numerosp)
        {
            frmProblema = numerosp;
        }

        public void RecibirValoresPrueba(frmPruebas prueba)
        {
            frmPruebas = prueba;
        }

        private void VerNumeros_Click(object sender, EventArgs e)
        {
           this.Hide();
           frmNumeros.ShowDialog();
           this.Show();
        }

        private void cmdVerPruebas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPruebas.ShowDialog();
            this.Show();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdContinuar_Click(object sender, EventArgs e)
        {
            frmProblema.panel8.Location = new Point(21, frmProblema.panel7.Location.Y + frmProblema.panel7.Height + 1);
            frmProblema.cmdHistorial.Location = new Point(838, frmProblema.panel7.Location.Y + frmProblema.panel7.Height + 49);
            frmProblema.txtAcoloidales.Focus();
            if (frmProblema.ShowDialog() == DialogResult.Retry)
            {
                frmProblema.txtAcoloidales.Focus();
                frmProblema.cmdHistorial.Location = new Point(838, frmProblema.panel7.Location.Y + frmProblema.panel7.Height + 49);
                this.Hide();
            }

        }
    }
}
