using System;
using System.Collections;
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

        public float[] Ri = new float[1180];

        //Recibir numeo de la pantalla de inicio
        public void ObtenerNumero(float[] numeros)
        {
            Ri = numeros;
        }

        //variables de animales
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;

        //variables de aguas
        float Agua_coloidales, Agua_mercurio, Agua_residuos, 
            Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;

        private void ValidarAcidez_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Ingresar solo números", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //e.Handled = true;
            //return;
        }

        private void cmdResolver_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Ultimo numer del arreglo: " + Ri[1179];

            for(int i = 0; i< Ri.Length; i++)
            {

            }
        }

        //Asigna valores en la lista
        public void AsignarValAnimales()
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
            an.limInf = animales[0].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Normal";
            an.distribucion = Ani_normal;
            an.limInf = animales[1].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Glucosa";
            an.distribucion = Ani_glucosa;
            an.limInf = animales[2].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Alcalinidad";
            an.distribucion = Ani_Alcalinindad;
            an.limInf = animales[3].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);
        }

        public void AsignarValAgua()
        {
            ag = new Intervals();
            ag.nombre = "Coloidales";
            ag.distribucion = Agua_coloidales;
            ag.limInf = 0;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Mercurio";
            ag.distribucion = Agua_mercurio;
            ag.limInf = agua[0].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Residuos";
            ag.distribucion = Agua_residuos;
            ag.limInf = agua[1].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Sulfato";
            ag.distribucion = Agua_sulfato;
            ag.limInf = agua[2].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Acido";
            ag.distribucion = Agua_acido;
            ag.limInf = agua[3].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Fosfato";
            ag.distribucion = Agua_fosfato;
            ag.limInf = agua[4].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Oxido";
            ag.distribucion = Agua_oxidos;
            ag.limInf = agua[5].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);
        }

        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            if(aproba1 && aproba2)
            {
                //Limpia las filas de las tablas de animales y de agua
                frmIntervalos.tblAnimales.Rows.Clear();
                frmIntervalos.tblAgua.Rows.Clear();

                //Limpiar las listas de animales y agua
                animales.Clear();
                agua.Clear();

                AsignarValAnimales();
                AsignarValAgua();

                int n = 0;
                int m = 0;
                for (int i = 0; i < animales.Count; i++)
                {
                    n = frmIntervalos.tblAnimales.Rows.Add();
                    frmIntervalos.tblAnimales.Rows[n].Cells[0].Value = animales[i].nombre;
                    frmIntervalos.tblAnimales.Rows[n].Cells[1].Value = animales[i].distribucion;
                    frmIntervalos.tblAnimales.Rows[n].Cells[2].Value = animales[i].limInf;
                    frmIntervalos.tblAnimales.Rows[n].Cells[3].Value = animales[i].limSup;
                }
                for (int i = 0; i < agua.Count; i++)
                {
                    m = frmIntervalos.tblAgua.Rows.Add();
                    frmIntervalos.tblAgua.Rows[m].Cells[0].Value = agua[i].nombre;
                    frmIntervalos.tblAgua.Rows[m].Cells[1].Value = agua[i].distribucion;
                    frmIntervalos.tblAgua.Rows[m].Cells[2].Value = agua[i].limInf;
                    frmIntervalos.tblAgua.Rows[m].Cells[3].Value = agua[i].limSup;
                }
                MostrarIntervalos(sender, e);
            }
            else if(aproba1 == false && aproba2)
            {
                MessageBox.Show("La suma de la distribución de los analisis en animales es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
            else if(aproba1 && aproba2 == false)
            {
                MessageBox.Show("La suma de la distribución de los analisis de agua es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
            else
            {
                MessageBox.Show("La suma de ambas distribuciones es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
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
            //frmProblema_Load(sender, e);
        }

        private void frmProblema_Load(object sender, EventArgs e)
        {
            txtAcidez.Focus();
        }

        //variables de agua

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdIngresarAnimales_Click(object sender, EventArgs e)
        {


            //Recuperacion de datos ingresados por el usuario
            Ani_acidez = float.Parse(txtAcidez.Text) * 0.01F;
            Ani_anemia = float.Parse(txtAnemia.Text) * 0.01F;
            Ani_normal = float.Parse(txtNormal.Text) * 0.01F;
            Ani_glucosa = float.Parse(txtGlucosa.Text) * 0.01F;
            Ani_Alcalinindad = float.Parse(txtalcalinidad.Text) * 0.01F;

            float suma = Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad;

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
                    MessageBox.Show("La suma de la distribucion de probabilidad supera el 1, Verifique los datos", "Error al ingresar datos");
                }
                else
                {
                    MessageBox.Show("La suma de la distribucion es menor a 1, Verifique los datos", "Error al ingresar datos");
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
