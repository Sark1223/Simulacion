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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            cmdIniciar.Parent = pbIniciar;
            cmdIniciar.BackColor = Color.Transparent;
            cmdCerrarPantalla.Parent = pbIniciar;
            cmdCerrarPantalla.BackColor = Color.Transparent;
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.ShowDialog();
        }

        private void cmdCerrarPantalla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
