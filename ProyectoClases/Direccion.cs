using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //CONTRUCTOR VACIO
        public Direccion()
        {
            Debug.WriteLine("Contructor Direccion sin parametros");
        }

        //VARIAS FORMAS DE CREAR UN OBJETO
        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Contructor direccion DOS parametros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor Direccion TRES parámetros");
        }
    }
}
