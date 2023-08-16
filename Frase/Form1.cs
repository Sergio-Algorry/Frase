using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLong_Click(object sender, EventArgs e)
        {
            int Longitud;
            Longitud = txtFrase.Text.Length;

            //lblResultado.Text = Longitud.ToString();
            lblResultado.Text = Convert.ToString(Longitud);
        }

        private void btMayuscula_Click(object sender, EventArgs e)
        {
            lblResultado.Text = txtFrase.Text.ToLower();
        }

        private void btExtraer_Click(object sender, EventArgs e)
        {
            int Longitud = txtFrase.Text.Length;
            string frase = txtFrase.Text;
            string letra;
            int posicionInicial = -1;
            int posicionFinal = -1;

            for (int i = 0; i < Longitud; i++)
            {
                letra = frase.Substring(i, 1);
                if (letra == " " && posicionInicial == -1)
                {
                    posicionInicial = i + 1;
                }
                else if (letra == " " && posicionInicial != -1 )
                {
                    posicionFinal = i - 1;
                    break;
                }

                // sdf jhgjhghjg
                // 0123456789
            }

            lblResultado.Text = 
                frase.Substring(posicionInicial, 
                posicionFinal - posicionInicial + 1);
        }
    }
}
