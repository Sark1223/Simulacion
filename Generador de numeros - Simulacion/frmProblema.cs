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
    public partial class frmProblema : Form
    {
        public frmProblema()
        {
            InitializeComponent();
        }

        //variables de animales
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad; 
        
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

            suma = Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad;

            if(suma == 1)
            {
                //Crear distribucion acumulada
            }
            else
            {
                if(suma > 1)
                {
                    MessageBox.Show("La suma de la distribucion de probabilidad supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                }
                else
                {
                    MessageBox.Show("La suma de la distribucion es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                }
            }
            
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
            Ani_acidez = float.Parse(txtAcidez.Text);
            Ani_anemia = float.Parse(txtAnemia.Text);
            Ani_normal = float.Parse(txtNormal.Text);
            Ani_glucosa = float.Parse(txtGlucosa.Text);
            Ani_Alcalinindad = float.Parse(txtalcalinidad.Text);

            suma = Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad;

            if (suma == 1)
            {
                //Crear distribucion acumulada
            }
            else
            {
                if (suma > 1)
                {
                    MessageBox.Show("La suma de la distribucion de probabilidad supera el 1, Favor de verificar los datos", "Error al ingresar datos");
                }
                else
                {
                    MessageBox.Show("La suma de la distribucion es menor a 1, Favor de verificar los datos", "Error al ingresar datos");
                }
            }


        }
    }
}
