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

        float Z2 = 0, Za = 0;
        int no_pruebas = 0;

        public void btnDatos_Click(object sender, EventArgs e)
        {
            GenerarObjeto();
            if(rb10.Checked == true)
            {
                Za = 1.645F;
                Z2 = 6.2514F;
            }
            else if(rb5.Checked == true)
            {
                Za = 1.96F;
                Z2 = 7.8147F;
            }

            GenerarNumeros();
            opciones.RecibirLista(numeros);

            Realizar_PruebaPromedios();
            Realizar_PruebaFrecuencia();
            opciones.txtPruevasSuperadas.Text = "No. de pruebas superadas: " + no_pruebas;
            opciones.ShowDialog();

            no_pruebas = 0;
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
            //numeros.tablaResultados.Clear();
            //numeros.tblPseudo.Dispose();
            lista.Clear();
            //valor semilla de la que se basaran nuestros numeros
            float x0 = g.X0;
            int n = 0;
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

                    //numeros.tablaResultados.Text = $"{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
                    //    $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";

                    //Agrega valores a las filas de la tabla
                    n = numeros.tblPseudo.Rows.Add();
                    numeros.tblPseudo.Rows[n].Cells[0].Value = n + 1;
                    numeros.tblPseudo.Rows[n].Cells[1].Value = lista[n].Ri;
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

                    //numeros.tablaResultados.Text = numeros.tablaResultados.Text + $"\r\n{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
                    //    $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";

                    //Agrega valores a las filas de la tabla
                    n = numeros.tblPseudo.Rows.Add();
                    numeros.tblPseudo.Rows[n].Cells[0].Value = n + 1;
                    numeros.tblPseudo.Rows[n].Cells[1].Value = lista[n].Ri;
                }
            }

            //numeros.tablaResultados.ScrollBars = ScrollBars.Both;

            //numeros.ShowDialog();
            //opciones.ShowDialog();
        }

        public void Realizar_PruebaPromedios()
        {
            float promedio = 0;
            double Zo;

            for (int i = 0; i < lista.Count; i++)
            {
                promedio += lista[i].Ri;
            }

            promedio = (promedio / lista.Count);
            Zo = (((promedio - 0.50F) * Math.Sqrt(lista.Count)) / Math.Sqrt(1F / 12F));

            if(Zo < 0) { Zo *= -1; }


            if (Zo <= Za)
            {
                opciones.txtMesajeDatos.Text = "Los numeros que se generaron se encuentran distribuidos uniformemente.";
                no_pruebas++;
            }
            else
            {
                opciones.txtMesajeDatos.Text = "Los numeros que se generaron pueden generar resultados ambiguos.";

            }
        }

        public void Realizar_PruebaFrecuencia()
        {
            int N1 = 0, N2 = 0, N3 = 0, N4 = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Ri >= 0 && lista[i].Ri < 0.25)
                {
                    N1++;
                }
                else if(lista[i].Ri >= 0.25 && lista[i].Ri < 0.50)
                {
                    N2++;
                }
                else if (lista[i].Ri >= 0.50 && lista[i].Ri < 0.75)
                {
                    N3++;
                }
                else if (lista[i].Ri >= 0.75 && lista[i].Ri <= 1.00)
                {
                    N4++;
                }
            }

            float FE = lista.Count / 4F;

            double Xo = (Math.Pow(N1 - FE, 2)/FE) + (Math.Pow(N2 - FE, 2) / FE) +
                (Math.Pow(N3 - FE, 2) / FE) + (Math.Pow(N4 - FE, 2) / FE);

            if (Xo <= Z2)
            {
                opciones.txtMesajeDatos.Text = "Los numeros que se generaron se encuentran distribuidos uniformemente.";
                no_pruebas++;
            }
            else
            {
                opciones.txtMesajeDatos.Text = "Los numeros que se generaron pueden generar resultados ambiguos.";

            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Los valores que se muestran en la pantalla son los que se recomiendan para el ejercicio,pero pueden ser modificados","ATENCION");
            rb5.Checked = true;
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
