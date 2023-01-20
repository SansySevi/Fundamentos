using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { Espania, Italia, Francia, Brasil }

    public class Persona
    {

        #region CAMPOS DE PROPIEDAD
        public TipoGenero Genero { get; set; }
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        #endregion

        #region PROPIEDADES
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }


        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //AQUI DESEAMOS COMPROBAR EL DATO QUE VIENE
                //DENTRO DE value
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion


        #region METODOS
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //QUEREMOS DEVOLVER EL NOMBRE EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public void GetNombreCompleto(string dato) { }
        public void GetNombreCompleto(int numero) { }

        public void MetodoParametrosOpcionales(int numero1, int numero2 = 199)
        { }

        #endregion
    }


}
