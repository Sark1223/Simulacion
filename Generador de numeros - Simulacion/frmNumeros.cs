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
    public partial class frmNumeros : Form
    {
        public frmNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ////, a = 9, c = 13, m = 32, N;
            ////float Ri;
            ////valor semilla de la que se basaran nuestros numeros
            //int x0 = 17;
            //Semilla g;
            //List<Semilla> lista = new List<Semilla>();
           
            //for(int i =0; i<325; i++)
            //{
            //    //si es el primero numero generado entonces 
            //    if(i== 0)
            //    {
            //        g = new Semilla();
            //        //contador inicia en 1
            //        g.N = i + 1;
            //        //se recibe nuestra semilla
            //        g.Xn = x0;
            //        //formula de nuestro metodo congruencial mixto
            //        g.Res = (g.a * g.Xn) + g.c;
            //        //obtenemos el modulo del resultado anterior
            //        g.modulo = g.Res % g.m;
            //        //lo dividimos entre nuestra constante m y le restamos 1 al resultado
            //        g.Ri = /*((*/g.modulo / g.m/*) - 1F) * -1*/;

            //        lista.Add(g);

            //        tablaResultados.Text = $"{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
            //            $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";
            //    }
            //    else
            //    {
            //        g = new Semilla();
            //        //contador inicia en 1
            //        g.N = i + 1;
            //        //se recibe nuestra semilla
            //        g.Xn = lista[i-1].modulo;
            //        //formula de nuestro metodo congruencial mixto
            //        g.Res = (g.a * g.Xn) + g.c;
            //        //obtenemos el modulo del resultado anterior
            //        g.modulo = g.Res % g.m;
            //        //lo dividimos entre nuestra constante m y le restamos 1 al resultado
            //        g.Ri = g.modulo / g.m;

            //        lista.Add(g);

            //        tablaResultados.Text = tablaResultados.Text + $"\r\n{lista[i].N}\t{lista[i].Xn}\t{lista[i].a}\t{lista[i].c}\t{lista[i].m}" +
            //            $"\t{lista[i].Res}\t{lista[i].modulo}\t{lista[i].Ri}";
            //    }
                
            //}

            //tablaResultados.ScrollBars = ScrollBars.Both;

        }

        private void frmGenerador_Load(object sender, EventArgs e)
        {

        }
    }
}
