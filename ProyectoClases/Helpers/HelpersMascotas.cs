using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    internal class HelpersMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelpersMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        //TENDREMSO METODOS QUE SERAN LAS TRIPAS DE LA CLASE
        //VAMOS A LEER UN FILE Y CONTENDRA UN TEXTO CON LAS MASCOTAS
        private void CreateMascotas(string data)
        {
            //LIMPIAMOS LA COLECCION
            this.Mascotas.Clear();
            //SPERAMOS LOS OBEJETOS
            string[] datosmascotas = data.Split(',');
            foreach (string d in datosmascotas)
            {
                //SEPARAMOS CADA PROPIEDAD
                string[] propiedades = d.Split("#");
                //INTANCIAMOS CADA MASCOTA
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //CUANDO LEAMOS EL FICHERO DE MASCOTAS, LAS CREAREMOS
        //NECESITAMOS LA RUTA
        public async Task ReadFileMascotasAsync (string path)
        {
            string data = await HelpersFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        //AL ECSRIBIR VAMO A DIBUJAR TODAS LAS MASCOTAS
        //CON LOS SEPARADORES QUE HEMOS PENSADO
        private string GetMascotasString()
        {
            string data = "";
            //RECORREMOS LA COLECCION List<Mascota>
            //Y LE DAMOS FORMATO STRING
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
            }
            data.Trim(',');
            return data;
        }


        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
            await HelpersFiles.WriteFileAsync(path, data);
        }
    }
}
