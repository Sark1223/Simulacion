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

        public class Intervals
        {
            public string nombre;
            public float distribucion;
            public float limInf;
            public float limSup;
        }

        List<Intervals> animales = new List<Intervals>();
        List<Intervals> agua = new List<Intervals>();
        Intervals ag;
        Intervals an;
        frmIntervalos frmIntervalos = new frmIntervalos();

        //variables de animales
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;

        //variables de aguas
        float Agua_coloidales, Agua_mercurio, Agua_residuos, 
            Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;

        //Asigna valores en la lista
        public void AsignarVal()
        {
            an = new Intervals();
            an.nombre = "Acidez";
            an.distribucion = Ani_acidez;
            an.limInf = 0;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Anemia";
            an.distribucion = Ani_anemia;
            an.limInf = an.limSup;
            an.limSup = an.limInf + an.distribucion;

            an = new Intervals();
            an.nombre = "Normal";
            an.distribucion = float.Parse(txtNormal.Text);
            an.limInf = an.limSup;
            an.limSup = an.limInf + an.distribucion;

            an = new Intervals();
            an.nombre = "Glucosa";
            an.distribucion = float.Parse(txtGlucosa.Text);
            an.limInf = an.limSup;
            an.limSup = an.limInf + an.distribucion;

            an = new Intervals();
            an.nombre = "Alcalinidad";
            an.distribucion = float.Parse(txtalcalinidad.Text);
            an.limInf = an.limSup;
            an.limSup = an.limInf + an.distribucion;

            ag.nombre = "Coloidales";
            agua[0].distribucion = float.Parse(txtAcoloidales.Text);
            agua[1].nombre = "Mercurio";
            agua[1].distribucion = float.Parse(txtAmercurio.Text);
            agua[2].nombre = "Residuos";
            agua[3].distribucion = float.Parse(txtAresiduos.Text);
            agua[4].nombre = "Sulfato";
            agua[4].distribucion = float.Parse(txtASulfato.Text);
            agua[5].nombre = "Acido";
            agua[5].distribucion = float.Parse(txtAAcido.Text);
            agua[6].nombre = "Fosfato";
            agua[6].distribucion = float.Parse(txtAfosfato.Text);
            agua[7].nombre = "Oxido";
            agua[7].distribucion = float.Parse(txtAOxidos.Text);
        }

        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            AsignarVal();
            int n = 0;
          for(int i = 0; i <= 4; i++)
            {
                //n = frmIntervalos.tblAnimales.Rows.Add();
                //frmIntervalos.tblAnimales.Rows[n].Cells[1].Value = Ani_Coloidales;
                //frmIntervalos.tblAnimales.Rows[n].Cells[2].Value = ;
                //frmIntervalos.tblAnimales.Rows[n].Cells[3].Value = ;
            }
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
