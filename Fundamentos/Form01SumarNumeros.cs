﻿using System;
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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumasNumeros_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(this.txtNum1.Text);
            int numero2 = int.Parse(this.txtNum2.Text);
            int suma = numero1 + numero2;
            this.lblSuma.Text = suma.ToString();
        }
    }
}
