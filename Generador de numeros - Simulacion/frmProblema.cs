using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_numeros___Simulacion
{
    public partial class frmProblema : Form
    {   
        public frmProblema()
        {
            InitializeComponent();
        }

        frmIntervalos frmIntervalos = new frmIntervalos();

        //variables de animales
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;

        //variables de aguas
        float Agua_coloidales, Agua_mercurio, Agua_residuos, 
            Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;

        private void btnIntervalos_Click(object sender, EventArgs e)
        {


            MostrarIntervalos(sender, e);
        }

        //Metodo para mostrar forma de Intervalos
        private void MostrarIntervalos(object sender, EventArgs e)
        {
            this.Hide();
            frmIntervalos.ShowDialog();
            this.Show();
        }

        bool aproba1 = false, aproba2 = false;

        private void txtAcidez_TextChanged(object sender, EventArgs e)
        {
            frmProblema_Load(sender, e);
        }

        private void frmProblema_Load(object sender, EventArgs e)
        {
        }

        //variables de agua

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdIngresarAnimales_Click(object sender, EventArgs e)
        {
            float suma = 0F;


            //Recuperacion de datos ingresados por el usuario
            Ani_acidez= float.Parse(txtAcidez.Text) * 0.01F;
            Ani_anemia = float.Parse(txtAnemia.Text) * 0.01F;
            Ani_normal = float.Parse(txtNormal.Text) * 0.01F;
            Ani_glucosa = float.Parse(txtGlucosa.Text) * 0.01F;
            Ani_Alcalinindad = float.Parse(txtalcalinidad.Text) * 0.01F;

            suma = (Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad);

            txtSuma1.Text = "" + suma;

            if(suma == 1)
            {
                aproba1 = true;
                //Crear distribucion acumulada
            }
            else
            {
                aproba1 = false;
                if(suma > 1)
                {
                    MessageBox.Show("La suma de la distribucion de probabilidad supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                }
                else
                {
                    MessageBox.Show("La suma de la distribucion es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                }
            }
            txtTotal1.Visible = true;
        }

        private void cmdIngresarAgua_Click(object sender, EventArgs e)
        {
            /*Alto grado de acidez
Estado de anemia aguda
Estado en rango normal
Exceso de glucosa
Alto grado de alcalinidad*/

            float suma = 0F;

            //Recuperacion de datos ingresados por el usuario
            Agua_coloidales = float.Parse(txtAcoloidales.Text) * 0.01F;
            Agua_mercurio = float.Parse(txtAmercurio.Text) * 0.01F;
            Agua_residuos = float.Parse(txtAresiduos.Text) * 0.01F;
            Agua_sulfato = float.Parse(txtASulfato.Text) * 0.01F;
            Agua_acido = float.Parse(txtAAcido.Text) * 0.01F;
            Agua_fosfato = float.Parse(txtAfosfato.Text) * 0.01F;
            Agua_oxidos = float.Parse(txtAOxidos.Text) * 0.01F;

            suma = (Agua_coloidales + Agua_mercurio + Agua_residuos + 
                Agua_sulfato + Agua_acido + Agua_fosfato + Agua_oxidos);

            txtSuma2.Text = "" + suma;

            if (suma == 1)
            {
                aproba2 = true;
                //Crear distribucion acumulada
            }
            else
            {
                aproba2 = false;
                if (suma > 1)
                {
                    MessageBox.Show("La suma de la distribucion de probabilidad supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                }
                else
                {
                    MessageBox.Show("La suma de la distribucion es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                }
            }
            txtTotal2.Visible = true;
        }
    }
}
