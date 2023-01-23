using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;
using System.IO;

namespace Fundamentos
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        XmlSerializer serializer;

        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);

            //PARA SERIALIZAR SE UTILIZA EL OBJETO System.IO
            //LLAMDO StreamWriter
            //NO IMPORTA LA EXTASION DEL ARCHIVO, SIEMPRE LO ALMACENA COMO XML
            using (StreamWriter writer = new StreamWriter("mascotas.xml"))
            {
                //EL SERIALIZADOR XML TINEE UN METODO LLAMADO Serialize()
                //que utiliza el fichero para guardar el obejto
                this.serializer.Serialize(writer, mascota);
                //COMO HABLAMOS DE FICHEROS DE ESCRITURA DEBEMOS USAR Flush()
                await writer.FlushAsync();
                writer.Close();
            }

            this.txtEdad.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            //LEER ES IGUAL SOLO QUE UTILIZA UN OBJETO LLAMADO
            //StreamReader
            Mascota mascota = null;
            using(StreamReader reader = new StreamReader("mascotas.xml"))
            {
                //NECESITAMOS RECUPERAR EL OBEJTO MASCOTA
                //MEDIANTE EL SERIALIZADOR TIENE UN METODO
                //LLAMADO Deserialize() QUE RECUPERA EL OBEJTO SERIALIZADO
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();
        }
    }
}
