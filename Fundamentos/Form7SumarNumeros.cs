using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form7SumarNumeros : Form
    {
        public Form7SumarNumeros()
        {
            InitializeComponent();
        }

        private void lblNumeros_Click(object sender, EventArgs e)
        {

        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma es " + suma;
        }
    }
}
