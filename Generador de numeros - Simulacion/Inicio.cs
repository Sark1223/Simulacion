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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Generador_de_numeros___Simulacion
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        List<Semilla> lista = new List<Semilla>();

        frmNumeros numeros = new frmNumeros();
        frmOpciones opciones = new frmOpciones();
        Semilla g;

        public void btnDatos_Click(object sender, EventArgs e)
        {
            GenerarObjeto();
            GenerarNumeros();
            opciones.RecibirLista(numeros);
            opciones.ShowDialog();
        }

        public void GenerarObjeto()
        {
            g = new Semilla();
            g.X0 = float.Parse(txtSemilla.Text);
            g.a = float.Parse(txtA.Text);
            g.c = float.Parse(txtC.Text);
            g.m = float.Parse(txtM.Text);
        }

        public void GenerarNumeros()
        {
            numeros.tablaResultados.Clear();
            lista.Clear();
            //valor semilla de la que se basaran nuestros numeros
            float x0 = g.X0;
            
            for (int i = 0; i < 325; i++)
            {
                //si es el primero numero generado entonces 
                if (i == 0)
                {
                    //contador inicia en 1
                    g.N = i + 1;
                    //se recibe nuestra semilla
                    g.Xn = g.X0;
                    //formula de nuestro metodo congruencial mixto
                    g.Res = (g.a * g.Xn) + g.c;
                    //obtenemos el modulo del resultado anterior
                    g.modulo = g.Res % g.m;
                    //lo dividimos entre nuestra constante m y le restamos 1 al resultado
                    g.Ri = /*((*/g.modulo / g.m/*) - 1F) * -1*/;

                    lista.Add(g);

                    numeros.tablaResultados.Text = $"{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
                        $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";
                }
                else
                {
                    GenerarObjeto();
                    //contador inicia en 1
                    g.N = i + 1;
                    //se recibe nuestra semilla
                    g.Xn = lista[i - 1].modulo;
                    //formula de nuestro metodo congruencial mixto
                    g.Res = (g.a * g.Xn) + g.c;
                    //obtenemos el modulo del resultado anterior
                    g.modulo = g.Res % g.m;
                    //lo dividimos entre nuestra constante m y le restamos 1 al resultado
                    g.Ri = g.modulo / g.m;

                    lista.Add(g);

                    numeros.tablaResultados.Text = numeros.tablaResultados.Text + $"\r\n{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
                        $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";
                }

            }

            numeros.tablaResultados.ScrollBars = ScrollBars.Both;

            //numeros.ShowDialog();
            //opciones.ShowDialog();
        }
        
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Los valores que se muestran en la pantalla son los que se recomiendan para el ejercicio,pero pueden ser modificados","ATENCION");
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txtSemilla_TextChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
            bool error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtSemilla.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtSemilla, "No se admiten letras\nFavor de ingresar numeros solamente");
            }
            else
            {
                error1.Clear();
            }
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
            bool error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtA.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtA, "No se admiten letras\nFavor de ingresar numeros solamente");
            }
            else
            {
                error1.Clear();
            }
        }
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
            bool error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtC.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtC, "No se admiten letras\nFavor de ingresar numeros solamente");
            }
            else
            {
                error1.Clear();
            }
        }
        private void txtM_TextChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
            bool error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtM.Text)
            {
                //si alguno de los caracteres es un numero el error es true
                if (char.IsLetter(caracter))
                {
                    error = true;
                    break;
                }
            }
            if (error)
            {
                error1.SetError(txtM, "No se admiten letras\nFavor de ingresar numeros solamente");
            }
            else
            {
                error1.Clear();
            }
        }
    }
}
