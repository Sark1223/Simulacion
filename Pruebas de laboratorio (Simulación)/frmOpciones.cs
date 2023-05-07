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

        bool cerrar = false;

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
            frmProblema.ShowDialog();
            if(cerrar = true)
            {
                this.Close();
            }

        }
    }
}
