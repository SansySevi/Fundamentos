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
    public partial class Form6Email : Form
    {
        public Form6Email()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            if (email.IndexOf("@") == -1)
            {
                this.lblResultado.Text = "No existe @";
                this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                this.lblResultado.Text = "@ al inicio o al final";
                this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Existe más de una @";
                this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else if (email.Contains(".") == false)
            {
                this.lblResultado.Text = "No existe punto";
                this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Debe existir un punto después de @";
                this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Email CORRECTO!!!";
                    this.lblResultado.ForeColor = Color.FromArgb(0, 128, 0);
                }
                else
                {
                    this.lblResultado.Text = "Dominio debe ser de 2 a 4 caracteres";
                    this.lblResultado.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
        }
    }
}
