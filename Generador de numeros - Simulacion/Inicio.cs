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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void txtSemilla_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSemilla_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Para mejorar el funcionamiento del programa\n" +
                    "el numero ingresado debe ser una valor\n" +
                    "en la forma (10^x) + 1\n\n" +
                    "Ejemplo: \n" +
                    "10^1 + 1 = 11, 10^2 + 1 = 101, ...etc");
            }
        }
    }
}
