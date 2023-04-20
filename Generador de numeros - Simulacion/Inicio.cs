using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void txtSemilla_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSemilla_KeyDown(object sender, KeyEventArgs e)
        {      
        }


        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtA_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtC_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void txtM_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

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
