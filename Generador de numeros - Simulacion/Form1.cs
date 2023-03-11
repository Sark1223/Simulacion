using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_numeros___Simulacion
{
    public partial class frmGenerador : Form
    {
        public frmGenerador()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //, a = 9, c = 13, m = 32, N;
            //float Ri;
            int x0 = 8;
            Semilla semilla = new Semilla();
            List<Semilla> lista = new List<Semilla>();
           
            for(int i =0; i<10; i++)
            {
                semilla.N = i + 1;
                semilla.Xn = x0;
                semilla.a = 9;
                semilla.c = 13;
                semilla.m = 32;
                semilla.Res = (semilla.a * semilla.Xn) + semilla.c;
                semilla.modulo = semilla.Res % semilla.m;
            }

        }
    }
}
