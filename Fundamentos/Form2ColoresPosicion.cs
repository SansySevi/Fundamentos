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
    public partial class Form2ColoresPosicion : Form
    {
        public Form2ColoresPosicion()
        {
            InitializeComponent();
        }

        private void Form2ColoresPosicion_Load(object sender, EventArgs e)
        {

        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosicionX.Text);
            int posY = int.Parse(this.txtPosicionY.Text);
            this.btnPosicion.Location = new Point(posX, posY);
            this.btnPosicion.Font = new Font("Verdana", 22);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            //int rojo = int.Parse(this.txtRojo.Text);
            //int verde = int.Parse(this.txtVerde.Text);
            //int azul = int.Parse(this.txtAzul.Text);
            //this.BackColor = Color.FromArgb(rojo, verde, azul);

            int red = int.Parse(this.txtRojo.Text);
            int green = int.Parse(this.txtVerde.Text);
            int blue = int.Parse(this.txtAzul.Text);
            //LOS COLORES SON ENTRE 0 Y 255
            if (red < 0 || red > 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255");
            }else if (green < 0 || green > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255");
            }
            else if (blue < 0 || blue > 255)
            {
                MessageBox.Show("El color Azul debe estar entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }

        }
    }
}
