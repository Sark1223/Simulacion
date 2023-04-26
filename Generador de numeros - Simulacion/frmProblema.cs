using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_numeros___Simulacion
{
    public partial class frmProblema : Form
    {
        frmIntervalos intervalos = new frmIntervalos();
        public frmProblema()
        {
            InitializeComponent();
        }

        //variables de animales
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;

        //variables de aguas
        float Agua_coloidales, Agua_mercurio, Agua_residuos, 
            Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;

        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            this.Hide();
            intervalos.ShowDialog();
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
            Ani_acidez= float.Parse(txtAcidez.Text);
            Ani_anemia = float.Parse(txtAnemia.Text);
            Ani_normal = float.Parse(txtNormal.Text);
            Ani_glucosa = float.Parse(txtGlucosa.Text);
            Ani_Alcalinindad = float.Parse(txtalcalinidad.Text);

            suma = (Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad) / 100;

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
            Agua_coloidales = float.Parse(txtAcoloidales.Text);
            Agua_mercurio = float.Parse(txtAmercurio.Text);
            Agua_residuos = float.Parse(txtAresiduos.Text);
            Agua_sulfato = float.Parse(txtASulfato.Text);
            Agua_acido = float.Parse(txtAAcido.Text);
            Agua_fosfato = float.Parse(txtAfosfato.Text);
            Agua_oxidos = float.Parse(txtAOxidos.Text);

            suma = (Agua_coloidales + Agua_mercurio + Agua_residuos + 
                Agua_sulfato + Agua_acido + Agua_fosfato + Agua_oxidos) / 100;

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
