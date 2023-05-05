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

        //CLASE INTERVALOS 
        public class Intervals
        {
            public string nombre;
            public float distribucion;
            public float limInf;
            public float limSup;
        }


        //Objeto de clases
        Semilla g;
        Intervals ag;
        Intervals an;

        //Objetos de formas
        frmIntervalos frmIntervalos = new frmIntervalos();
        frmHistorial historial = new frmHistorial();
        Resultados resulta = new Resultados();

        //Lista para guardar los intervalos y datos del AGUA y ANIMALES
        List<Intervals> animales = new List<Intervals>();
        List<Intervals> agua = new List<Intervals>();

        //Areglo para obtener numeros PSEUDOALEARTORIOS
        public float[] Ri = new float[1180];


        //Recibir numeo de la pantalla de inicio
        public void ObtenerNumero(float[] numeros, Semilla g)
        {
            Ri = numeros;
            this.g = g;
        }

        
        //METODOS para RESOLVER el ejercicio ------------------------------------------------------------------
        int op_ani_acidez = 0, op_ani_anemia = 0, op_ani_normal = 0, op_ani_glucosa = 0, op_ani_alcalinidad = 0;
        int op_coloidales = 0, op_mercurio = 0, op_residuos = 0, op_sulfato = 0, op_acido = 0, op_fosfato = 0, op_oxidos = 0;

        //asignacion de resultados al problema
        private string LimitesSangreAnimales(float num_muestra)
        {
            if (num_muestra >= animales[0].limInf && num_muestra <= animales[0].limSup)
            {
                op_ani_acidez++;
                //return 1;
                return "alto grado de acidez";
            }
            else if (num_muestra >= animales[1].limInf && num_muestra <= animales[1].limSup)
            {
                op_ani_anemia++;
                return "estado de anemia aguda";
                //return 2;
            }
            else if (num_muestra >= animales[2].limInf && num_muestra <= animales[2].limSup)
            {
                op_ani_normal++;
                return "estado de rango normal";
                //return 3;
            }
            else if (num_muestra >= animales[3].limInf && num_muestra <= animales[3].limSup)
            {
                op_ani_glucosa++;
                return "exceso de glucosa";
                //return 4;
            }
            else
            {
                op_ani_alcalinidad++;
                return "alto grado de alcalinidad";
                //return 5;
            }
        }
        private void LimitesAgua(float num_muestra)
        {
            if (num_muestra >= agua[0].limInf && num_muestra <= agua[0].limSup)
            {
                op_coloidales++;
            }
            else if (num_muestra >= agua[1].limInf && num_muestra <= agua[1].limSup)
            {
                op_mercurio++; //mas peligroso
            }
            else if (num_muestra >= agua[2].limInf && num_muestra <= agua[2].limSup)
            {
                op_residuos++;
            }
            else if (num_muestra >= agua[3].limInf && num_muestra <= agua[3].limSup)
            {
                op_sulfato++;
            }
            else if (num_muestra >= agua[4].limInf && num_muestra <= agua[4].limSup)
            {
                op_acido++;
            }
            else if (num_muestra >= agua[5].limInf && num_muestra <= agua[5].limSup)
            {
                op_fosfato++;
            }
            else
            {
                op_oxidos++;
            }
        }
        
        //Resultados Del problema
        private string ResAgua()
        {
            int resultado = 0;
            string Componente = "";

            if(op_coloidales > resultado)
            {
                resultado = op_coloidales;
                Componente = "Coloidales";
            }
            if (op_mercurio > resultado)
            {
                resultado = op_mercurio;
                Componente = "Mercurio";
            }
            if (op_residuos > resultado)
            {
                resultado = op_residuos;
                Componente = "Residuos";
            }
            if (op_sulfato > resultado)
            {
                resultado = op_sulfato;
                Componente = "Sulfato";
            }
            if (op_acido > resultado)
            {
                resultado = op_acido;
                Componente = "Acido";
            }
            if (op_fosfato > resultado)
            {
                resultado = op_fosfato;
                Componente = "Fosfato";
            }
            if (op_oxidos > resultado)
            {
                resultado = op_oxidos;
                Componente = "Oxido";
            }

            return Componente;
        }
        private string ResAnimales()
        {
            int resultado = 0;
            string Componente = "";

            if (op_ani_acidez > resultado)
            {
                resultado = op_ani_acidez;
                Componente = "Acides";
            }
            if (op_ani_anemia > resultado)
            {
                resultado = op_ani_anemia;
                Componente = "Anemia";
            }
            if (op_ani_normal > resultado)
            {
                resultado = op_ani_normal;
                Componente = "Normal";
            }
            if (op_ani_glucosa > resultado)
            {
                resultado = op_ani_glucosa;
                Componente = "Sulfato";
            }
            if (op_ani_alcalinidad > resultado)
            {
                resultado = op_ani_alcalinidad;
                Componente = "Acido";
            }

            return Componente;
        }

        private string Sector(int num)
        {
            if (num >= 0 && num < 5)
            {
                return "A";
            }
            else if (num >= 5 && num < 10)
            {
                return "B";
            }
            else if (num >= 10 && num <= 15)
            {
                return "C";
            }
            else 
            {
                return "D";
            }
        }

        private void cmdResolver_Click(object sender, EventArgs e)
        {
            if (aproba1 && aproba2)
            {
                //Limpiar las listas de animales y agua
                animales.Clear();
                agua.Clear();

                CargarLimitesEnListas();

                lblResultado.Text = "Ultimo numero del arreglo: " + Ri[1179];
                int num_actual = 0;

                int animal = 1;
                int normal = 0;
                int n;
                //DIA UNO
                for (int i = 0; i < 20; i++)
                {
                    string Salud = LimitesSangreAnimales(Ri[num_actual]);
                    if ( Salud == "estado de rango normal")
                    {
                        normal++;
                        
                    }

                    n = resulta.dgvResAni.Rows.Add();
                    resulta.dgvResAni.Rows[n].Cells[0].Value = i;
                    resulta.dgvResAni.Rows[n].Cells[1].Value = Salud;
                    num_actual++;
                    if (animal >= 5)
                    {
                        animal = 1;
                    }
                }

                if(normal> 16)
                {
                    lblResultado.Text = "Dia 1: más del 80% de los animales se encuentran en estado normal\r\n";
                }
                else
                {
                    lblResultado.Text = "Dia 1: más del 20% de los animales se encuentran en peligro\r\n";
                }

                //DIA 14
                normal = 0;
                for (int i = 0; i < 20; i++)
                {
                    string Salud = LimitesSangreAnimales(Ri[num_actual]);
                    if (Salud == "estado de rango normal")
                    {
                        normal++;

                    }

                    n = resulta.dgvResAni.Rows.Add();
                    resulta.dgvResAni.Rows[n].Cells[0].Value = i;
                    resulta.dgvResAni.Rows[n].Cells[1].Value = Salud;
                    num_actual++;
                    if (animal >= 5)
                    {
                        animal = 1;
                    }
                }

                if (normal > 16)
                {
                    lblResultado.Text += "Dia 2: más del 80% de los animales se encuentran en estado normal\r\n";
                }
                else
                {
                    lblResultado.Text += "Dia 2: más del 20% de los animales se encuentran en peligro\r\n";
                }

                //fin de mes
                normal = 0;
                for (int i = 0; i < 20; i++)
                {
                    string Salud = LimitesSangreAnimales(Ri[num_actual]);
                    if (Salud == "estado de rango normal")
                    {
                        normal++;

                    }

                    n = resulta.dgvResAni.Rows.Add();
                    resulta.dgvResAni.Rows[n].Cells[0].Value = i;
                    resulta.dgvResAni.Rows[n].Cells[1].Value = Salud;
                    num_actual++;
                    if (animal >= 5)
                    {
                        animal = 1;
                    }
                }

                if (normal > 16)
                {
                    lblResultado.Text += "Dia 3: más del 80% de los animales se encuentran en estado normal\r\n";
                }
                else
                {
                    lblResultado.Text += "Dia 3: más del 20% de los animales se encuentran en peligro\r\n";
                }


                if (ResAnimales() != "Normal")
                {
                    for (int x = 0; x < 14; x++) 
                    {
                        for (int i = 0; i < 60; i++)
                        {
                            LimitesAgua(Ri[num_actual]);
                            num_actual++;
                        }
                    }
                }


                lblResultado.Text += "Total numeros: " + num_actual + "  num final: " + Ri[num_actual - 1] +
                                    "\r\n El elemento mas encontrado fue: " + ResAgua() +
                                    "\r\n Los resultados mas repetidos en animales fueron: " + ResAnimales();


            }
            else
            {
                MessageBox.Show("Debe confirmar primero la distribucion de probabilidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            GuardarHisto();
        }

        //private void cmdResolver_Click(object sender, EventArgs e)
        //{
        //    if (aproba1 && aproba2)
        //    {
        //        //Limpiar las listas de animales y agua
        //        animales.Clear();
        //        agua.Clear();

        //        CargarLimitesEnListas();

        //        lblResultado.Text = "Ultimo numero del arreglo: " + Ri[1179];
        //        int TotalNumers = Ri.Length;
        //        int num_actual = 0;
        //        int dia_agua = 1;
        //        do
        //        {
        //            int animal = 1;
        //            //DIA UNO
        //            for (int i = 0; i < 20; i++)
        //            {
        //                LimitesSangreAnimales(Ri[num_actual]);
        //                num_actual++;
        //                if (animal >= 5)
        //                {
        //                    animal = 1;
        //                }
        //            }

        //            //DIA 14
        //            for (int i = 0; i < 20; i++)
        //            {
        //                LimitesSangreAnimales(Ri[num_actual]);
        //                num_actual++;
        //            }

        //            //fin de mes
        //            for (int i = 0; i < 20; i++)
        //            {
        //                LimitesSangreAnimales(Ri[num_actual]);
        //                num_actual++;
        //            }


        //            if (ResAnimales() != "Normal")
        //            {

        //                for (int i = 0; i < 60; i++)
        //                {
        //                    LimitesAgua(Ri[num_actual]);
        //                    num_actual++;
        //                }
        //            }

        //            while (num_actual >= 0 && num_actual < 20)
        //            {
        //                //txtResAnimales.Text += ""+  LimitesSangreAnimales(Ri[num_actual]+"\r\n");
        //                num_actual++;
        //                animal++;
        //                if (animal >= 5)
        //                {
        //                    animal = 1;
        //                }

        //            }

        //            if (dia_agua <= 14)
        //            {
        //                for (int i = 0; i < 60; i++)
        //                {
        //                    LimitesAgua(Ri[num_actual]);
        //                    num_actual++;
        //                }

        //                if (dia_agua == 14)
        //                {
        //                    for (int i = 0; i < 20; i++)
        //                    {
        //                        LimitesSangreAnimales(Ri[num_actual]);
        //                        num_actual++;
        //                    }
        //                }

        //                dia_agua++;
        //            }
        //            else
        //            {
        //                for (int i = 0; i < 20; i++)
        //                {
        //                    LimitesSangreAnimales(Ri[num_actual]);
        //                    num_actual++;
        //                }
        //            }

        //        } while (num_actual < 1180);
        //        lblResultado.Text = "Total numeros: " + num_actual + "  num final: " + Ri[num_actual - 1] +
        //                            "\r\n El elemento mas encontrado fue: " + ResAgua() +
        //                            "\r\n Los resultados mas repetidos en animales fueron: " + ResAnimales();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe confirmar primero la distribucion de probabilidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //    }

        //    GuardarHisto();
        //}

        //METODOS DE INTERVALOS ------------------------------------------------------------------------
        private void MostrarIntervalos(object sender, EventArgs e)
        {
            this.Hide();
            frmIntervalos.ShowDialog();
            this.Show();
        }

        public void RellenarListaAnimales()
        {
            an = new Intervals();
            an.nombre = "Alto grado de acidez";
            an.distribucion = Ani_acidez;
            an.limInf = 0;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Estado de anemia aguda";
            an.distribucion = Ani_anemia;
            an.limInf = animales[0].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Estado en rango normal";
            an.distribucion = Ani_normal;
            an.limInf = animales[1].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Exceso de glucosa";
            an.distribucion = Ani_glucosa;
            an.limInf = animales[2].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);

            an = new Intervals();
            an.nombre = "Alto grado de alcalinidad";
            an.distribucion = Ani_Alcalinindad;
            an.limInf = animales[3].limSup;
            an.limSup = an.limInf + an.distribucion;
            animales.Add(an);
        }

        public void RellenarListaAgua()
        {
            ag = new Intervals();
            ag.nombre = "Substancias coloidales";
            ag.distribucion = Agua_coloidales;
            ag.limInf = 0;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Exceso de mercurio";
            ag.distribucion = Agua_mercurio;
            ag.limInf = agua[0].limSup;
            ag.limSup = ag.limInf + ag.distribucion;
            agua.Add(ag);

            ag = new Intervals();
            ag.nombre = "Residuos petroquímicos";
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
            ag.nombre = "Acido clorhídrico";
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

        public void CargarLimitesEnListas()
        {
            RellenarListaAnimales();
            RellenarListaAgua();
        }

        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            if (aproba1 && aproba2)
            {
                //Limpia las filas de las tablas de animales y de agua
                frmIntervalos.tblAnimales.Rows.Clear();
                frmIntervalos.tblAgua.Rows.Clear();

                //Limpiar las listas de animales y agua
                animales.Clear();
                agua.Clear();

                CargarLimitesEnListas();

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
            else if (aproba1 == false && aproba2)
            {
                MessageBox.Show("La suma de la distribución de los analisis en animales es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
            else if (aproba1 && aproba2 == false)
            {
                MessageBox.Show("La suma de la distribución de los analisis de agua es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
            else
            {
                MessageBox.Show("La suma de ambas distribuciones es diferente de 1, Verifique los datos", "Error al ingresar datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resulta.ShowDialog();
        }


        //HISTORIAL de Experimentos ----------------------------------------------------------------------
        public void GuardarHisto()
        {
            //Agrega nueva fila
            int n = historial.dgvHistorial.Rows.Add();

            //Agregar datos de numeros pseudo
            string datos = $"Xo = {g.X0}\r\n" +
                           $"a = {g.a}\r\n" +
                           $"c = {g.c}\r\n" +
                           $"m = {g.m}\r\n";
            historial.dgvHistorial.Rows[n].Cells[0].Value = datos;

            //AGREGAR datos de los ANIMALES -----------------
            {
                string probAni = "";
                for (int i = 0; i < animales.Count; i++)
                {
                    probAni += $"{animales[i].nombre} = {animales[i].distribucion}\r\n";
                }
                historial.dgvHistorial.Rows[n].Cells[1].Value = probAni;

                //Mostrar la cantidad de cada de resultados de cada opcion ANIMALES

                string ResAni = $"Alto grado de acidez = {op_ani_acidez}\r\n" +
                           $"Estado de anemia aguda = {op_ani_anemia}\r\n" +
                           $"Estado en rango normal = {op_ani_normal}\r\n" +
                           $"Exceso de glucosa = {op_ani_glucosa}\r\n" +
                           $"Alto grado de alcalinidad = {op_ani_alcalinidad}\r\n";
                historial.dgvHistorial.Rows[n].Cells[2].Value = ResAni;
            }

            //AGREGAR datos del AGUA a la tabla------------------------
            {
                string probAgua = "";
                for (int i = 0; i < agua.Count; i++)
                {
                    probAgua += $"{agua[i].nombre} = {agua[i].distribucion}\r\n";
                }
                historial.dgvHistorial.Rows[n].Cells[3].Value = probAgua;

                //Mostrar la cantidad de cada de resultados de cada opcion AGUA

                string ResAgua = $"Substancias coloidales = {op_coloidales}\r\n" +
                           $"Exceso de mercurio = {op_mercurio}\r\n" +
                           $"Residuos petroquímicos = {op_residuos}\r\n" +
                           $"Sulfatos = {op_sulfato}\r\n" +
                           $"Acido clorhídrico = {op_acido}\r\n" +
                           $"Fosfato = {op_fosfato}\r\n" +
                           $"Óxidos = {op_oxidos}\r\n";
                historial.dgvHistorial.Rows[n].Cells[4].Value = ResAgua;
            }

        }

        private void cmdHistorial_Click(object sender, EventArgs e)
        {
            historial.ShowDialog();
        }



        //Metodos de la ventanas -------------------------------------------------------------------------
        private void frmProblema_Load(object sender, EventArgs e)
        {
            txtAcidez.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        



        //OBTENCION DE DATOS INGRESADOS POR EL USUARIO -----------------------------------------------------
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;
        float Agua_coloidales, Agua_mercurio, Agua_residuos, Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;
        
        bool aproba1 = false, aproba2 = false;
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
        
        private void ValidarAcidez_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Ingresar solo números", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //e.Handled = true;
            //return;
        }

        private void txtAcidez_TextChanged(object sender, EventArgs e)
        {
            //frmProblema_Load(sender, e);
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
