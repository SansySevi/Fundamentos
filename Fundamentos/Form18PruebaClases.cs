using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Apellidos = "Molina";
            persona.Edad = 23;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Masculino;
            persona.MetodoParametrosOpcionales(99);
            persona.MetodoParametrosOpcionales(88, 66);
            //SI TUVIERAMOS MAS PARAMETROS OPCIONALES : PARAMETRO
            persona.MetodoParametrosOpcionales(44, numero2: 3);
            persona.GetNombreCompleto();

            this.lstDatos.Items.Add(persona.Nombre + ","
                + persona.Apellidos + ",Edad:" + persona.Edad);
            this.lstDatos.Items.Add(persona.Nacionalidad + ","
                + persona.Genero);
        }
    }
}
