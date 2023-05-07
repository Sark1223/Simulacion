using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
        Inicio inicio = new Inicio();

        //Lista para guardar los intervalos y datos del AGUA y ANIMALES
        List<Intervals> animales = new List<Intervals>();
        List<Intervals> agua = new List<Intervals>();

        //Areglo para obtener numeros PSEUDOALEARTORIOS
        public float[] Ri = new float[1180];

        bool aproba1 = false, aproba2 = false, error = false;


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
        private string LimitesAgua(float num_muestra)
        {
            
            if (num_muestra >= agua[0].limInf && num_muestra <= agua[0].limSup)
            {
                op_coloidales++;
                return "Substancias coloidales";
            }
            else if (num_muestra >= agua[1].limInf && num_muestra <= agua[1].limSup)
            {
                op_mercurio++; //mas peligroso
                return "Exceso de mercurio";

            }
            else if (num_muestra >= agua[2].limInf && num_muestra <= agua[2].limSup)
            {
                op_residuos++;
                return "Residuos petroquímicos";
            }
            else if (num_muestra >= agua[3].limInf && num_muestra <= agua[3].limSup)
            {
                op_sulfato++;
                return "Sulfatos";
            }
            else if (num_muestra >= agua[4].limInf && num_muestra <= agua[4].limSup)
            {
                op_acido++;
                return "Acido clorhídrico";
            }
            else if (num_muestra >= agua[5].limInf && num_muestra <= agua[5].limSup)
            {
                op_fosfato++;
                return "Fosfato";
            }
            else
            {
                op_oxidos++;
                return "Óxidos";
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

        private bool ConclusionSector(bool[] sector, string X, System.Windows.Forms.Label label)
        {
            if (sector[2])
            {
                if (sector[1])
                {
                    if (sector[0])
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                                                    "PERMANECIO SALUDABLE todo " +
                                                    "el experimento.";
                        return true;
                    }
                    else
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba enfermo, " +
                            "el dia 14  saludable y " +
                            "30 dias despues saludable.";
                        return true;
                    }
                }
                else
                {
                    if (sector[0])
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba Saludable, " +
                            "el dia 14  Enfermo y " +
                            "30 dias despues saludable.";
                        return true;
                    }
                    else
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba Enfermo, " +
                            "el dia 14  Enfermo y " +
                            "30 dias despues Saludable.";
                        return true;
                    }
                }
            }
            else
            {
                if (sector[1])
                {
                    if (sector[0])
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba Saludable, " +
                            "el dia 14  Saludable y " +
                            "30 dias despues Enfermo.";
                        return false;
                    }
                    else
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba Enfermo, " +
                            "el dia 14  Saludable y " +
                            "30 dias despues Enfermo.";
                        return false;
                    }
                }
                else
                {
                    if (sector[0])
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                            "El dia 1 se encontraba Saludable, " +
                            "el dia 14  Enfermo y " +
                            "30 dias despues Enfermo.";
                        return false;
                    }
                    else
                    {
                        label.Text = $"En el Sector {X} el ganado: " +
                                                     "PERMANECIO ENFERMO todo " +
                                                     "el experimento.";
                        return false;
                    }

                }
            }
        }
        int fila;
        private bool Evaluar(int dia, string sector)
        {
            //Variables para almacenar la informacion que se agregara a la tabla
            
            string EstadoAnimal ="";
            string[] EstadosNegativosArg = new string[5];
            string EstadosNegativos = "Se encontraron:";
            int w = 0;
            //Se agrega una nueva fila cada que cambia de sector
            fila = dgvResAni.Rows.Add();
            
            /*El dia y sector solo se mostraran una vez,
            por lo que se agrega fuera del ciclo*/
            dgvResAni.Rows[fila].Cells[0].Value = dia;
            dgvResAni.Rows[fila].Cells[1].Value = sector;

            int sano = 0;

            //El ciclo recorre los 5 animales de los que se toma muestra
            for (int i = 0; i < 5; i++)
            {
                string Salud = LimitesSangreAnimales(Ri[num_actual]);

                if (Salud == "estado de rango normal")
                {
                    sano++;
                }
                else
                {
                    EstadosNegativosArg[w] = Salud;
                    w++;
                }

                EstadoAnimal += $"Animal {i+1} - {Salud}\r\n";
                num_actual++;
            }

            //Imprime los Resultados de todos los animales
            dgvResAni.Rows[fila].Cells[2].Value = EstadoAnimal;

            //Evaluar Resultados de salud de los animales
            int aa = 0, eg = 0, eaa = 0, aga = 0;

            //El ciclo verifica cuantos animales de cada estado existen
            for (w = 0; w < EstadosNegativosArg.Length; w++)
            {
                if (EstadosNegativosArg[w] == "alto grado de alcalinidad")
                {
                    aa++;
                }
                else if(EstadosNegativosArg[w] == "exceso de glucosa")
                {
                    eg++;
                }
                else if (EstadosNegativosArg[w] == "estado de anemia aguda")
                {
                    eaa++;
                }
                else if (EstadosNegativosArg[w] == "alto grado de acidez")
                {
                    aga++;
                }
                
            }

            //si hay 1 o más es importante imprimirlo
            {
                if (aa > 0)
                {
                    EstadosNegativos += "\r\nAlto grado de alcalinidad: " + aa;
                }
                if (eg > 0)
                {
                    EstadosNegativos += "\r\nExceso de glucosa: " + eg;
                }
                if (eaa > 0)
                {
                    EstadosNegativos += "\r\nEstado de anemia aguda: " + eaa;
                }
                if (aga > 0)
                {
                    EstadosNegativos += "\r\nAlto grado de acidez: " + aga;
                }
            }

            
            if(sano >= 3)
            {
                dgvResAni.Rows[fila].Cells[3].Value = "Aunque "+EstadosNegativos + 
                                                   "\r\nel 50% o más del ganado esta SALUDABLES.";
              
                return true;
            }
            else
            {
                dgvResAni.Rows[fila].Cells[3].Value = "Los animales estan en PELIGRO\r\n" + 
                                                    EstadosNegativos +
                                                    "\r\nmás del 50% del ganado puede morir.";
                return false;
            }
                
            
        }

        //bool Animales_Saludables = false;
        int num_actual = 0;

        private void RecorrerResultadosAgua(string[] arg, string sector)
        {
            int sc = 0, em = 0, rp = 0, s = 0, ac = 0, f = 0, o = 0;

            for(int i=0; i< arg.Length; i++)
            {
                if (arg[i] == "Substancias coloidales")
                {
                    sc++;
                }
                if (arg[i] == "Exceso de mercurio")
                {
                    em++;
                }
                if (arg[i] == "Residuos petroquímicos")
                {
                    rp++;
                }
                if (arg[i] == "Sulfatos")
                {
                    s++;
                }
                if (arg[i] == "Acido clorhídrico")
                {
                    ac++;
                }
                if (arg[i] == "Fosfato")
                {
                    f++;
                }
                if (arg[i] == "Óxidos")
                {
                    o++;
                }
            }

            int[] FO = { sc, em, rp, s, ac, f, o };

            for (int x = 0; x < FO.Length; x++)
            {
                // Recuerda que el -1 es porque no queremos llegar al final ya que hacemos
                // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
                // del arreglo
                for (int indiceActual = 0; indiceActual < FO.Length - 1; indiceActual++)
                {
                    int indiceSiguienteElemento = indiceActual + 1;
                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (FO[indiceActual] > FO[indiceSiguienteElemento])
                    {
                        int temporal = FO[indiceActual];
                        FO[indiceActual] = FO[indiceSiguienteElemento];
                        FO[indiceSiguienteElemento] = temporal;
                    }
                }
            }

            string masEncontrado = "";

            if (FO[6] == sc)
            {
                masEncontrado = "Substancias coloidales";
            }
            else if (FO[6] == em)
            {
                masEncontrado = "Exceso de mercurio";
            }
            if (FO[6] == rp)
            {
                masEncontrado = "Residuos petroquímicos";
            }
            else if (FO[6] == s)
            {
                masEncontrado = "Sulfatos";
            }
            else if (FO[6] == ac)
            {
                masEncontrado = "Acido clorhídrico";
            }
            else if (FO[6] == f)
            {
                masEncontrado = "Fosfato";
            }
            else if (FO[6] == o)
            {
                masEncontrado = "Óxidos";
            }

            txtConclusionAgua.Text += $"   - {sector} fue: " + masEncontrado + "\r\n";
        }


        private void cmdResolver_Click(object sender, EventArgs e)
        {
            if (aproba1 && aproba2)
            {
                //Limpiar las listas de animales y agua
                animales.Clear();
                agua.Clear();
                dgvResAgua.Rows.Clear();
                dgvResAni.Rows.Clear();


                CargarLimitesEnListas();

                num_actual = 0;

                bool[] SectorA = new bool[3];
                bool[] SectorB = new bool[3];
                bool[] SectorC = new bool[3];
                bool[] SectorD = new bool[3];

                //DIA UNO
                { 
                //Sector A
                SectorA[0] = Evaluar(1, "A");
                //Sector B
                SectorB[0] = Evaluar(1, "B");
                //Sector C
                SectorC[0] = Evaluar(1, "C");
                //Sector D
                SectorD[0] = Evaluar(1, "D");
                }


                //DIA 14
                { 
                //Sector A
                SectorA[1] = Evaluar(14, "A");
                //Sector B
                SectorB[1] = Evaluar(14, "B");
                //Sector C
                SectorC[1] = Evaluar(14, "C");
                //Sector D
                SectorD[1] = Evaluar(14, "D");
                }


                //DIA 30
                { 
                //Sector A
                SectorA[2] = Evaluar(30, "A");
                //Sector B
                SectorB[2] = Evaluar(30, "B");
                //Sector C
                SectorC[2] = Evaluar(30, "C");
                //Sector D
                SectorD[2] = Evaluar(30, "D");
                }

                int resultadoEficiente = 0;
                string sectoresEficientes = "Los del sector: ";

                if(ConclusionSector(SectorA, "A", lblConclusionSA))
                {
                    resultadoEficiente++;
                    sectoresEficientes += "A";

                }
                if(ConclusionSector(SectorB, "B", lblConclusionSB))
                {
                    resultadoEficiente++;
                    sectoresEficientes += "B,";
                }
                if(ConclusionSector(SectorC, "C", lblConclusionSC))
                {
                    resultadoEficiente++;
                    sectoresEficientes += "C,";
                }
                if(ConclusionSector(SectorD, "D", lblConclusionSD))
                {
                    resultadoEficiente++;
                    sectoresEficientes += "D";
                }

                bool calcularAgua;

                if(resultadoEficiente > 2)
                {
                    txtConclusionGeneral.Location = new Point(14, 6);
                    txtConclusionGeneral.Text = "Aunque algunos animales esten resultando afectados\r\n" +
                                                sectoresEficientes + " parecen adaptarse bien\r\n" +
                                                "por tanto, NO es INDISPENSABLE cambiar de distribuidor.";
                    calcularAgua = false;
                }
                else
                {
                    txtConclusionGeneral.Location = new Point(14, 19);
                    txtConclusionGeneral.Text = "ES INDISPENSABLE CAMBIAR el estado del agua.";
                    calcularAgua = true;
                }

                string[] EstadoDelAguaA = new string[280];
                int pruebasA =0;
                string[] EstadoDelAguaB = new string[280];
                int pruebasB = 0;
                string[] EstadoDelAguaC = new string[280];
                int pruebasC = 0;
                string[] EstadoDelAguaD = new string[280];
                int pruebasD = 0;

                if (calcularAgua)
                {
                    int renglon;
                    for (int x = 0; x < 14; x++)
                    {
                        //Agregra nuevo Renglon
                        renglon = dgvResAgua.Rows.Add();

                        //Agregar dia al nuevo renglon
                        dgvResAgua.Rows[renglon].Cells[0].Value = x+1;//Dia
                        dgvResAgua.Rows[renglon].Cells[1].Value = "A";//Sector

                        //sector A
                        string prueba="";
                        string resAgua = "";
                        for (int i = 0; i < 20; i++)
                        {
                            string a = LimitesAgua(Ri[num_actual]);
                            resAgua += $"Prueba {i+1} - " + a +"\r\n";
                            prueba += i + 1 + "\r\n";
                            EstadoDelAguaA[pruebasA] = a;
                            pruebasA++;
                            num_actual++;
                        }
                        //imprimir numero de pruebas en el sector A
                        dgvResAgua.Rows[renglon].Cells[2].Value = resAgua;//No de pruebas

                        

                        //sector B
                        prueba = "";
                        resAgua = "";
                        dgvResAgua.Rows[renglon].Cells[3].Value = "B";//Sector
                        for (int i = 0; i < 20; i++)
                        {
                            string a = LimitesAgua(Ri[num_actual]);
                            resAgua += $"Prueba {i + 1} - " + a + "\r\n";
                            prueba += i + 1 + "\r\n";
                            EstadoDelAguaB[pruebasB] = a;
                            pruebasB++;
                            num_actual++;
                        }
                        //imprimir numero de pruebas en el sector A
                        dgvResAgua.Rows[renglon].Cells[4].Value = resAgua;//No de pruebas

                        //sector C
                        prueba = "";
                        resAgua = "";
                        dgvResAgua.Rows[renglon].Cells[5].Value = "C";//Sector
                        for (int i = 0; i < 20; i++)
                        {
                            string a = LimitesAgua(Ri[num_actual]);
                            resAgua += $"Prueba {i + 1} - " + a + "\r\n";
                            prueba += i + 1 + "\r\n";
                            EstadoDelAguaC[pruebasC] = a;
                            pruebasC++;
                            num_actual++;
                        }
                        //imprimir numero de pruebas en el sector A
                        dgvResAgua.Rows[renglon].Cells[6].Value = resAgua;//No de pruebas

                        //sector D
                        prueba = "";
                        resAgua = "";
                        dgvResAgua.Rows[renglon].Cells[7].Value = "D";//Sector
                        for (int i = 0; i < 20; i++)
                        {
                            string a = LimitesAgua(Ri[num_actual]);
                            resAgua += $"Prueba {i + 1} - " + a + "\r\n";
                            prueba += i + 1 + "\r\n";
                            EstadoDelAguaD[pruebasD] = a;
                            pruebasD++;
                            num_actual++;
                        }
                        //imprimir numero de pruebas en el sector A
                        dgvResAgua.Rows[renglon].Cells[8].Value = resAgua;//No de pruebas

                    }
                    
                    txtConclusionAgua.Text = "El elemento más encontrado en el sector:\r\n";

                    RecorrerResultadosAgua(EstadoDelAguaA, "A");
                    RecorrerResultadosAgua(EstadoDelAguaB, "B");
                    RecorrerResultadosAgua(EstadoDelAguaC, "C");
                    RecorrerResultadosAgua(EstadoDelAguaD, "D");

                    txtConclusionAgua.Text += "Puede que estos elementos esten dañando la salud de sus animales.";
                    ImgFlecha.Visible = true;
                }
                panel7.Location = new Point(28, pnexperimento.Location.Y + 26);

                panel7.Visible = true;
                panel8.Visible = true;

                GuardarHisto();

            }
            else
            {
                MessageBox.Show("Debe confirmar primero la distribucion de probabilidad", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            //panel7.Location = new Point(28, pnexperimento.Location.Y + 26);  

            //panel7.Visible = true;
            //panel8.Visible = true;

            //GuardarHisto();
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
            historial.dgvHistorial.Rows[n].Cells[5].Value = txtConclusionGeneral.Text +"\r\n"+txtConclusionAgua.Text;
        }

        private void cmdHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            historial.ShowDialog();
            this.Show();
        }

        //Metodos de la ventanas -------------------------------------------------------------------------
        private void frmProblema_Load(object sender, EventArgs e)
        {
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAcidez_TextChanged_1(object sender, EventArgs e)
        {
            error = false;

            //ciclo para recorrer caracter por caracter 
            foreach (char caracter in txtAcidez.Text)
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
                errorP1.SetError(txtAAcido, "No se admiten letras\nIngresar numeros solamente");
            }
            else
            {
                errorP1.Clear();
            }
            EsconderPaneles();
            CambiarImagenAgua();
            aproba1 = false;
        }

        private void txtAcoloidales_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAcoloidales, "");
        }

        private void CambiarImagenAnimales()
        {
            cmdIngresarAnimales.Image = Properties.Resources.marca_de_verificacion__1_;
        }

        private void txtAcoloidales_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAcoloidales, errorP1, e);
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtAmercurio_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAmercurio, errorP1, e); 
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtAresiduos_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAresiduos, errorP1, e);
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtASulfato_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtASulfato, errorP1, e);
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtAAcido_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAAcido, errorP1, e);
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtAfosfato_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAfosfato, errorP1, e);
            EsconderPaneles();
            CambiarImagenAgua();
            aproba2 = false;
        }

        private void txtAOxidos_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAOxidos, errorP1, e);
        }

        private void txtAcidez_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAcidez, errorP1, e);
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false;
        }

        private void txtAnemia_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtAnemia, errorP1, e);
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false;
        }

        private void txtNormal_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtNormal, errorP1, e);
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false;
        }

        private void txtGlucosa_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtGlucosa, errorP1, e);
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false;
        }

        private void txtalcalinidad_Validating(object sender, CancelEventArgs e)
        {
            inicio.Val(txtalcalinidad, errorP1, e);
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false;
        }

        private void txtAmercurio_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAmercurio, "");
        }

        private void txtAresiduos_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAresiduos, "");
        }

        private void txtASulfato_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtASulfato, "");
        }

        private void txtAAcido_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAAcido, "");
        }

        private void txtAfosfato_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAfosfato, "");
        }

        private void txtAOxidos_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAOxidos, "");
        }

        private void txtAcidez_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAcidez, "");
        }

        private void txtAnemia_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtAnemia, "");
        }

        private void txtNormal_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtNormal, "");
        }

        private void txtGlucosa_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtGlucosa, "");
        }

        private void txtalcalinidad_Validated(object sender, EventArgs e)
        {
            errorP1.SetError(txtalcalinidad, "");
        }

        private void CambiarImagenAgua()
        {
            cmdIngresarAgua.Image = Properties.Resources.marca_de_verificacion__1_;
        }
        private void EsconderPaneles()
        {
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void txtChanged_Animales(object sender, EventArgs e)
        {
            EsconderPaneles();
            CambiarImagenAnimales();
            aproba1 = false; 
        }


        //OBTENCION DE DATOS INGRESADOS POR EL USUARIO -----------------------------------------------------
        float Ani_acidez, Ani_anemia, Ani_normal, Ani_glucosa, Ani_Alcalinindad;
        float Agua_coloidales, Agua_mercurio, Agua_residuos, Agua_sulfato, Agua_acido, Agua_fosfato, Agua_oxidos;
        
        private void cmdIngresarAnimales_Click(object sender, EventArgs e)
        {
            if (error)
            {
                MessageBox.Show("Verifique que los datos sean validos");
            }
            else
            {
                //Recuperacion de datos ingresados por el usuario
                Ani_acidez = float.Parse(txtAcidez.Text) * 0.01F;
                Ani_anemia = float.Parse(txtAnemia.Text) * 0.01F;
                Ani_normal = float.Parse(txtNormal.Text) * 0.01F;
                Ani_glucosa = float.Parse(txtGlucosa.Text) * 0.01F;
                Ani_Alcalinindad = float.Parse(txtalcalinidad.Text) * 0.01F;

                float suma = Ani_acidez + Ani_anemia + Ani_normal + Ani_glucosa + Ani_Alcalinindad;

                txtSuma1.Text = "" + suma;

                if (suma == 1)
                {
                    aproba1 = true;
                    cmdIngresarAnimales.Image = Properties.Resources.marca_de_verificacion__2_;
                    //Crear distribucion acumulada
                }
                else
                {
                    aproba1 = false;
                    if (suma > 1)
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
        }

        private void cmdIngresarAgua_Click(object sender, EventArgs e)
        {
            if(error)
            {
                MessageBox.Show("Verifique que los datos sean validos");
            }
            else
            {
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
                    cmdIngresarAgua.Image = Properties.Resources.marca_de_verificacion__2_;
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
